using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Extensions.DependencyInjection;
using VkNet;
using VkNet.Abstractions;
using VkNet.AudioBypassService.Extensions;
using VkNet.Model;
using VkNet.Model.RequestParams;
using Application = System.Windows.Forms.Application;

namespace Vkapp
{
    public  class PageContext
    {
        public TabPage Tab;
        public MyDialog ActiveChat;
        public long? SeenUser;
        public PageContext()
        {
            this.Tab = null;
            this.ActiveChat =null;
            this.SeenUser = null;
        }
        public PageContext(PageContext Cont)
        {
            this.Tab = Cont.Tab;
            this.ActiveChat = Cont.ActiveChat; 
            this.SeenUser = Cont.SeenUser;
        }
    }
static class D
    {
        public  static IVkApi api;
        
        public static PageContext Context;
        public static long MyUserID;
      


        public static ulong? TotalDialogsCount;
        public static List<MyDialog> DialogsList;

        public static Stack<PageContext> PreviosPagesContexts;
    }
    
    static class Program
    {    
    
        [STAThread]
       
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
           
         
        }
    }
}
