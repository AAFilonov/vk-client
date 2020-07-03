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
        private void InitFriendsListView()
        {
            FriendsListView1.OwnerDraw = true;
            FriendsListView1.ShowGroups = false;
            var ColumnList = FriendsListView1.AllColumns.ToList();
            ColumnList[0].AspectToStringConverter = delegate (object x) {
                return String.Empty;
            };
            ColumnList[0].ImageGetter += delegate (object x) {
                var tmp = (User)x;

                return FriendsPictureList.Images[tmp.Id.ToString()];
            };
            ColumnList[1].FillsFreeSpace = true;
            ColumnList[2].FillsFreeSpace = true;
            //ColumnList[1].AspectToStringConverter = delegate (object x) {
            //    var tmp = (User)x;
            //
            //    return tmp.FirstName.ToString() +" "+tmp.LastName.ToString();
            //};
        }

        int FriendListOffset;
        int FriendsCount;
        private void Load20Friends()
        {
            var FriendList = D.api.Friends.Get(new FriendsGetParams() { UserId = D.Context.SeenUser, Count = 20, Offset = FriendListOffset, Fields = ProfileFields.FirstName | ProfileFields.LastName | ProfileFields.Photo50 }).ToList();
            foreach (var i in FriendList)
            {
                if (!FriendsPictureList.Images.ContainsKey((i.Id.ToString())))
                    FriendsPictureList.Images.Add(i.Id.ToString(), LoadImageFromUrl(i.Photo50.ToString()));
            }

            FriendListOffset += FriendList.Count;
            FriendsListView1.AddObjects(FriendList);
        }
        private async void LoadFriendsTab()
        {


            FriendsListView1.ClearObjects();
            await Task.Run(() => {
                Load20Friends();


            });
        }


        private void FriendsListView1_ItemActivate(object sender, EventArgs e)
        {
            var u = (User)FriendsListView1.SelectedItem.RowObject;
            D.Context.SeenUser = u.Id;
            Page.SelectedTab = TabUserInfo;
        }

        private void UserFriendsButton_Click(object sender, EventArgs e)
        {
            D.PreviosPagesContexts.Push(D.Context);
            Page.SelectedTab = TabFriends;
        }

        private void FriendsListView1_Scroll(object sender, ScrollEventArgs e)
        {

            var s = ((BrightIdeasSoftware.ObjectListView)sender);

            if (s.Items.Count < FriendsCount && e.NewValue >= s.Items.Count - 10)
            {
                Load20Friends();
            }
        }
    }
}
