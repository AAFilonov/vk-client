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
            string Image;
            string Name;
            String Text;
            DateTime Date;
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
        List<Msg> MsgList;
        private  void LoadMessages()
        {
           // MsgList.Clear();
            //Task<MessageGetHistoryObject> outerTask  = D.api.Messages.GetHistoryAsync(new MessagesGetHistoryParams() { 
            //  
            //
            //});
            //MessageGetHistoryObject results = new MessageGetHistoryObject();
            //await outerTask.ContinueWith(task =>
            //{
            //    results = task.Result;
            //});
            MessageGetHistoryObject results = D.api.Messages.GetHistory(new MessagesGetHistoryParams() { PeerId = D.Context.ActiveChat.Conv.Peer.Id });
           
            //System.Collections.ICollection  collection = (System.Collections.ICollection)results.Messages;
            foreach ( var i in results.Messages)
            {
                var tmp = new Msg(i);
                MsgList.Add(tmp);
            }
            
           // MessagesListView.Clear();
            MessagesListView.AddObjects(MsgList);

        }
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
        }
        private void ButtonSendDialog_Click(object sender, EventArgs e)
        {
            var Params = new VkNet.Model.RequestParams.MessagesSendParams();
            Params.Message = RichTextBoxDialog.Text;
            Params.RandomId = new Random().Next();
            Params.PeerId = D.Context.ActiveChat.Conv.Peer.LocalId;
            var Msg = D.api.Messages.Send(Params);
            RichTextBoxDialog.Clear();
        }
        private void LoadDialogTab()
        {
           // timer1.Enabled = true;
            timer1.Interval = 1000;

            InitMessagesListView();

            MsgList = new List<Msg>();
           
            LoadMessages();
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
        private void timer1_Tick(object sender, EventArgs e)
        {

            LoadMessages();

        }
        private void label1_Click(object sender, EventArgs e)
        {
            LoadMessages();
        }
    }
}
