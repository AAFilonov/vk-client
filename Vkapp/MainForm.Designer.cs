namespace Vkapp
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ActionList = new System.Windows.Forms.ListBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.Page = new System.Windows.Forms.TabControl();
            this.TabUserInfo = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.UserCountryLabel = new System.Windows.Forms.Label();
            this.UserGroupButton = new System.Windows.Forms.Button();
            this.UserWallButton = new System.Windows.Forms.Button();
            this.UserAudioButton = new System.Windows.Forms.Button();
            this.UserPhotoButton = new System.Windows.Forms.Button();
            this.UserFollowersButton = new System.Windows.Forms.Button();
            this.UserFriendsButton = new System.Windows.Forms.Button();
            this.UserUpdateButton = new System.Windows.Forms.Button();
            this.NameLabel = new System.Windows.Forms.Label();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.OnlineStatusLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.MyAvatarPicture = new System.Windows.Forms.PictureBox();
            this.TabConversations = new System.Windows.Forms.TabPage();
            this.ObjDialogList = new BrightIdeasSoftware.ObjectListView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.AddConversationButton = new System.Windows.Forms.Button();
            this.UpdateConversationButton = new System.Windows.Forms.Button();
            this.TabDialog = new System.Windows.Forms.TabPage();
            this.TabGroups = new System.Windows.Forms.TabPage();
            this.TabFriends = new System.Windows.Forms.TabPage();
            this.TabSettings = new System.Windows.Forms.TabPage();
            this.TabWall = new System.Windows.Forms.TabPage();
            this.DialogPictureList = new System.Windows.Forms.ImageList(this.components);
            this.Page.SuspendLayout();
            this.TabUserInfo.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MyAvatarPicture)).BeginInit();
            this.TabConversations.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ObjDialogList)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // ActionList
            // 
            this.ActionList.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ActionList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ActionList.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ActionList.ForeColor = System.Drawing.Color.SteelBlue;
            this.ActionList.FormattingEnabled = true;
            this.ActionList.ItemHeight = 19;
            this.ActionList.Items.AddRange(new object[] {
            "Моя страница",
            "Сообщения",
            "Группы",
            "Друзья",
            "Настройки",
            "Выход"});
            this.ActionList.Location = new System.Drawing.Point(14, 13);
            this.ActionList.Name = "ActionList";
            this.ActionList.Size = new System.Drawing.Size(140, 247);
            this.ActionList.TabIndex = 0;
            this.ActionList.SelectedIndexChanged += new System.EventHandler(this.ActionList_SelectedIndexChanged);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 473);
            this.splitter1.TabIndex = 1;
            this.splitter1.TabStop = false;
            // 
            // Page
            // 
            this.Page.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.Page.Controls.Add(this.TabUserInfo);
            this.Page.Controls.Add(this.TabConversations);
            this.Page.Controls.Add(this.TabDialog);
            this.Page.Controls.Add(this.TabGroups);
            this.Page.Controls.Add(this.TabFriends);
            this.Page.Controls.Add(this.TabSettings);
            this.Page.Controls.Add(this.TabWall);
            this.Page.ItemSize = new System.Drawing.Size(50, 20);
            this.Page.Location = new System.Drawing.Point(162, 13);
            this.Page.Name = "Page";
            this.Page.SelectedIndex = 0;
            this.Page.Size = new System.Drawing.Size(641, 448);
            this.Page.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.Page.TabIndex = 2;
            this.Page.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.Page_Selecting);
            // 
            // TabUserInfo
            // 
            this.TabUserInfo.Controls.Add(this.panel2);
            this.TabUserInfo.Controls.Add(this.panel1);
            this.TabUserInfo.Location = new System.Drawing.Point(4, 24);
            this.TabUserInfo.Name = "TabUserInfo";
            this.TabUserInfo.Padding = new System.Windows.Forms.Padding(3);
            this.TabUserInfo.Size = new System.Drawing.Size(633, 420);
            this.TabUserInfo.TabIndex = 0;
            this.TabUserInfo.Text = "UserInfo";
            this.TabUserInfo.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Window;
            this.panel2.Controls.Add(this.UserCountryLabel);
            this.panel2.Controls.Add(this.UserGroupButton);
            this.panel2.Controls.Add(this.UserWallButton);
            this.panel2.Controls.Add(this.UserAudioButton);
            this.panel2.Controls.Add(this.UserPhotoButton);
            this.panel2.Controls.Add(this.UserFollowersButton);
            this.panel2.Controls.Add(this.UserFriendsButton);
            this.panel2.Controls.Add(this.UserUpdateButton);
            this.panel2.Controls.Add(this.NameLabel);
            this.panel2.Controls.Add(this.StatusLabel);
            this.panel2.Controls.Add(this.OnlineStatusLabel);
            this.panel2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel2.Location = new System.Drawing.Point(259, 19);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(359, 375);
            this.panel2.TabIndex = 5;
            // 
            // UserCountryLabel
            // 
            this.UserCountryLabel.AutoSize = true;
            this.UserCountryLabel.Location = new System.Drawing.Point(20, 60);
            this.UserCountryLabel.Name = "UserCountryLabel";
            this.UserCountryLabel.Size = new System.Drawing.Size(0, 14);
            this.UserCountryLabel.TabIndex = 11;
            // 
            // UserGroupButton
            // 
            this.UserGroupButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UserGroupButton.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UserGroupButton.ForeColor = System.Drawing.Color.SteelBlue;
            this.UserGroupButton.Location = new System.Drawing.Point(29, 200);
            this.UserGroupButton.Name = "UserGroupButton";
            this.UserGroupButton.Size = new System.Drawing.Size(152, 52);
            this.UserGroupButton.TabIndex = 10;
            this.UserGroupButton.Text = "подписок";
            this.UserGroupButton.UseVisualStyleBackColor = true;
            // 
            // UserWallButton
            // 
            this.UserWallButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UserWallButton.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UserWallButton.ForeColor = System.Drawing.Color.SteelBlue;
            this.UserWallButton.Location = new System.Drawing.Point(29, 258);
            this.UserWallButton.Name = "UserWallButton";
            this.UserWallButton.Size = new System.Drawing.Size(318, 52);
            this.UserWallButton.TabIndex = 9;
            this.UserWallButton.Text = "Записи на стене";
            this.UserWallButton.UseVisualStyleBackColor = true;
            // 
            // UserAudioButton
            // 
            this.UserAudioButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UserAudioButton.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UserAudioButton.ForeColor = System.Drawing.Color.SteelBlue;
            this.UserAudioButton.Location = new System.Drawing.Point(187, 200);
            this.UserAudioButton.Name = "UserAudioButton";
            this.UserAudioButton.Size = new System.Drawing.Size(160, 52);
            this.UserAudioButton.TabIndex = 8;
            this.UserAudioButton.Text = "аудиозаписей";
            this.UserAudioButton.UseVisualStyleBackColor = true;
            // 
            // UserPhotoButton
            // 
            this.UserPhotoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UserPhotoButton.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UserPhotoButton.ForeColor = System.Drawing.Color.SteelBlue;
            this.UserPhotoButton.Location = new System.Drawing.Point(241, 142);
            this.UserPhotoButton.Name = "UserPhotoButton";
            this.UserPhotoButton.Size = new System.Drawing.Size(106, 52);
            this.UserPhotoButton.TabIndex = 7;
            this.UserPhotoButton.Text = "фото";
            this.UserPhotoButton.UseVisualStyleBackColor = true;
            // 
            // UserFollowersButton
            // 
            this.UserFollowersButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UserFollowersButton.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UserFollowersButton.ForeColor = System.Drawing.Color.SteelBlue;
            this.UserFollowersButton.Location = new System.Drawing.Point(136, 142);
            this.UserFollowersButton.Name = "UserFollowersButton";
            this.UserFollowersButton.Size = new System.Drawing.Size(99, 52);
            this.UserFollowersButton.TabIndex = 6;
            this.UserFollowersButton.Text = "подпищиков";
            this.UserFollowersButton.UseVisualStyleBackColor = true;
            // 
            // UserFriendsButton
            // 
            this.UserFriendsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UserFriendsButton.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UserFriendsButton.ForeColor = System.Drawing.Color.SteelBlue;
            this.UserFriendsButton.Location = new System.Drawing.Point(29, 142);
            this.UserFriendsButton.Name = "UserFriendsButton";
            this.UserFriendsButton.Size = new System.Drawing.Size(101, 52);
            this.UserFriendsButton.TabIndex = 5;
            this.UserFriendsButton.Text = "друзей";
            this.UserFriendsButton.UseVisualStyleBackColor = true;
            // 
            // UserUpdateButton
            // 
            this.UserUpdateButton.FlatAppearance.BorderSize = 0;
            this.UserUpdateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UserUpdateButton.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UserUpdateButton.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.UserUpdateButton.Location = new System.Drawing.Point(281, 339);
            this.UserUpdateButton.Name = "UserUpdateButton";
            this.UserUpdateButton.Size = new System.Drawing.Size(75, 23);
            this.UserUpdateButton.TabIndex = 4;
            this.UserUpdateButton.Text = "Обновить";
            this.UserUpdateButton.UseVisualStyleBackColor = true;
            this.UserUpdateButton.Click += new System.EventHandler(this.UserUpdateButton_Click);
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Tahoma", 12F);
            this.NameLabel.Location = new System.Drawing.Point(17, 16);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(87, 19);
            this.NameLabel.TabIndex = 1;
            this.NameLabel.Text = "NameLabel";
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Location = new System.Drawing.Point(17, 42);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(42, 14);
            this.StatusLabel.TabIndex = 3;
            this.StatusLabel.Text = "Status";
            // 
            // OnlineStatusLabel
            // 
            this.OnlineStatusLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.OnlineStatusLabel.Location = new System.Drawing.Point(153, 16);
            this.OnlineStatusLabel.Name = "OnlineStatusLabel";
            this.OnlineStatusLabel.Size = new System.Drawing.Size(203, 40);
            this.OnlineStatusLabel.TabIndex = 2;
            this.OnlineStatusLabel.Text = "заходил 2 недели назад";
            this.OnlineStatusLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.Controls.Add(this.MyAvatarPicture);
            this.panel1.Location = new System.Drawing.Point(6, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(233, 250);
            this.panel1.TabIndex = 4;
            // 
            // MyAvatarPicture
            // 
            this.MyAvatarPicture.Location = new System.Drawing.Point(14, 16);
            this.MyAvatarPicture.Name = "MyAvatarPicture";
            this.MyAvatarPicture.Size = new System.Drawing.Size(200, 200);
            this.MyAvatarPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MyAvatarPicture.TabIndex = 0;
            this.MyAvatarPicture.TabStop = false;
            // 
            // TabConversations
            // 
            this.TabConversations.Controls.Add(this.ObjDialogList);
            this.TabConversations.Controls.Add(this.panel4);
            this.TabConversations.Location = new System.Drawing.Point(4, 24);
            this.TabConversations.Name = "TabConversations";
            this.TabConversations.Padding = new System.Windows.Forms.Padding(3);
            this.TabConversations.Size = new System.Drawing.Size(633, 420);
            this.TabConversations.TabIndex = 1;
            this.TabConversations.Text = "Conversations";
            this.TabConversations.UseVisualStyleBackColor = true;
            // 
            // ObjDialogList
            // 
            this.ObjDialogList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ObjDialogList.CellEditUseWholeCell = false;
            this.ObjDialogList.Cursor = System.Windows.Forms.Cursors.Default;
            this.ObjDialogList.FullRowSelect = true;
            this.ObjDialogList.HideSelection = false;
            this.ObjDialogList.Location = new System.Drawing.Point(6, 64);
            this.ObjDialogList.MultiSelect = false;
            this.ObjDialogList.Name = "ObjDialogList";
            this.ObjDialogList.RowHeight = 50;
            this.ObjDialogList.ShowGroups = false;
            this.ObjDialogList.Size = new System.Drawing.Size(621, 330);
            this.ObjDialogList.TabIndex = 3;
            this.ObjDialogList.UseCompatibleStateImageBehavior = false;
            this.ObjDialogList.View = System.Windows.Forms.View.Details;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.HighlightText;
            this.panel4.Controls.Add(this.AddConversationButton);
            this.panel4.Controls.Add(this.UpdateConversationButton);
            this.panel4.Location = new System.Drawing.Point(6, 7);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(621, 51);
            this.panel4.TabIndex = 3;
            // 
            // AddConversationButton
            // 
            this.AddConversationButton.BackColor = System.Drawing.Color.Transparent;
            this.AddConversationButton.FlatAppearance.BorderSize = 0;
            this.AddConversationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddConversationButton.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Underline);
            this.AddConversationButton.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.AddConversationButton.Location = new System.Drawing.Point(378, 7);
            this.AddConversationButton.Name = "AddConversationButton";
            this.AddConversationButton.Size = new System.Drawing.Size(111, 33);
            this.AddConversationButton.TabIndex = 1;
            this.AddConversationButton.Text = "Добавить 20";
            this.AddConversationButton.UseVisualStyleBackColor = false;
            this.AddConversationButton.Click += new System.EventHandler(this.AddConversationButton_Click);
            // 
            // UpdateConversationButton
            // 
            this.UpdateConversationButton.BackColor = System.Drawing.Color.Transparent;
            this.UpdateConversationButton.FlatAppearance.BorderSize = 0;
            this.UpdateConversationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateConversationButton.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Underline);
            this.UpdateConversationButton.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.UpdateConversationButton.Location = new System.Drawing.Point(495, 3);
            this.UpdateConversationButton.Name = "UpdateConversationButton";
            this.UpdateConversationButton.Size = new System.Drawing.Size(123, 37);
            this.UpdateConversationButton.TabIndex = 2;
            this.UpdateConversationButton.Text = "Обновить";
            this.UpdateConversationButton.UseVisualStyleBackColor = false;
            this.UpdateConversationButton.Click += new System.EventHandler(this.UpdateConversationButton_Click);
            // 
            // TabDialog
            // 
            this.TabDialog.Location = new System.Drawing.Point(4, 24);
            this.TabDialog.Name = "TabDialog";
            this.TabDialog.Size = new System.Drawing.Size(633, 420);
            this.TabDialog.TabIndex = 2;
            this.TabDialog.Text = "Dialog";
            this.TabDialog.UseVisualStyleBackColor = true;
            // 
            // TabGroups
            // 
            this.TabGroups.Location = new System.Drawing.Point(4, 24);
            this.TabGroups.Name = "TabGroups";
            this.TabGroups.Size = new System.Drawing.Size(633, 420);
            this.TabGroups.TabIndex = 4;
            this.TabGroups.Text = "Groups";
            this.TabGroups.UseVisualStyleBackColor = true;
            // 
            // TabFriends
            // 
            this.TabFriends.Location = new System.Drawing.Point(4, 24);
            this.TabFriends.Name = "TabFriends";
            this.TabFriends.Size = new System.Drawing.Size(633, 420);
            this.TabFriends.TabIndex = 3;
            this.TabFriends.Text = "Friends";
            this.TabFriends.UseVisualStyleBackColor = true;
            // 
            // TabSettings
            // 
            this.TabSettings.Location = new System.Drawing.Point(4, 24);
            this.TabSettings.Name = "TabSettings";
            this.TabSettings.Size = new System.Drawing.Size(633, 420);
            this.TabSettings.TabIndex = 5;
            this.TabSettings.Text = "Settings";
            this.TabSettings.UseVisualStyleBackColor = true;
            // 
            // TabWall
            // 
            this.TabWall.Location = new System.Drawing.Point(4, 24);
            this.TabWall.Name = "TabWall";
            this.TabWall.Size = new System.Drawing.Size(633, 420);
            this.TabWall.TabIndex = 6;
            this.TabWall.Text = "Wall";
            this.TabWall.UseVisualStyleBackColor = true;
            // 
            // DialogPictureList
            // 
            this.DialogPictureList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.DialogPictureList.ImageSize = new System.Drawing.Size(16, 16);
            this.DialogPictureList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 473);
            this.Controls.Add(this.Page);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.ActionList);
            this.Font = new System.Drawing.Font("Tahoma", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Page.ResumeLayout(false);
            this.TabUserInfo.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MyAvatarPicture)).EndInit();
            this.TabConversations.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ObjDialogList)).EndInit();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox ActionList;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.TabControl Page;
        private System.Windows.Forms.TabPage TabUserInfo;
        private System.Windows.Forms.Label OnlineStatusLabel;
        private System.Windows.Forms.PictureBox MyAvatarPicture;
        private System.Windows.Forms.TabPage TabConversations;
        private System.Windows.Forms.TabPage TabDialog;
        private System.Windows.Forms.TabPage TabGroups;
        private System.Windows.Forms.TabPage TabFriends;
        private System.Windows.Forms.TabPage TabSettings;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.Button UserUpdateButton;
        private System.Windows.Forms.Label UserCountryLabel;
        private System.Windows.Forms.Button UserGroupButton;
        private System.Windows.Forms.Button UserWallButton;
        private System.Windows.Forms.Button UserAudioButton;
        private System.Windows.Forms.Button UserPhotoButton;
        private System.Windows.Forms.Button UserFollowersButton;
        private System.Windows.Forms.Button UserFriendsButton;
        private System.Windows.Forms.TabPage TabWall;
        private System.Windows.Forms.ImageList DialogPictureList;
        private System.Windows.Forms.Button AddConversationButton;
        private System.Windows.Forms.Button UpdateConversationButton;
        private System.Windows.Forms.Panel panel4;
        private BrightIdeasSoftware.ObjectListView ObjDialogList;
    }
}