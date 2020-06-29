using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VkNet;
using VkNet.Model;
using VkNet.Enums.Filters;

namespace Vkapp
{
    public partial class MainForm : Form
    {
        VkApi api;
   
        public MainForm()
        {
            InitializeComponent();
        }
        private LoginForm L;
        public MainForm(VkApi Vkapi, LoginForm loginForm)
        {
            api = Vkapi;
            InitializeComponent();
            L = loginForm;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
       
        }
        private async void LogOutAsync()
        {
             await api.LogOutAsync();
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





                        LoginForm loginForm = new LoginForm(api);
                        loginForm.Show();
                        LogOutAsync();
                        Close();
                    }
                    break;

                    
            }
            ActionList.ClearSelected();
        }
    }
}
