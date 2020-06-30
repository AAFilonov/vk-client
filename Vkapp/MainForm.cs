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

using VkNet;
using VkNet.Model;
using VkNet.Enums.Filters;
using VkNet.Model.RequestParams;
using VkNet.AudioBypassService.Extensions;
using VkNet.Abstractions;

namespace Vkapp
{
    public partial class MainForm : Form
    {
        long PageUserid;
   
        public MainForm()
        {
            InitializeComponent();

            var services = new ServiceCollection();
            services.AddAudioBypass();
            VK.api = new VkApi(services);

            LoginForm login = new LoginForm();
            login.ShowDialog();           
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
        private void LoadUserinfo()
        {
        
            var MyUser=  VK.api.Users.Get(new long[] {PageUserid },ProfileFields.All).FirstOrDefault();


            StatusLabel.Text = VK.api.Status.Get(MyUser.Id).Text;
            NameLabel.Text = MyUser.FirstName+" "+ MyUser.LastName;
            OnlineStatusLabel.Text = OnlineStatus(MyUser);
            if (MyUser.Country != null) UserCountryLabel.Text = MyUser.Country.ToString();
            if(MyUser.City!=null) UserCountryLabel.Text +=  " " + MyUser.City;
            MyAvatarPicture.Load(MyUser.PhotoMaxOrig.ToString());

            UserFriendsButton.Text = MyUser.Counters.Friends.ToString()+" друзей";
            UserFollowersButton.Text = MyUser.Counters.Followers.ToString() + " подпищиков";
            UserPhotoButton.Text = MyUser.Counters.Photos.ToString() + " фотографий";
            UserAudioButton.Text = MyUser.Counters.Audios.ToString() + " аудиозаписей";
            UserGroupButton.Text = MyUser.Counters.Groups.ToString() + " групп";
          

        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            
            if (!VK.api.IsAuthorized)
                Close();
            else
            {
                PageUserid = (long)VK.api.UserId;

                Page.SelectedTab = TabUserinfo;
                LoadUserinfo();


            }
        }
        private async void LogOutAsync()
        {
             await VK.api.LogOutAsync();
        }


        private void ActionList_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActionList.Focus();
            int active = ActionList.SelectedIndex;
            switch (active)
            {
                case 0:
                    PageUserid = (long)VK.api.UserId;
                    Page.SelectedTab = TabUserinfo;
                   
                    break;
                case 1:
                    Page.SelectedTab = TabMessages;
                    break;
                
                case 2:
                    Page.SelectedTab = TabGroups;
                    break;
                case 3:
                    Page.SelectedTab = TabFriends;
                    break;
                case 4:
                    Page.SelectedTab =TabSettings;
                    break;
                case 5:
                    DialogResult result = MessageBox.Show(
                        "Вы действиетльно желаете выйти?",
                        "Внимание",
                        MessageBoxButtons.OKCancel,
                        MessageBoxIcon.Exclamation,
                        MessageBoxDefaultButton.Button1,
                        MessageBoxOptions.DefaultDesktopOnly);
                   
                    if(result == DialogResult.OK)
                    {

                        LogOutAsync();
                        System.Windows.Forms.Application.Exit();
                    }
                    break;

                    
            }
            ActionList.ClearSelected();
        }

       

        private void UserUpdateButton_Click(object sender, EventArgs e)
        {
            LoadUserinfo();
        }

        private void Page_Selecting(object sender, TabControlCancelEventArgs e)
        {
            switch (e.TabPageIndex)
            {
                case 0:
                   
                    LoadUserinfo();
                    break;
                case 1:
                
                    break;

                case 2:
                   
                    break;
                case 3:
                   
                    break;
                case 4:
                  
                    break;
                case 5:
                    break;
            }
        }
    }
}
