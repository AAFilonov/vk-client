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

using static Vkapp.MainForm;
namespace Vkapp
{
    public partial class MainForm : Form
    {

        public void TabUserInfoGoToMessageButton_Click(object sender, EventArgs e)
        {
            D.PreviosPagesContexts.Push(D.Context);
            D.Context.Tab = TabDialog;
          //  D.Context.ActiveChat=  D.api.Messages.get;
        }

        private void UserUpdateButton_Click(object sender, EventArgs e)
        {
            LoadUserinfo();
        }
        public void TabUserInfoFriendButton_Click(object sender, EventArgs e)
        {
            switch ((int)D.api.Friends.AreFriends(new long[] { (long)D.Context.SeenUser}).FirstOrDefault().FriendStatus)
            {
                case 0:
                    TabUserInfoFriendButton.Text = "Добавить в друзья";
                    break;
                case 1:
                    TabUserInfoFriendButton.Text = "Заявка отправлена";
                    break;
                case 2:
                    TabUserInfoFriendButton.Text = "Подписан на вас";
                    TabUserInfoFollowYouLabel.Visible = true;
                    break;
                case 3:
                    TabUserInfoFriendButton.Text = "У Вас в друзьях";
                    break;

            }
        }
        public void LoadUserinfo()
        {

            var MyUser = D.api.Users.Get(new long[] { (long)D.Context.SeenUser }, ProfileFields.All).FirstOrDefault();

            StatusLabel.Text = D.api.Status.Get(MyUser.Id).Text;
            NameLabel.Text = MyUser.FirstName + " " + MyUser.LastName;
            OnlineStatusLabel.Text = OnlineStatus(MyUser);
            if (MyUser.Country != null) UserCountryLabel.Text = MyUser.Country.Title.ToString();
            if (MyUser.City != null) UserCountryLabel.Text += " " + MyUser.City.Title.ToString();
            MyAvatarPicture.Load(MyUser.PhotoMaxOrig.ToString());

            UserFriendsButton.Text = MyUser.Counters.Friends.ToString() + " друзей";
            UserFollowersButton.Text = MyUser.Counters.Followers.ToString() + " подпищиков";
            UserPhotoButton.Text = MyUser.Counters.Photos.ToString() + " фотографий";
            UserAudioButton.Text = MyUser.Counters.Audios.ToString() + " аудиозаписей";
            UserGroupButton.Text = MyUser.Counters.Groups.ToString() + " групп";

            if (D.Context.SeenUser == D.MyUserID)
            {
                TabUserInfoGoToMessageButton.Visible = false;
                TabUserInfoFriendButton.Visible = false;
                TabUserInfoFriendActionsButton.Visible = false;
            }
            else
            {
                TabUserInfoFollowYouLabel.Visible = false;
                switch ((int)D.api.Friends.AreFriends(new long[] { (long)D.Context.SeenUser }).FirstOrDefault().FriendStatus)
                {
                    case 0:
                        TabUserInfoFriendButton.Text = "Добавить в друзья";
                        break;
                    case 1:
                        TabUserInfoFriendButton.Text = "Заявка отправлена";
                        break;
                    case 2:
                        TabUserInfoFriendButton.Text = "Подписан на вас";
                        TabUserInfoFollowYouLabel.Visible = true;
                        break;
                    case 3:
                        TabUserInfoFriendButton.Text = "У Вас в друзьях";
                        break;

                }
            }


        }
       
    }
}
