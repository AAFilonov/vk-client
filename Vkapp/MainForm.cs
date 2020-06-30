using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Extensions.DependencyInjection;
using System.Net;
using VkNet;
using VkNet.Model;
using VkNet.Enums.Filters;
using VkNet.Model.RequestParams;
using VkNet.AudioBypassService.Extensions;
using VkNet.Abstractions;
using System.IO;

namespace Vkapp
{
    public partial class MainForm : Form
    {
        long PageUserid;
        ulong? LastConversation;
        public MainForm()
        {
            InitializeComponent();

            var services = new ServiceCollection();
            services.AddAudioBypass();
            VK.api = new VkApi(services);

            LoginForm login = new LoginForm();
            login.ShowDialog();
            DialogPictureList = new ImageList();
            DialogPictureList.ImageSize = new Size(100, 100);
            DialogPictureList.ColorDepth = ColorDepth.Depth32Bit;
            LastConversation = 0;
            
        }
        private void MainForm_Load(object sender, EventArgs e)
        {

            if (!VK.api.IsAuthorized)
                Close();
            else
            {
                PageUserid = (long)VK.api.UserId;
                Page.SelectedTab = TabUserInfo;
                LoadUserinfo();
            }
        }
      
        private async void LoadMessagesList(ulong? n, ulong? offset)
        {

            GetConversationsResult Conversations = new GetConversationsResult();
           Task <GetConversationsResult> outerTask = VK.api.Messages.GetConversationsAsync(new GetConversationsParams { Count = n, Offset = offset, Extended = true});

           await outerTask.ContinueWith(task =>{Conversations = task.Result;});
            foreach (var i in Conversations.Items)
            {

                ListViewItem tmp = new ListViewItem();
                var settings = i.Conversation.ChatSettings;
                string pic_url= "https://vk.com/images/camera_100.png";
                //Заголовок Диалога и задания url пикчи
                if (i.Conversation.Peer.Type.ToString() == "user")
                {
                    var usr = VK.api.Users.Get(new long[] { i.Conversation.Peer.Id }, ProfileFields.FirstName | ProfileFields.LastName | ProfileFields.Photo100).SingleOrDefault();
                    tmp.Text = usr.FirstName + " " + usr.LastName;
                    pic_url = usr.Photo100.ToString();

                }
                else if (i.Conversation.Peer.Type.ToString() == "chat")
                {
                    tmp.Text = i.Conversation.ChatSettings.Title;
                    var PicUrl = i.Conversation.ChatSettings.Photo.Photo100;
                    if(PicUrl != null) pic_url =PicUrl.ToString();

                }
                else if (i.Conversation.Peer.Type.ToString() == "group")
                {
                    tmp.Text = "Группа";
                }

                string messageprev = i.LastMessage.Text;

                if (messageprev == "")
                {
                    var attachm = i.LastMessage.Attachments.FirstOrDefault();
                    if (attachm == null)
                    {
                        messageprev = "Пересланное сообщение";
                    }
                    else
                    {
                        messageprev = attachm.Type.Name.ToString();
                    }


                }
                var user = VK.api.Users.Get(new long[] { i.LastMessage.FromId.Value }, ProfileFields.FirstName | ProfileFields.LastName | ProfileFields.Photo100).SingleOrDefault();

                messageprev = (user.Id == VK.api.UserId ? "Вы" : user.FirstName + " " + user.LastName  ) + ": " + messageprev;
                //Превью Сообщения
                tmp.SubItems.Add(new ListViewItem.ListViewSubItem
                {
                    Text = messageprev
                });
                //Количество непрочитанных сообщений
                tmp.SubItems.Add(new ListViewItem.ListViewSubItem
                {
                    Text = i.Conversation.UnreadCount.ToString()
                });
                //Дата
                tmp.SubItems.Add(new ListViewItem.ListViewSubItem
                {
                    Text = DateSince((DateTime)i.LastMessage.Date)
                });
                WebClient w = new WebClient();

                DialogPictureList.Images.Add(tmp.Text, LoadImageFromUrl(pic_url));
                ConversationsList.Items.Add(tmp);
            }
        }

       
        private void ConversationsList_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (ConversationsList.SelectedItems.Count > 0)
            {
                var Dialog = ConversationsList.SelectedItems[0];
                DialogTitleLabel.Text = Dialog.Text;
                DialogTextPrevLabel.Text = Dialog.SubItems[1].Text;
                UreadedCountLabel.Text = Dialog.SubItems[2].Text;
                DialogDateLabel.Text =Dialog.SubItems[3].Text;
                if (UreadedCountLabel.Text != "" )
                    UreadedCountLabel.Visible = true;
                else
                    UreadedCountLabel.Visible = false;
                DialogPicture.Image = DialogPictureList.Images[Dialog.Text];

                DialogTitleLabel.Visible = true;
                DialogTextPrevLabel.Visible = true;
                DialogDateLabel.Visible = true;
                DialogGoLabel.Visible = true;
            }
        }
        private void ActionList_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActionList.Focus();
            int active = ActionList.SelectedIndex;
            PageUserid = (long)VK.api.UserId;
            switch (active)
            {
                case 0:
                    Page.SelectedTab = TabUserInfo;
                    break;
                case 1:

                    Page.SelectedTab = TabConversations;
                    break;
                case 2:
                    Page.SelectedTab = TabGroups;
                    break;
                case 3:
                    Page.SelectedTab = TabFriends;
                    break;
                case 4:
                    Page.SelectedTab = TabSettings;
                    break;
                case 5:
                    DialogResult result = MessageBox.Show(
                        "Вы действиетльно желаете выйти?",
                        "Внимание",
                        MessageBoxButtons.OKCancel,
                        MessageBoxIcon.Exclamation,
                        MessageBoxDefaultButton.Button1,
                        MessageBoxOptions.DefaultDesktopOnly);

                    if (result == DialogResult.OK)
                    {

                        LogOutAsync();
                        System.Windows.Forms.Application.Exit();
                    }
                    break;


            }
            ActionList.ClearSelected();
        }
        private void Page_Selecting(object sender, TabControlCancelEventArgs e)
        {
            switch (e.TabPage.Name)
            {
                case "TabUserInfo":

                    LoadUserinfo();
                    break;
                case "TabConversations":
                    ConversationsList.Items.Clear();
                    LastConversation = 0;
                    LoadMessagesList(20, LastConversation);
                    LastConversation += 20;
                    break;

                case "TabDialog":

                    break;
                case "TabGroups":

                    break;
                case "TabFriends":

                    break;
                case "TabSettings":
                    break;
                case "TabWall":
                    break;
                default:
                    break;
            }
        }

        private string DateSince(DateTime t)
        {

            var now = DateTime.Now;
            var difference = now.Subtract(t);

            if (difference.Days == 0)
            {
                return t.ToShortTimeString();
            }
            else if (t.Year <= now.Year)
            {
                return t.Day.ToString() + "." + t.ToString("MMM");
            }
            else
            {
                return t.Date.ToString();
            }

        }
        private System.Drawing.Image LoadImageFromUrl(string url)
        {

            WebClient client = new WebClient();
            byte[] imageByte = client.DownloadData(url);
            MemoryStream stream = new MemoryStream(imageByte);
            System.Drawing.Image im = System.Drawing.Image.FromStream(stream);
            return im;
        }
        private void LoadUserinfo()
        {

            var MyUser = VK.api.Users.Get(new long[] { PageUserid }, ProfileFields.All).FirstOrDefault();

            StatusLabel.Text = VK.api.Status.Get(MyUser.Id).Text;
            NameLabel.Text = MyUser.FirstName + " " + MyUser.LastName;
            OnlineStatusLabel.Text = OnlineStatus(MyUser);
            if (MyUser.Country != null) UserCountryLabel.Text = MyUser.Country.ToString();
            if (MyUser.City != null) UserCountryLabel.Text += " " + MyUser.City;
            MyAvatarPicture.Load(MyUser.PhotoMaxOrig.ToString());

            UserFriendsButton.Text = MyUser.Counters.Friends.ToString() + " друзей";
            UserFollowersButton.Text = MyUser.Counters.Followers.ToString() + " подпищиков";
            UserPhotoButton.Text = MyUser.Counters.Photos.ToString() + " фотографий";
            UserAudioButton.Text = MyUser.Counters.Audios.ToString() + " аудиозаписей";
            UserGroupButton.Text = MyUser.Counters.Groups.ToString() + " групп";
        }
        private void UserUpdateButton_Click(object sender, EventArgs e)
        {
            LoadUserinfo();
        }
        private void AddConversationButton_Click(object sender, EventArgs e)
        {
            LoadMessagesList(20, LastConversation);
            LastConversation += 20;
        }
        private void ReloadConversationButton_Click(object sender, EventArgs e)
        {
            ConversationsList.Items.Clear();
            LoadMessagesList(LastConversation, 0);
        }
        private async void LogOutAsync()
        {
            await VK.api.LogOutAsync();
        }
        private string OnlineStatus(VkNet.Model.User User)
        {
            if ((bool)User.Online)
            {
                return "Online";
            }
            else
            {
                return "Был в сети \n" + User.LastSeen.Time.ToString();
            }
        }

        private void DialogDateLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
