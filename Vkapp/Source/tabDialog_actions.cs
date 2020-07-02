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
        static int State;
        VkNet.Model.User User;
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
            timer1.Enabled = true;
            timer1.Interval = 1000;
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



        }
    }
}
