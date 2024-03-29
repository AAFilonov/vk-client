﻿
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
            this.panel6 = new System.Windows.Forms.Panel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.TabDialogOnlineLabel = new System.Windows.Forms.Label();
            this.TabDialogNameLabel = new System.Windows.Forms.Label();
            this.TabdialogPictureBox = new System.Windows.Forms.PictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.ListViewMsg = new System.Windows.Forms.ListView();
            this.NameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TextColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DateColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel3 = new System.Windows.Forms.Panel();
            this.LoadMoreButton = new System.Windows.Forms.Button();
            this.ReloadButton = new System.Windows.Forms.Button();
            this.RichTextBoxDialog = new System.Windows.Forms.RichTextBox();
            this.ButtonSendDialog = new System.Windows.Forms.Button();
            this.TabFriends = new System.Windows.Forms.TabPage();
            this.FriendsListView1 = new BrightIdeasSoftware.ObjectListView();
            this.ImageColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.FirstNameColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.LastNameColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.TabSettings = new System.Windows.Forms.TabPage();
            this.DialogPictureList = new System.Windows.Forms.ImageList(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.FriendsPictureList = new System.Windows.Forms.ImageList(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.TabUserInfoFollowYouLabel = new System.Windows.Forms.Label();
            this.TabUserInfoFriendButton = new System.Windows.Forms.Button();
            this.Page.SuspendLayout();
            this.TabUserInfo.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MyAvatarPicture)).BeginInit();
            this.TabConversations.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ObjDialogList)).BeginInit();
            this.panel4.SuspendLayout();
            this.TabDialog.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TabdialogPictureBox)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.TabFriends.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FriendsListView1)).BeginInit();
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
            "Мои сообщения",
            "Мои друзья",
            "Выход"});
            this.ActionList.Location = new System.Drawing.Point(9, 13);
            this.ActionList.Name = "ActionList";
            this.ActionList.Size = new System.Drawing.Size(132, 95);
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
            this.Page.Controls.Add(this.TabFriends);
            this.Page.Controls.Add(this.TabSettings);
            this.Page.ItemSize = new System.Drawing.Size(50, 20);
            this.Page.Location = new System.Drawing.Point(127, 0);
            this.Page.Name = "Page";
            this.Page.SelectedIndex = 0;
            this.Page.Size = new System.Drawing.Size(684, 473);
            this.Page.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.Page.TabIndex = 2;
            this.Page.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.Page_Selecting);
            // 
            // TabUserInfo
            // 
            this.TabUserInfo.Controls.Add(this.TabUserInfoFollowYouLabel);
            this.TabUserInfo.Controls.Add(this.TabUserInfoFriendButton);
            this.TabUserInfo.Controls.Add(this.panel2);
            this.TabUserInfo.Controls.Add(this.panel1);
            this.TabUserInfo.Location = new System.Drawing.Point(4, 24);
            this.TabUserInfo.Name = "TabUserInfo";
            this.TabUserInfo.Padding = new System.Windows.Forms.Padding(3);
            this.TabUserInfo.Size = new System.Drawing.Size(676, 445);
            this.TabUserInfo.TabIndex = 0;
            this.TabUserInfo.Text = "TabUserInfo";
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
            this.panel2.Size = new System.Drawing.Size(410, 375);
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
            this.UserGroupButton.Location = new System.Drawing.Point(49, 198);
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
            this.UserWallButton.Location = new System.Drawing.Point(49, 256);
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
            this.UserAudioButton.Location = new System.Drawing.Point(207, 198);
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
            this.UserPhotoButton.Location = new System.Drawing.Point(261, 140);
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
            this.UserFollowersButton.Location = new System.Drawing.Point(156, 140);
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
            this.UserFriendsButton.Location = new System.Drawing.Point(49, 140);
            this.UserFriendsButton.Name = "UserFriendsButton";
            this.UserFriendsButton.Size = new System.Drawing.Size(101, 52);
            this.UserFriendsButton.TabIndex = 5;
            this.UserFriendsButton.Text = "друзей";
            this.UserFriendsButton.UseVisualStyleBackColor = true;
            this.UserFriendsButton.Click += new System.EventHandler(this.UserFriendsButton_Click);
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
            this.OnlineStatusLabel.Location = new System.Drawing.Point(204, 16);
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
            this.TabConversations.Size = new System.Drawing.Size(676, 445);
            this.TabConversations.TabIndex = 1;
            this.TabConversations.Text = "Conversations";
            this.TabConversations.UseVisualStyleBackColor = true;
            // 
            // ObjDialogList
            // 
            this.ObjDialogList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ObjDialogList.CellEditUseWholeCell = false;
            this.ObjDialogList.Cursor = System.Windows.Forms.Cursors.Default;
            this.ObjDialogList.FullRowSelect = true;
            this.ObjDialogList.HideSelection = false;
            this.ObjDialogList.Location = new System.Drawing.Point(6, 17);
            this.ObjDialogList.MultiSelect = false;
            this.ObjDialogList.Name = "ObjDialogList";
            this.ObjDialogList.RowHeight = 50;
            this.ObjDialogList.ShowGroups = false;
            this.ObjDialogList.Size = new System.Drawing.Size(663, 378);
            this.ObjDialogList.TabIndex = 3;
            this.ObjDialogList.UseCompatibleStateImageBehavior = false;
            this.ObjDialogList.View = System.Windows.Forms.View.Details;
            this.ObjDialogList.ItemActivate += new System.EventHandler(this.ObjDialogList_ItemActivate);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.HighlightText;
            this.panel4.Controls.Add(this.AddConversationButton);
            this.panel4.Controls.Add(this.UpdateConversationButton);
            this.panel4.Location = new System.Drawing.Point(6, 401);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(663, 38);
            this.panel4.TabIndex = 3;
            // 
            // AddConversationButton
            // 
            this.AddConversationButton.BackColor = System.Drawing.Color.Transparent;
            this.AddConversationButton.FlatAppearance.BorderSize = 0;
            this.AddConversationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddConversationButton.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Underline);
            this.AddConversationButton.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.AddConversationButton.Location = new System.Drawing.Point(286, 2);
            this.AddConversationButton.Name = "AddConversationButton";
            this.AddConversationButton.Size = new System.Drawing.Size(111, 33);
            this.AddConversationButton.TabIndex = 1;
            this.AddConversationButton.Text = "Добавить еще";
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
            this.UpdateConversationButton.Location = new System.Drawing.Point(537, 2);
            this.UpdateConversationButton.Name = "UpdateConversationButton";
            this.UpdateConversationButton.Size = new System.Drawing.Size(109, 33);
            this.UpdateConversationButton.TabIndex = 2;
            this.UpdateConversationButton.Text = "Обновить";
            this.UpdateConversationButton.UseVisualStyleBackColor = false;
            this.UpdateConversationButton.Click += new System.EventHandler(this.UpdateConversationButton_Click);
            // 
            // TabDialog
            // 
            this.TabDialog.Controls.Add(this.panel6);
            this.TabDialog.Controls.Add(this.panel5);
            this.TabDialog.Controls.Add(this.panel3);
            this.TabDialog.Location = new System.Drawing.Point(4, 24);
            this.TabDialog.Name = "TabDialog";
            this.TabDialog.Size = new System.Drawing.Size(676, 445);
            this.TabDialog.TabIndex = 2;
            this.TabDialog.Text = "TabDialog";
            this.TabDialog.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.Window;
            this.panel6.Controls.Add(this.checkBox1);
            this.panel6.Controls.Add(this.TabDialogOnlineLabel);
            this.panel6.Controls.Add(this.TabDialogNameLabel);
            this.panel6.Controls.Add(this.TabdialogPictureBox);
            this.panel6.Location = new System.Drawing.Point(13, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(658, 60);
            this.panel6.TabIndex = 5;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(6, 35);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(122, 18);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "Автообновление";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // TabDialogOnlineLabel
            // 
            this.TabDialogOnlineLabel.AutoSize = true;
            this.TabDialogOnlineLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.TabDialogOnlineLabel.Location = new System.Drawing.Point(301, 26);
            this.TabDialogOnlineLabel.Name = "TabDialogOnlineLabel";
            this.TabDialogOnlineLabel.Size = new System.Drawing.Size(38, 14);
            this.TabDialogOnlineLabel.TabIndex = 4;
            this.TabDialogOnlineLabel.Text = "label1";
            this.TabDialogOnlineLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TabDialogNameLabel
            // 
            this.TabDialogNameLabel.AutoSize = true;
            this.TabDialogNameLabel.Font = new System.Drawing.Font("Tahoma", 12F);
            this.TabDialogNameLabel.Location = new System.Drawing.Point(267, 3);
            this.TabDialogNameLabel.Name = "TabDialogNameLabel";
            this.TabDialogNameLabel.Size = new System.Drawing.Size(108, 19);
            this.TabDialogNameLabel.TabIndex = 3;
            this.TabDialogNameLabel.Text = "Имя Фамилия";
            this.TabDialogNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TabDialogNameLabel.Click += new System.EventHandler(this.TabDialogNameLabel_Click);
            // 
            // TabdialogPictureBox
            // 
            this.TabdialogPictureBox.Location = new System.Drawing.Point(580, 3);
            this.TabdialogPictureBox.Name = "TabdialogPictureBox";
            this.TabdialogPictureBox.Size = new System.Drawing.Size(50, 50);
            this.TabdialogPictureBox.TabIndex = 1;
            this.TabdialogPictureBox.TabStop = false;
            this.TabdialogPictureBox.Click += new System.EventHandler(this.TabDialogNameLabel_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.Window;
            this.panel5.Controls.Add(this.ListViewMsg);
            this.panel5.Location = new System.Drawing.Point(13, 69);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(658, 273);
            this.panel5.TabIndex = 4;
            // 
            // ListViewMsg
            // 
            this.ListViewMsg.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NameColumn,
            this.TextColumn,
            this.DateColumn});
            this.ListViewMsg.FullRowSelect = true;
            this.ListViewMsg.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.ListViewMsg.HideSelection = false;
            this.ListViewMsg.Location = new System.Drawing.Point(3, 4);
            this.ListViewMsg.Name = "ListViewMsg";
            this.ListViewMsg.Size = new System.Drawing.Size(652, 255);
            this.ListViewMsg.TabIndex = 0;
            this.ListViewMsg.UseCompatibleStateImageBehavior = false;
            this.ListViewMsg.View = System.Windows.Forms.View.Details;
            // 
            // NameColumn
            // 
            this.NameColumn.Text = "Name";
            this.NameColumn.Width = 97;
            // 
            // TextColumn
            // 
            this.TextColumn.Width = 445;
            // 
            // DateColumn
            // 
            this.DateColumn.Width = 76;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Window;
            this.panel3.Controls.Add(this.LoadMoreButton);
            this.panel3.Controls.Add(this.ReloadButton);
            this.panel3.Controls.Add(this.RichTextBoxDialog);
            this.panel3.Controls.Add(this.ButtonSendDialog);
            this.panel3.Location = new System.Drawing.Point(13, 348);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(658, 94);
            this.panel3.TabIndex = 3;
            // 
            // LoadMoreButton
            // 
            this.LoadMoreButton.Location = new System.Drawing.Point(3, 43);
            this.LoadMoreButton.Name = "LoadMoreButton";
            this.LoadMoreButton.Size = new System.Drawing.Size(88, 42);
            this.LoadMoreButton.TabIndex = 5;
            this.LoadMoreButton.Text = "Прогрузить еще";
            this.LoadMoreButton.UseVisualStyleBackColor = true;
            this.LoadMoreButton.Click += new System.EventHandler(this.LoadMoreButton_Click);
            // 
            // ReloadButton
            // 
            this.ReloadButton.Location = new System.Drawing.Point(3, 14);
            this.ReloadButton.Name = "ReloadButton";
            this.ReloadButton.Size = new System.Drawing.Size(88, 23);
            this.ReloadButton.TabIndex = 6;
            this.ReloadButton.Text = "Обновить";
            this.ReloadButton.UseVisualStyleBackColor = true;
            this.ReloadButton.Click += new System.EventHandler(this.ReloadButton_Click);
            // 
            // RichTextBoxDialog
            // 
            this.RichTextBoxDialog.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RichTextBoxDialog.Location = new System.Drawing.Point(97, 13);
            this.RichTextBoxDialog.Name = "RichTextBoxDialog";
            this.RichTextBoxDialog.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.RichTextBoxDialog.Size = new System.Drawing.Size(477, 72);
            this.RichTextBoxDialog.TabIndex = 0;
            this.RichTextBoxDialog.Text = "";
            // 
            // ButtonSendDialog
            // 
            this.ButtonSendDialog.BackColor = System.Drawing.Color.SteelBlue;
            this.ButtonSendDialog.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonSendDialog.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ButtonSendDialog.Location = new System.Drawing.Point(580, 14);
            this.ButtonSendDialog.Name = "ButtonSendDialog";
            this.ButtonSendDialog.Size = new System.Drawing.Size(75, 23);
            this.ButtonSendDialog.TabIndex = 1;
            this.ButtonSendDialog.Text = "Отправить";
            this.ButtonSendDialog.UseVisualStyleBackColor = false;
            this.ButtonSendDialog.Click += new System.EventHandler(this.ButtonSendDialog_Click);
            // 
            // TabFriends
            // 
            this.TabFriends.Controls.Add(this.FriendsListView1);
            this.TabFriends.Location = new System.Drawing.Point(4, 24);
            this.TabFriends.Name = "TabFriends";
            this.TabFriends.Size = new System.Drawing.Size(676, 445);
            this.TabFriends.TabIndex = 3;
            this.TabFriends.Text = "TabFriends";
            this.TabFriends.UseVisualStyleBackColor = true;
            // 
            // FriendsListView1
            // 
            this.FriendsListView1.AllColumns.Add(this.ImageColumn);
            this.FriendsListView1.AllColumns.Add(this.FirstNameColumn);
            this.FriendsListView1.AllColumns.Add(this.LastNameColumn);
            this.FriendsListView1.CellEditUseWholeCell = false;
            this.FriendsListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ImageColumn,
            this.FirstNameColumn,
            this.LastNameColumn});
            this.FriendsListView1.Cursor = System.Windows.Forms.Cursors.Default;
            this.FriendsListView1.FullRowSelect = true;
            this.FriendsListView1.HideSelection = false;
            this.FriendsListView1.Location = new System.Drawing.Point(7, 6);
            this.FriendsListView1.MultiSelect = false;
            this.FriendsListView1.Name = "FriendsListView1";
            this.FriendsListView1.RowHeight = 60;
            this.FriendsListView1.Size = new System.Drawing.Size(664, 431);
            this.FriendsListView1.TabIndex = 2;
            this.FriendsListView1.UseCompatibleStateImageBehavior = false;
            this.FriendsListView1.View = System.Windows.Forms.View.Details;
            this.FriendsListView1.Scroll += new System.EventHandler<System.Windows.Forms.ScrollEventArgs>(this.FriendsListView1_Scroll);
            this.FriendsListView1.ItemActivate += new System.EventHandler(this.FriendsListView1_ItemActivate);
            // 
            // ImageColumn
            // 
            this.ImageColumn.AspectName = "Image";
            this.ImageColumn.Text = "";
            this.ImageColumn.Width = 71;
            // 
            // FirstNameColumn
            // 
            this.FirstNameColumn.AspectName = "FirstName";
            this.FirstNameColumn.Text = "Имя";
            this.FirstNameColumn.Width = 249;
            this.FirstNameColumn.WordWrap = true;
            // 
            // LastNameColumn
            // 
            this.LastNameColumn.AspectName = "LastName";
            this.LastNameColumn.Text = "Фамилия";
            this.LastNameColumn.Width = 183;
            // 
            // TabSettings
            // 
            this.TabSettings.Location = new System.Drawing.Point(4, 24);
            this.TabSettings.Name = "TabSettings";
            this.TabSettings.Size = new System.Drawing.Size(676, 445);
            this.TabSettings.TabIndex = 5;
            this.TabSettings.Text = "TabSettings";
            this.TabSettings.UseVisualStyleBackColor = true;
            // 
            // DialogPictureList
            // 
            this.DialogPictureList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.DialogPictureList.ImageSize = new System.Drawing.Size(16, 16);
            this.DialogPictureList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // timer1
            // 
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FriendsPictureList
            // 
            this.FriendsPictureList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.FriendsPictureList.ImageSize = new System.Drawing.Size(16, 16);
            this.FriendsPictureList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Window;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Tahoma", 12F);
            this.button1.ForeColor = System.Drawing.Color.SteelBlue;
            this.button1.Location = new System.Drawing.Point(21, 133);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 34);
            this.button1.TabIndex = 12;
            this.button1.Text = "<-----";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.BackArrow_Click);
            // 
            // TabUserInfoFollowYouLabel
            // 
            this.TabUserInfoFollowYouLabel.AccessibleDescription = "";
            this.TabUserInfoFollowYouLabel.AutoSize = true;
            this.TabUserInfoFollowYouLabel.Font = new System.Drawing.Font("Tahoma", 12F);
            this.TabUserInfoFollowYouLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.TabUserInfoFollowYouLabel.Location = new System.Drawing.Point(61, 332);
            this.TabUserInfoFollowYouLabel.Name = "TabUserInfoFollowYouLabel";
            this.TabUserInfoFollowYouLabel.Size = new System.Drawing.Size(130, 19);
            this.TabUserInfoFollowYouLabel.TabIndex = 16;
            this.TabUserInfoFollowYouLabel.Text = "Подписан на вас";
            this.TabUserInfoFollowYouLabel.Visible = false;
            // 
            // TabUserInfoFriendButton
            // 
            this.TabUserInfoFriendButton.BackColor = System.Drawing.Color.SteelBlue;
            this.TabUserInfoFriendButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TabUserInfoFriendButton.Font = new System.Drawing.Font("Tahoma", 12F);
            this.TabUserInfoFriendButton.ForeColor = System.Drawing.SystemColors.Window;
            this.TabUserInfoFriendButton.Location = new System.Drawing.Point(6, 279);
            this.TabUserInfoFriendButton.Name = "TabUserInfoFriendButton";
            this.TabUserInfoFriendButton.Size = new System.Drawing.Size(233, 40);
            this.TabUserInfoFriendButton.TabIndex = 13;
            this.TabUserInfoFriendButton.Text = "Добавить в друзья";
            this.TabUserInfoFriendButton.UseVisualStyleBackColor = false;
            this.TabUserInfoFriendButton.Click += new System.EventHandler(this.TabUserInfoFriendButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 473);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Page);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.ActionList);
            this.Font = new System.Drawing.Font("Tahoma", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Page.ResumeLayout(false);
            this.TabUserInfo.ResumeLayout(false);
            this.TabUserInfo.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MyAvatarPicture)).EndInit();
            this.TabConversations.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ObjDialogList)).EndInit();
            this.panel4.ResumeLayout(false);
            this.TabDialog.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TabdialogPictureBox)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.TabFriends.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.FriendsListView1)).EndInit();
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
        private System.Windows.Forms.ImageList DialogPictureList;
        private System.Windows.Forms.Button AddConversationButton;
        private System.Windows.Forms.Button UpdateConversationButton;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RichTextBox RichTextBoxDialog;
        private System.Windows.Forms.Button ButtonSendDialog;
        private System.Windows.Forms.Label TabDialogOnlineLabel;
        private System.Windows.Forms.Label TabDialogNameLabel;
        private System.Windows.Forms.PictureBox TabdialogPictureBox;
        private BrightIdeasSoftware.ObjectListView ObjDialogList;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ListView ListViewMsg;
        private System.Windows.Forms.ColumnHeader NameColumn;
        private System.Windows.Forms.ColumnHeader TextColumn;
        private System.Windows.Forms.ColumnHeader DateColumn;
        private System.Windows.Forms.Button LoadMoreButton;
        private System.Windows.Forms.Button ReloadButton;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ImageList FriendsPictureList;
        private BrightIdeasSoftware.ObjectListView FriendsListView1;
        private BrightIdeasSoftware.OLVColumn ImageColumn;
        private BrightIdeasSoftware.OLVColumn FirstNameColumn;
        private BrightIdeasSoftware.OLVColumn LastNameColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label TabUserInfoFollowYouLabel;
        private System.Windows.Forms.Button TabUserInfoFriendButton;
    }
}