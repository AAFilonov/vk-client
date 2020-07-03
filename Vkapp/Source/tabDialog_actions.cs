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
        private struct Msg
        {
           public string Image;
           public string Name;
           public String Text;
           public DateTime Date;
          //  VkNet.Model.Message Message;
            public Msg(VkNet.Model.Message Message)
            {
               // this.Message = Message;
                Image = Message.FromId.Value.ToString();
                Text = Message.Text;
                if (Text == "") Text = "Вложение";
                Name = Message.FromId.ToString();
                Date = Message.Date.Value;
            }
        }
        static int State;
        User User;
        List<VkNet.Model.User> UserList;
        List<VkNet.Model.Message> MsgList;
        long? lastMesage;
        long? FirestMesage;
        long? Total;
        

        private  void LoadMoreMessages()
        {

            MessageGetHistoryObject results = D.api.Messages.GetHistory(new MessagesGetHistoryParams() {
                PeerId = D.Context.ActiveChat.Conv.Peer.Id,
                Offset = lastMesage

            });
            lastMesage += 20;
            MsgList.AddRange(results.Messages);


            foreach ( var i in results.Messages)
            {

               
                var tmpitem = new ListViewItem();
                var u = UserList.Find(item => item.Id == i.FromId);
                tmpitem.Text = u.FirstName + " " + u.LastName;
                ListViewItem.ListViewSubItem t1= new ListViewItem.ListViewSubItem();
                ListViewItem.ListViewSubItem t2= new ListViewItem.ListViewSubItem();
                t1.Text = i.Text;
                if (t1.Text == "") t1.Text = "Вложение";
                t2.Text = DateSince((DateTime)i.Date);
                tmpitem.SubItems.Add(t1);
                tmpitem.SubItems.Add(t2);
                ListViewMsg.Items.Add(tmpitem);
            }

            // MessagesListView.Clear();
         
        }
        private void LoadMessages()
        {
            List<VkNet.Model.Message> results = new List<VkNet.Model.Message>();
            int last = -1;
            do
            {
                results.AddRange(D.api.Messages.GetHistory(new MessagesGetHistoryParams() { PeerId = D.Context.ActiveChat.Conv.Peer.Id }).Messages.ToList());

                last = results.FindIndex(item => item.Id == MsgList.First().Id);
                if (last == 0) return;
            } while (last == -1);
            var Addition = new List<VkNet.Model.Message>();
            Addition = results.GetRange(0, last);
            lastMesage += Addition.Count();
            MsgList.InsertRange(0, Addition);
            foreach (var i in Addition)
            {

                var tmpitem = new ListViewItem();
                var u = UserList.Find(item => item.Id == i.FromId);
                tmpitem.Text = u.FirstName + " " + u.LastName;
                ListViewItem.ListViewSubItem t1 = new ListViewItem.ListViewSubItem();
                ListViewItem.ListViewSubItem t2 = new ListViewItem.ListViewSubItem();
                t1.Text = i.Text;
                if (t1.Text == "") t1.Text = "Вложение";
                t2.Text = DateSince((DateTime)i.Date);
                tmpitem.SubItems.Add(t1);
                tmpitem.SubItems.Add(t2);
                ListViewMsg.Items.Insert(0,  tmpitem);
            }


        }
        /*
        private void InitMessagesListView()
        {
            MessagesListView.OwnerDraw = true;
            MessagesListView.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            MessagesListView.RowHeight = 50;

            //Creating the columns
            BrightIdeasSoftware.OLVColumn PictureColumn = new BrightIdeasSoftware.OLVColumn();
            BrightIdeasSoftware.OLVColumn TitleColumn = new BrightIdeasSoftware.OLVColumn();
            BrightIdeasSoftware.OLVColumn TextColumn = new BrightIdeasSoftware.OLVColumn();
            BrightIdeasSoftware.OLVColumn DateColumn = new BrightIdeasSoftware.OLVColumn();

            //Adding the columns to the Objectlistview
            MessagesListView.AllColumns.Add(PictureColumn);
            MessagesListView.AllColumns.Add(TitleColumn);
            MessagesListView.AllColumns.Add(TextColumn);
            MessagesListView.AllColumns.Add(DateColumn);

            //Directing the columns to the correct variable names. 

           
            PictureColumn.AspectName = "Image";
            TitleColumn.AspectName = "Name";
            TextColumn.AspectName = "Text";
            DateColumn.AspectName = "Date";


            //Setting the header Title on each column
            PictureColumn.Text = "Image";
            TitleColumn.Text = "Name";
            TextColumn.Text = "Text";
            DateColumn.Text = "Date"; ;
            //Set the columns to fill the width of the objectlistview

            // PictureColumn.FillsFreeSpace = true;
            //TitleColumn.FillsFreeSpace = true;
            
            TextColumn.WordWrap = true;
         
            TitleColumn.WordWrap = true;
            TextColumn.FillsFreeSpace = true;
         
           
            DateColumn.AspectToStringConverter = delegate (object x)
            {
                DateTime t = (DateTime)x;
                t = t.AddHours(3);
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
        }*/
        private void ButtonSendDialog_Click(object sender, EventArgs e)
        {
            var Params = new VkNet.Model.RequestParams.MessagesSendParams();
            Params.Message = RichTextBoxDialog.Text;
            Params.RandomId = new Random().Next();
            Params.PeerId = D.Context.ActiveChat.Conv.Peer.LocalId;
            var Msg = D.api.Messages.Send(Params);
            RichTextBoxDialog.Clear();
        }
        private void LoadUsers()
        {
            var l = D.api.Messages.GetConversationMembers(D.Context.ActiveChat.Conv.Peer.Id,null);
            UserList.AddRange(l.Profiles);
        }
        private void LoadDialogTab()
        {
            MsgList = new List<VkNet.Model.Message>();
            UserList = new List<User>();
         
            timer1.Interval = 1000;
            lastMesage=0;
            FirestMesage=0;
            Total = 0;
         
            LoadUsers();




            LoadMoreMessages();
           
            TabDialogNameLabel.Text = D.Context.ActiveChat.Title;
            TabdialogPictureBox.Image = D.Context.ActiveChat.image;
            
            switch (D.Context.ActiveChat.Conv.Peer.Type.ToString())
            {
                case "user":
                    User = D.api.Users.Get(new long[] { D.Context.ActiveChat.Conv.Peer.Id }, ProfileFields.All).FirstOrDefault();
                    TabDialogOnlineLabel.Text = OnlineStatus(User);
                    State = 0;
                    break;
                case "Chat":
                    State = 1;
                    break;
                case "group":
                    State = 2;
                    break;
            }
           // D.api.Messages.


        }
        private void TabDialogNameLabel_Click(object sender, EventArgs e)
        {
            if (State == 0)
            {
                D.Context.SeenUser = D.Context.ActiveChat.Conv.Peer.Id;
                Page.SelectedTab = TabUserInfo;
            }
        }
        private  void timer1_Tick(object sender, EventArgs e)
        {

          
               LoadMessages(); 
       

        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            timer1.Enabled = !checkBox1.Checked;
        }


        private  void ReloadButton_Click(object sender, EventArgs e)
        {
           
                LoadMessages();
           
        }
        private void LoadMoreButton_Click(object sender, EventArgs e)
        {
            LoadMoreMessages();
        }
    }
}
