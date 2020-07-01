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
    
    class MyDialog
    {
        public string Title { get; set; }
        public string Prev { get; set; }
        public string Name { get; set; }
        public System.Drawing.Image  image{ get; set; }
        public long? UnreadMsg { get; set; }
        public DateTime? Date { get; set; }
        public Conversation Conv { get; set; }
        public VkNet.Model.Message LastMessage { get; set; }

        private System.Drawing.Image LoadImageFromUrl(string url)
        {

            WebClient client = new WebClient();
            byte[] imageByte = client.DownloadData(url);
            MemoryStream stream = new MemoryStream(imageByte);
            System.Drawing.Image im = System.Drawing.Image.FromStream(stream);
            return im;
        }
        private void init()
        {
            this.Name = Conv.Peer.Id.ToString();
            this.Prev = "";
            var PicUrl = "https://vk.com/images/camera_50.png";
            if (Conv.Peer.Type.ToString() == "group")
            {
                var group = VK.api.Groups.GetById(null, Conv.Peer.LocalId.ToString(), null).FirstOrDefault();
                this.Title = group.Name;
                this.Prev = LastMessage.Text;
                this.Prev = (LastMessage.FromId.Value == VK.api.UserId ? "Вы" : this.Title) + ": " + this.Prev;
                PicUrl = group.Photo50.ToString();
            }

            else
            {
                var user = VK.api.Users.Get(new long[] { LastMessage.FromId.Value }, ProfileFields.FirstName | ProfileFields.LastName | ProfileFields.Photo50).SingleOrDefault();

                if (Conv.Peer.Type.ToString() == "user")
                {
                    var usr = VK.api.Users.Get(new long[] { Conv.Peer.Id }, ProfileFields.FirstName | ProfileFields.LastName | ProfileFields.Photo50).SingleOrDefault();
                    this.Title = usr.FirstName + " " + usr.LastName;
                    PicUrl = usr.Photo50.ToString();

                }
                else if (Conv.Peer.Type.ToString() == "chat")
                {
                    this.Title = Conv.ChatSettings.Title;
                    var tmpurl = Conv.ChatSettings.Photo;
                    if (tmpurl != null) PicUrl = tmpurl.Photo50.ToString();
                }


                this.Prev = LastMessage.Text;

                if (this.Prev == "")
                {
                    var attachm = LastMessage.Attachments.FirstOrDefault();
                    if (attachm == null)
                    {
                        this.Prev = "Пересланное сообщение";
                    }
                    else
                    {
                        this.Prev = attachm.Type.Name.ToString();
                    }

                }

                this.Prev = (user.Id == VK.api.UserId ? "Вы" : user.FirstName + " " + user.LastName) + ": " + this.Prev;
            }
            this.image = LoadImageFromUrl(PicUrl);
            this.UnreadMsg = Conv.UnreadCount;
            this.Date = LastMessage.Date;
        }

        public void UpdateInfo(VkNet.Model.Message LastMessage, Conversation C)
        {
            this.Conv = C;
            this.LastMessage = LastMessage;
            init();
        }
        public MyDialog(Conversation C, VkNet.Model.Message LastMessage)
        {
            UpdateInfo(LastMessage,C);
        } 
    }
}

 
   
 