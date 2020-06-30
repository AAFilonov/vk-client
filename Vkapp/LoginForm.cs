using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using VkNet;
using Microsoft.Extensions.DependencyInjection;
using VkNet.Abstractions;
using VkNet.Utils;
using VkNet.Model;
using VkNet.Enums.Filters;
using VkNet.AudioBypassService.Extensions;
namespace Vkapp
{
    public partial class LoginForm : Form
    {
       
      
        public LoginForm()
        {
            InitializeComponent();
        }
      


        private void Form1_Load(object sender, EventArgs e)
        {
          
           // EmailTextbox.Text = "+79003557072";
           // PasswordlTextbox.Text = "Aveemperor404";
            EmailTextbox.Text = "89208405463";
            PasswordlTextbox.Text = "Aveemperor1";
            //   LoginAsync();
        }


        private async void LoginAsync()
        {


            // await VK.api.AuthorizeAsync(new ApiAuthParams
            // {
            //    ApplicationId = 7526098,
            //     Login = EmailTextbox.Text,
            //     Password = PasswordlTextbox.Text,
            //    Settings = Settings.All
            // });

            try
            {
                // Авторизируемся для получения токена валидного для вызова методов Audio / Messages
                await VK.api.AuthorizeAsync(new ApiAuthParams
                {
                    Login = EmailTextbox.Text,
                    Password = PasswordlTextbox.Text
                  
                });
              
                
            }
            catch (VkNet.Exception.CaptchaNeededException cEx)
            {
                AuthErrorLabel.ForeColor = Color.Red;
                AuthErrorLabel.Text = "Ошибка превышено число попыток";
                await Task.Delay(3000);
                Close();

                // string captchaUrl = cEx.Img.ToString();

                // CapchaForm F = new CapchaForm(cEx);
            }
            catch(VkNet.Exception.VkAuthorizationException)
            {
                AuthErrorLabel.ForeColor = Color.Red;
                AuthErrorLabel.Text = "Неверный логин или пароль";
                return;
            }
            catch (VkNet.AudioBypassService.Exceptions.VkAuthException)
            {
                AuthErrorLabel.ForeColor = Color.Red;
                AuthErrorLabel.Text = "Неверный логин или пароль";
                return;
            }
            Close();
        }
        private void Auth_Click(object sender, EventArgs e)
        {

            LoginAsync();
            AuthErrorLabel.Visible = true;
            AuthErrorLabel.ForeColor = Color.Black;
            AuthErrorLabel.Text = "Проверка данных...";
          



        }

        private void PassViev_CheckedChanged(object sender, EventArgs e)
        {
            PasswordlTextbox.UseSystemPasswordChar = !PassViev.Checked;
        }

        
    }
}
