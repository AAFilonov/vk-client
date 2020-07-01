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
        ulong? TotalDialogsCount;
      
        List<MyDialog> DialogsList;
    
        private void ObjListInit()
        {
            ObjDialogList.OwnerDraw = true;
            ObjDialogList.HeaderStyle = ColumnHeaderStyle.None; 
            ObjDialogList.RowHeight = 60;

            //Creating the columns
            BrightIdeasSoftware.OLVColumn PictureColumn = new BrightIdeasSoftware.OLVColumn();
            BrightIdeasSoftware.OLVColumn TitleColumn = new BrightIdeasSoftware.OLVColumn();
            BrightIdeasSoftware.OLVColumn PrevColumn = new BrightIdeasSoftware.OLVColumn();
            BrightIdeasSoftware.OLVColumn UnreadMsgColumn = new BrightIdeasSoftware.OLVColumn();
            BrightIdeasSoftware.OLVColumn DateColumn = new BrightIdeasSoftware.OLVColumn();

            //Adding the columns to the Objectlistview
            ObjDialogList.AllColumns.Add(PictureColumn);
            ObjDialogList.AllColumns.Add(TitleColumn);
            ObjDialogList.AllColumns.Add(PrevColumn);
            ObjDialogList.AllColumns.Add(UnreadMsgColumn);
            ObjDialogList.AllColumns.Add(DateColumn);

            //Directing the columns to the correct variable names. 

            PictureColumn.ImageAspectName = "image";
            TitleColumn.AspectName = "Title";
            PrevColumn.AspectName = "Prev";
            UnreadMsgColumn.AspectName = "UnreadMsg";
            DateColumn.AspectName = "Date";

     
            //Setting the header name on each column
             PictureColumn.Text = "Image";
            TitleColumn.Text = "Title";
            PrevColumn.Text = "Prev";
            UnreadMsgColumn.Text = "UnreadMsg";
            DateColumn.Text = "Date";
            //Set the columns to fill the width of the objectlistview

            PictureColumn.FillsFreeSpace = true;
            PrevColumn.FillsFreeSpace = true;
           // UnreadMsgColumn.FillsFreeSpace = true;
            DateColumn.FillsFreeSpace = true;

            PictureColumn.AspectToStringConverter = delegate (object x) {
                return String.Empty;
            };


            DateColumn.AspectToStringConverter = delegate (object x) {
                DateTime t = (DateTime)x;
                t= t.AddHours(3);
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
            };



            ObjDialogList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
                    PictureColumn,
                    TitleColumn,
                    PrevColumn,
                    UnreadMsgColumn,
                    DateColumn
                });
            ObjDialogList.PrimarySortColumn = DateColumn;
            ObjDialogList.Sorting = SortOrder.Descending;
        }
      
        public MainForm()
        {
            InitializeComponent();

            var services = new ServiceCollection();
            services.AddAudioBypass();
            VK.api = new VkApi(services);

            LoginForm login = new LoginForm();
            login.ShowDialog();

            DialogsList = new List<MyDialog>();
            DialogPictureList = new ImageList();
            DialogPictureList.ImageSize = new Size(50, 50);
            DialogPictureList.ColorDepth = ColorDepth.Depth32Bit;
            TotalDialogsCount = 0;


        }
        private void MainForm_Load(object sender, EventArgs e)
        {

            if (!VK.api.IsAuthorized)
                Close();
            else
            {
                PageUserid = (long)VK.api.UserId;
                Page.SelectedTab = TabConversations;
                LoadUserinfo();

                ObjListInit();
                DialogsAddAsync();
            }

        }





        private async void DialogsAddAsync( )
        {
            const ulong AddCount = 20;
            Task<GetConversationsResult> outerTask = VK.api.Messages.GetConversationsAsync(new GetConversationsParams
            {
                Count = AddCount,
                Offset = TotalDialogsCount,
                Fields = new List<string> { "All" }
            });
            GetConversationsResult results = new GetConversationsResult();
            await outerTask.ContinueWith(task =>
            {
                results = task.Result;
                foreach (var i in results.Items)
                {
                     DialogsList.Add(new MyDialog(i.Conversation, i.LastMessage));
                     //DialogPictureList.Images.Add(DialogsList.Last().Name, LoadImageFromUrl(DialogsList.Last().PicUrl));
                }
            });
            ObjDialogList.AddObjects(DialogsList);
            TotalDialogsCount+=AddCount;

        }
        private async void DialogsUpdAsync()
        {
         
            Task<GetConversationsResult> outerTask = VK.api.Messages.GetConversationsAsync(new GetConversationsParams
            {
                Count = TotalDialogsCount,
                Offset = 0,
                Fields = new List<string> { "All" }
            });
            GetConversationsResult results = new GetConversationsResult();
            await outerTask.ContinueWith(task =>
            {
                results = task.Result;

                for (var i =0;i<DialogsList.Count;i++)
                {
                   DialogsList[i].UpdateInfo(results.Items[i].LastMessage, results.Items[i].Conversation);

                }
            });
            ObjDialogList.UpdateObjects(DialogsList);


        }


       

     
        /*
        private void ConversationsList_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (ConversationsList.SelectedItems.Count > 0)
            {
                var Dialog = ConversationsList.SelectedItems[0];
                DialogTitleLabel.Text = Dialog.Text;
                DialogTextPrevLabel.Text = Dialog.SubItems[1].Text;
                UreadedCountLabel.Text = Dialog.SubItems[2].Text;
                DialogDateLabel.Text = Dialog.SubItems[3].Text;
                if (UreadedCountLabel.Text != "")
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
        */
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


        private System.Drawing.Image LoadImageFromUrl(string url)
        {

            WebClient client = new WebClient();
            byte[] imageByte = client.DownloadData(url);
            MemoryStream stream = new MemoryStream(imageByte);
            System.Drawing.Image im = System.Drawing.Image.FromStream(stream);
            return im;
        }


        /*
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
       private ListViewItem ConvInfoUpdate(ListViewItem item,DialogInfo i)
        {
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
            messageprev = (user.Id == VK.api.UserId ? "Вы" : user.FirstName + " " + user.LastName) + ": " + messageprev;
            //Превью Сообщения
            item.SubItems[0].Text = messageprev;
            //Количество непрочитанных сообщений
            item.SubItems[1].Text = i.C.UnreadCount.ToString();
            //Дата
            item.SubItems[2].Text = DateSince((DateTime)i.LastMessage.Date); 
            return item;
        }
       //private ListViewItem ConvInfoLoad(MyDialog i)
        {
            ListViewItem tmp = new ListViewItem();
           
            string pic_url = "https://vk.com/images/camera_100.png";

            //Заголовок Диалога и задания url пикчи
            if (i.C.Peer.Type.ToString() == "user")
            {
                var usr = VK.api.Users.Get(new long[] { i.C.Peer.Id }, ProfileFields.FirstName | ProfileFields.LastName | ProfileFields.Photo100).SingleOrDefault();
                tmp.Text = usr.FirstName + " " + usr.LastName;
                pic_url = usr.Photo100.ToString();

            }
            else if (i.C.Peer.Type.ToString() == "chat")
            {
                tmp.Text = i.C.ChatSettings.Title;
                var PicUrl = i.C.ChatSettings.Photo.Photo100;
                if (PicUrl != null) pic_url = PicUrl.ToString();

            }
            else if (i.C.Peer.Type.ToString() == "group")
            {
                tmp.Text = "Группа";
            }
            tmp.Name = i.C.Peer.Id.ToString();
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

            messageprev = (user.Id == VK.api.UserId ? "Вы" : user.FirstName + " " + user.LastName) + ": " + messageprev;
            //Превью Сообщения
            tmp.SubItems.Add(new ListViewItem.ListViewSubItem
            {
                Text = messageprev
            });
            //Количество непрочитанных сообщений
            tmp.SubItems.Add(new ListViewItem.ListViewSubItem
            {
                Text = i.C.UnreadCount.ToString()
            });
            //Дата
            tmp.SubItems.Add(new ListViewItem.ListViewSubItem
            {
                Text = DateSince((DateTime)i.LastMessage.Date)
            });
            WebClient w = new WebClient();

            DialogPictureList.Images.Add(tmp.Text, LoadImageFromUrl(pic_url));
            ConversationsList.Items.Add(tmp);
            return tmp;
        }
        */

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
            
            DialogsAddAsync();
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
       

        private void UpdateConversationButton_Click(object sender, EventArgs e)
        {

            DialogsUpdAsync();
        }
    }
}
