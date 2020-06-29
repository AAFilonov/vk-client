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
            this.ActionList = new System.Windows.Forms.ListBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.Page = new System.Windows.Forms.TabControl();
            this.MyPage = new System.Windows.Forms.TabPage();
            this.Messages = new System.Windows.Forms.TabPage();
            this.Dialog = new System.Windows.Forms.TabPage();
            this.Friends = new System.Windows.Forms.TabPage();
            this.Groups = new System.Windows.Forms.TabPage();
            this.Settings = new System.Windows.Forms.TabPage();
            this.MyAvatarPicture = new System.Windows.Forms.PictureBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.LastloginLabel = new System.Windows.Forms.Label();
            this.Page.SuspendLayout();
            this.MyPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MyAvatarPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // ActionList
            // 
            this.ActionList.BackColor = System.Drawing.SystemColors.Control;
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
            this.Page.Controls.Add(this.MyPage);
            this.Page.Controls.Add(this.Messages);
            this.Page.Controls.Add(this.Dialog);
            this.Page.Controls.Add(this.Groups);
            this.Page.Controls.Add(this.Friends);
            this.Page.Controls.Add(this.Settings);
            this.Page.ItemSize = new System.Drawing.Size(50, 20);
            this.Page.Location = new System.Drawing.Point(162, 13);
            this.Page.Name = "Page";
            this.Page.SelectedIndex = 0;
            this.Page.Size = new System.Drawing.Size(641, 428);
            this.Page.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.Page.TabIndex = 2;
            // 
            // MyPage
            // 
            this.MyPage.Controls.Add(this.LastloginLabel);
            this.MyPage.Controls.Add(this.NameLabel);
            this.MyPage.Controls.Add(this.MyAvatarPicture);
            this.MyPage.Location = new System.Drawing.Point(4, 24);
            this.MyPage.Name = "MyPage";
            this.MyPage.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.MyPage.Size = new System.Drawing.Size(633, 400);
            this.MyPage.TabIndex = 0;
            this.MyPage.Text = "MyPage";
            this.MyPage.UseVisualStyleBackColor = true;
            // 
            // Messages
            // 
            this.Messages.Location = new System.Drawing.Point(4, 24);
            this.Messages.Name = "Messages";
            this.Messages.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.Messages.Size = new System.Drawing.Size(543, 330);
            this.Messages.TabIndex = 1;
            this.Messages.Text = "Messages";
            this.Messages.UseVisualStyleBackColor = true;
            // 
            // Dialog
            // 
            this.Dialog.Location = new System.Drawing.Point(4, 24);
            this.Dialog.Name = "Dialog";
            this.Dialog.Size = new System.Drawing.Size(543, 330);
            this.Dialog.TabIndex = 2;
            this.Dialog.Text = "Dialog";
            this.Dialog.UseVisualStyleBackColor = true;
            // 
            // Friends
            // 
            this.Friends.Location = new System.Drawing.Point(4, 24);
            this.Friends.Name = "Friends";
            this.Friends.Size = new System.Drawing.Size(543, 330);
            this.Friends.TabIndex = 3;
            this.Friends.Text = "Friends";
            this.Friends.UseVisualStyleBackColor = true;
            // 
            // Groups
            // 
            this.Groups.Location = new System.Drawing.Point(4, 24);
            this.Groups.Name = "Groups";
            this.Groups.Size = new System.Drawing.Size(543, 330);
            this.Groups.TabIndex = 4;
            this.Groups.Text = "Groups";
            this.Groups.UseVisualStyleBackColor = true;
            // 
            // Settings
            // 
            this.Settings.Location = new System.Drawing.Point(4, 24);
            this.Settings.Name = "Settings";
            this.Settings.Size = new System.Drawing.Size(543, 330);
            this.Settings.TabIndex = 5;
            this.Settings.Text = "Settings";
            this.Settings.UseVisualStyleBackColor = true;
            // 
            // MyAvatarPicture
            // 
            this.MyAvatarPicture.Location = new System.Drawing.Point(19, 19);
            this.MyAvatarPicture.Name = "MyAvatarPicture";
            this.MyAvatarPicture.Size = new System.Drawing.Size(171, 161);
            this.MyAvatarPicture.TabIndex = 0;
            this.MyAvatarPicture.TabStop = false;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(225, 19);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(66, 14);
            this.NameLabel.TabIndex = 1;
            this.NameLabel.Text = "NameLabel";
            // 
            // LastloginLabel
            // 
            this.LastloginLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.LastloginLabel.Location = new System.Drawing.Point(515, 19);
            this.LastloginLabel.Name = "LastloginLabel";
            this.LastloginLabel.Size = new System.Drawing.Size(112, 14);
            this.LastloginLabel.TabIndex = 2;
            this.LastloginLabel.Text = "заходил 2 недели назад";
            this.LastloginLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.MyPage.ResumeLayout(false);
            this.MyPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MyAvatarPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox ActionList;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.TabControl Page;
        private System.Windows.Forms.TabPage MyPage;
        private System.Windows.Forms.Label LastloginLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.PictureBox MyAvatarPicture;
        private System.Windows.Forms.TabPage Messages;
        private System.Windows.Forms.TabPage Dialog;
        private System.Windows.Forms.TabPage Groups;
        private System.Windows.Forms.TabPage Friends;
        private System.Windows.Forms.TabPage Settings;
    }
}