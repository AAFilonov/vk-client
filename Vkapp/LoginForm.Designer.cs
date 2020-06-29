namespace Vkapp
{
    partial class LoginForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.AuthButton = new System.Windows.Forms.Button();
            this.PasswordlTextbox = new System.Windows.Forms.TextBox();
            this.EmailTextbox = new System.Windows.Forms.TextBox();
            this.AuthErrorLabel = new System.Windows.Forms.Label();
            this.LogoLabel = new System.Windows.Forms.Label();
            this.PassViev = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // AuthButton
            // 
            this.AuthButton.BackColor = System.Drawing.Color.SteelBlue;
            this.AuthButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AuthButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AuthButton.ForeColor = System.Drawing.SystemColors.Control;
            this.AuthButton.Location = new System.Drawing.Point(74, 263);
            this.AuthButton.Name = "AuthButton";
            this.AuthButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.AuthButton.Size = new System.Drawing.Size(142, 42);
            this.AuthButton.TabIndex = 0;
            this.AuthButton.Text = "Войти";
            this.AuthButton.UseVisualStyleBackColor = false;
            this.AuthButton.Click += new System.EventHandler(this.Auth_Click);
            // 
            // PasswordlTextbox
            // 
            this.PasswordlTextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PasswordlTextbox.ForeColor = System.Drawing.SystemColors.GrayText;
            this.PasswordlTextbox.Location = new System.Drawing.Point(74, 207);
            this.PasswordlTextbox.Name = "PasswordlTextbox";
            this.PasswordlTextbox.Size = new System.Drawing.Size(142, 20);
            this.PasswordlTextbox.TabIndex = 1;
            this.PasswordlTextbox.Text = "Пароль";
            this.PasswordlTextbox.UseSystemPasswordChar = true;
            // 
            // EmailTextbox
            // 
            this.EmailTextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EmailTextbox.ForeColor = System.Drawing.SystemColors.GrayText;
            this.EmailTextbox.Location = new System.Drawing.Point(74, 171);
            this.EmailTextbox.Name = "EmailTextbox";
            this.EmailTextbox.Size = new System.Drawing.Size(142, 20);
            this.EmailTextbox.TabIndex = 2;
            this.EmailTextbox.Text = "Телефон или email";
            // 
            // AuthErrorLabel
            // 
            this.AuthErrorLabel.AutoSize = true;
            this.AuthErrorLabel.ForeColor = System.Drawing.Color.Black;
            this.AuthErrorLabel.Location = new System.Drawing.Point(71, 146);
            this.AuthErrorLabel.Name = "AuthErrorLabel";
            this.AuthErrorLabel.Size = new System.Drawing.Size(106, 13);
            this.AuthErrorLabel.TabIndex = 3;
            this.AuthErrorLabel.Text = "Проверка данных...";
            this.AuthErrorLabel.Visible = false;
            // 
            // LogoLabel
            // 
            this.LogoLabel.AutoSize = true;
            this.LogoLabel.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogoLabel.ForeColor = System.Drawing.Color.SteelBlue;
            this.LogoLabel.Location = new System.Drawing.Point(29, 28);
            this.LogoLabel.Name = "LogoLabel";
            this.LogoLabel.Size = new System.Drawing.Size(240, 28);
            this.LogoLabel.TabIndex = 4;
            this.LogoLabel.Text = "Тестовый  клиент ВК";
            // 
            // PassViev
            // 
            this.PassViev.AutoSize = true;
            this.PassViev.Location = new System.Drawing.Point(74, 240);
            this.PassViev.Name = "PassViev";
            this.PassViev.Size = new System.Drawing.Size(82, 17);
            this.PassViev.TabIndex = 5;
            this.PassViev.Text = "Видимость";
            this.PassViev.UseVisualStyleBackColor = true;
            this.PassViev.CheckedChanged += new System.EventHandler(this.PassViev_CheckedChanged);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 350);
            this.Controls.Add(this.PassViev);
            this.Controls.Add(this.LogoLabel);
            this.Controls.Add(this.AuthErrorLabel);
            this.Controls.Add(this.EmailTextbox);
            this.Controls.Add(this.PasswordlTextbox);
            this.Controls.Add(this.AuthButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VkNetLogin";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AuthButton;
        private System.Windows.Forms.TextBox PasswordlTextbox;
        private System.Windows.Forms.TextBox EmailTextbox;
        private System.Windows.Forms.Label AuthErrorLabel;
        private System.Windows.Forms.Label LogoLabel;
        private System.Windows.Forms.CheckBox PassViev;
    }
}

