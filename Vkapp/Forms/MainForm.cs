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

    public partial class MainForm : Form
    {

      

        private void ObjListInit()
        {
            ObjDialogList.OwnerDraw = true;
            ObjDialogList.HeaderStyle = ColumnHeaderStyle.None; 
            ObjDialogList.RowHeight = 70;

            //Creating the columns
            BrightIdeasSoftware.OLVColumn PictureColumn = new BrightIdeasSoftware.OLVColumn();
            BrightIdeasSoftware.OLVColumn TitleColumn = new BrightIdeasSoftware.OLVColumn();
            BrightIdeasSoftware.OLVColumn PrevColumn = new BrightIdeasSoftware.OLVColumn();
            BrightIdeasSoftware.OLVColumn UnreadMsgColumn = new BrightIdeasSoftware.OLVColumn();
            BrightIdeasSoftware.OLVColumn DateColumn = new BrightIdeasSoftware.OLVColumn();

            //Adding the columns to the Objectlistview
            ObjDialogList.AllColumns.Add(PictureColumn);
            ObjDialogList.AllColumns.Add(TitleColumn);
            ObjDialogList.AllColumns.Add(PrevColumn);
            ObjDialogList.AllColumns.Add(UnreadMsgColumn);
            ObjDialogList.AllColumns.Add(DateColumn);

            //Directing the columns to the correct variable names. 

            PictureColumn.ImageAspectName = "image";
            TitleColumn.AspectName = "Title";
            PrevColumn.AspectName = "Prev";
            UnreadMsgColumn.AspectName = "UnreadMsg";
            DateColumn.AspectName = "Date";

     
            //Setting the header name on each column
             PictureColumn.Text = "Image";
            TitleColumn.Text = "Title";
            PrevColumn.Text = "Prev";
            UnreadMsgColumn.Text = "UnreadMsg";
            DateColumn.Text = "Date";
            //Set the columns to fill the width of the objectlistview

            // PictureColumn.FillsFreeSpace = true;
            //TitleColumn.FillsFreeSpace = true;
            TitleColumn.Width = 120;
            TitleColumn.WordWrap = true;
            PrevColumn.FillsFreeSpace = true;
            PrevColumn.WordWrap = true;
            // UnreadMsgColumn.FillsFreeSpace = true;
            //DateColumn.FillsFreeSpace = true;
            TitleColumn.TextAlign = HorizontalAlignment.Left;
            //TitleColumn.CellVerticalAlignment = StringAlignment.Near;
             PictureColumn.AspectToStringConverter = delegate (object x) {
                return String.Empty;
            };


            DateColumn.AspectToStringConverter = delegate (object x) {
                DateTime t = (DateTime)x;
                t= t.AddHours(3);
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



            ObjDialogList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
                    PictureColumn,
                    TitleColumn,
                    PrevColumn,
                    UnreadMsgColumn,
                    DateColumn
                });
            ObjDialogList.PrimarySortColumn = DateColumn;
            ObjDialogList.Sorting = SortOrder.Descending;
        }
      
        public MainForm()
        {
            InitializeComponent();
           
            var services = new ServiceCollection();
            services.AddAudioBypass();
            D.api = new VkApi(services);

            LoginForm login = new LoginForm();
            login.ShowDialog();
           
            D.DialogsList = new List<MyDialog>();
            DialogPictureList = new ImageList();
            DialogPictureList.ImageSize = new Size(50, 50);
            DialogPictureList.ColorDepth = ColorDepth.Depth32Bit;
            D.TotalDialogsCount = 0;

            FriendsPictureList.ImageSize = new Size(50, 50);
            FriendsPictureList.ColorDepth = ColorDepth.Depth32Bit;

            Page.Appearance = TabAppearance.FlatButtons;
            Page.ItemSize = new Size(0,1);
            Page.SizeMode = TabSizeMode.Fixed;
            Page.TabStop = false;

            FriendListOffset = new int();
            FriendsCount = new int();


        }
        private void MainForm_Load(object sender, EventArgs e)
        {

            if (!D.api.IsAuthorized)
                Close();
            else
            {
                D.MyUserID = (long)D.api.UserId;

               // timer1.Enabled = true;
                D.PreviosPagesContexts = new Stack<PageContext>();
                D.Context = new PageContext();

                D.Context.Tab = TabUserInfo;
                D.Context.SeenUser = D.MyUserID;
                D.Context.ActiveChat = null;
               
                Page.SelectedTab = TabUserInfo;
                LoadUserinfo();
                ObjListInit();
                InitFriendsListView();
                DialogsAddAsync();
            }

        }
      
        private void Page_Selecting(object sender, TabControlCancelEventArgs e)
        {
            
           
            switch (e.TabPage.Name)
            {
                case "TabUserInfo":
                    D.Context.Tab = TabUserInfo;

                 
                    TabUserInfoFriendButton.Visible = true;
                 
                    LoadUserinfo();
                    break;
                case "TabConversations":
                    D.Context.Tab = TabConversations;
                    loadConversationTab();
                    break;

                case "TabDialog":
                    D.Context.Tab = TabDialog;
                    LoadDialogTab();

                    break;
                case "TabFriends":
                    D.Context.Tab = TabFriends;
                    FriendListOffset = 0;
                    var u = D.api.Users.Get(new long[] { (long)D.Context.SeenUser }, ProfileFields.Counters).FirstOrDefault();
                    FriendsCount =  (int)u.Counters.Friends;
                    FriendsListView1.ClearObjects();
                    LoadFriendsTab();
                    break;

                default:
                    break;
            }
            if (D.Context.Tab != TabDialog)
            {
                timer1.Enabled = false;
                checkBox1.Checked = false;
            }

        }
        private void ActionList_SelectedIndexChanged(object sender, EventArgs e)
        {
            D.PreviosPagesContexts.Push(new PageContext(D.Context));
            int active = ActionList.SelectedIndex;
           
            switch (active)
            {
                case 0:
                   

                    Page.SelectedTab = TabUserInfo;
                   
                    D.Context.SeenUser = D.MyUserID;
                    D.Context.ActiveChat = null;
                   
                    break;
                case 1:

                    Page.SelectedTab = TabConversations;
                  
                    break;
                case 2:
                    Page.SelectedTab = TabFriends;
                    break;
                case 3:        
                    DialogResult result = MessageBox.Show(
                        "Вы действиетльно желаете выйти?",
                        "Внимание",
                        MessageBoxButtons.OKCancel,
                        MessageBoxIcon.Exclamation,
                        MessageBoxDefaultButton.Button1,
                        MessageBoxOptions.DefaultDesktopOnly);

                    if (result == DialogResult.OK)
                    {

                        Close();
                    }
                    break;


            }   
        }
       

        //Загрузка и обновление диалогов
       

       
      
    

        private void ObjDialogList_ItemActivate(object sender, EventArgs e)
        {
            D.PreviosPagesContexts.Push(new PageContext(D.Context));
            D.Context.ActiveChat = D.DialogsList[ObjDialogList.SelectedIndex];
            Page.SelectedTab = TabDialog;
            D.Context.SeenUser = null;
        }

        

        private void BackArrow_Click(object sender, EventArgs e)
        {

            if (D.PreviosPagesContexts.Count >0)
            {
                D.Context = D.PreviosPagesContexts.Pop();
                Page.SelectedTab = D.Context.Tab;
            }
        }
        public string OnlineStatus(VkNet.Model.User User)
        {
            if ((bool)User.Online)
            {
                return "Online";
            }
            else
            {
                return "Был в сети \n" + User.LastSeen.Time.ToString();
            }
        }

        public static System.Drawing.Image LoadImageFromUrl(string url)
        {

            WebClient client = new WebClient();
            byte[] imageByte = client.DownloadData(url);
            MemoryStream stream = new MemoryStream(imageByte);
            System.Drawing.Image im = System.Drawing.Image.FromStream(stream);
            return im;
        }
        public string DateSince(DateTime t)
        {
           
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
        }

        private void TabUserInfoGoToMessageButton_Click(object sender, EventArgs e)
        {
           //D.PreviosPagesContexts.Push(D.Context);
           //var C = D.api.Messages.get
           //D.Context.ActiveChat = new MyDialog();
           //
           //
           //D.Context.Tab = TabDialog;
           ////  D.Context.ActiveChat=  D.api.Messages.get;
        }

        private void TabUserInfoFriendButton_Click(object sender, EventArgs e)
        {
            switch ((int)D.api.Friends.AreFriends(new long[] { (long)D.Context.SeenUser }).FirstOrDefault().FriendStatus)
            {
                case 0:
                    D.api.Friends.Add((long)D.Context.SeenUser, "", null);
                    TabUserInfoFriendButton.Text = "Заявка отправлена";
                    break;
                case 1:
                    D.api.Friends.Delete((long)D.Context.SeenUser);
                    TabUserInfoFriendButton.Text = "Добавить в друзья";
                    break;
                case 2:
                    D.api.Friends.Add((long)D.Context.SeenUser, "", null);
                    TabUserInfoFollowYouLabel.Visible = false;
                    TabUserInfoFriendButton.Text = "У Вас в друзьях";
                    break;
                case 3:
                    D.api.Friends.Delete((long)D.Context.SeenUser);
                    TabUserInfoFriendButton.Text = "Принять заявку";
                    TabUserInfoFollowYouLabel.Visible = true;
                    break;

            }
        }

    
    }
}
