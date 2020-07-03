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

       
        public async void DialogsAddAsync()
        {
            const ulong AddCount = 20;
            Task<GetConversationsResult> outerTask = D.api.Messages.GetConversationsAsync(new GetConversationsParams
            {
                Count = AddCount,
                Offset = D.TotalDialogsCount,
                Fields = new List<string> { "All" }
            });
            GetConversationsResult results = new GetConversationsResult();
            List<MyDialog> TMP = new List<MyDialog>();
            await outerTask.ContinueWith(task =>
            {
                results = task.Result;
              
                foreach (var i in results.Items)
                {
                    TMP.Add(new MyDialog(i.Conversation, i.LastMessage));

                    D.TotalDialogsCount++;
                    //DialogPictureList.Images.Add(DialogsList.Last().Id, LoadImageFromUrl(DialogsList.Last().PicUrl));
                }
            });
            D.DialogsList.AddRange(TMP);
            ObjDialogList.AddObjects(TMP);
           

        }
        public async void DialogsUpdAsync()
        {

            Task<GetConversationsResult> outerTask = D.api.Messages.GetConversationsAsync(new GetConversationsParams
            {
                Count = D.TotalDialogsCount,
                Offset = 0,
                Fields = new List<string> { "All" }
            });
            GetConversationsResult results = new GetConversationsResult();
            await outerTask.ContinueWith(task =>
            {
                results = task.Result;

                for (var i = 0; i < D.DialogsList.Count; i++)
                {
                    D.DialogsList[i].UpdateInfo(results.Items[i].LastMessage, results.Items[i].Conversation);

                }
            });
            ObjDialogList.UpdateObjects(D.DialogsList);
        }

        private void AddConversationButton_Click(object sender, EventArgs e)
        {

            DialogsAddAsync();
        }

        private void UpdateConversationButton_Click(object sender, EventArgs e)
        {

            DialogsUpdAsync();
        }

        public void loadConversationTab()
        {
            if (D.DialogsList.Count >= 20)
                DialogsUpdAsync();
            else return;
        }


    }
}
