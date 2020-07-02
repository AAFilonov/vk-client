using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vkapp
{
    public partial class CapchaForm : Form
    {
        VkNet.Exception.CaptchaNeededException cEx;
        public CapchaForm()
        {
            InitializeComponent();
        }
        public CapchaForm(VkNet.Exception.CaptchaNeededException Ex)
        {

           


            cEx = Ex;
            pictureBox1.Load(cEx.Img.ToString());        
            InitializeComponent();
        }

        private void CapchaForm_Load(object sender, EventArgs e)
        {

        }

   

     

        private void button2_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == cEx.Data.Values.ToString())
            {
                return;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
