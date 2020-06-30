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
       
   
        public MainForm()
        {
            InitializeComponent();

            var services = new ServiceCollection();
            services.AddAudioBypass();
            VK.api = new VkApi(services);

            LoginForm login = new LoginForm();
            login.ShowDialog();           
        }

        private void LoadUserinfo()
        {
        
            User MyUser=  VK.api.Users.Get(new long[] { (long)VK.api.UserId }).FirstOrDefault();


            StatusLabel.Text = VK.api.Status.Get(MyUser.Id).Text;
            NameLabel.Text = MyUser.FirstName+" "+ MyUser.LastName;
            string url = MyUser.PhotoMaxOrig.AbsolutePath;
            MyAvatarPicture.Load(url);
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            if (!VK.api.IsAuthorized)
                Close();
            else
            {
             //  LoadUserinfo();

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
                    Page.SelectedTab = MyPage;
                    break;
                case 1:
                    Page.SelectedTab = Messages;
                    break;
                
                case 2:
                    Page.SelectedTab = Groups;
                    break;
                case 3:
                    Page.SelectedTab = Friends;
                    break;
                case 4:
                    Page.SelectedTab =Settings;
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

      
    }
}
