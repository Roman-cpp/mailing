
namespace mailing
{
    partial class Form2
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
            this.LabelFromEmail = new System.Windows.Forms.Label();
            this.FromEmail = new System.Windows.Forms.TextBox();
            this.LablHost = new System.Windows.Forms.Label();
            this.LabelPort = new System.Windows.Forms.Label();
            this.LabelSubject = new System.Windows.Forms.Label();
            this.Body = new System.Windows.Forms.RichTextBox();
            this.TextOfLetter = new System.Windows.Forms.Label();
            this.Port = new System.Windows.Forms.TextBox();
            this.Subject = new System.Windows.Forms.TextBox();
            this.Host = new System.Windows.Forms.TextBox();
            this.FromName = new System.Windows.Forms.TextBox();
            this.LabelFromName = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.TextBox();
            this.LabelPassword = new System.Windows.Forms.Label();
            this.Ok = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LabelFromEmail
            // 
            this.LabelFromEmail.AutoSize = true;
            this.LabelFromEmail.Location = new System.Drawing.Point(13, 50);
            this.LabelFromEmail.Name = "LabelFromEmail";
            this.LabelFromEmail.Size = new System.Drawing.Size(113, 15);
            this.LabelFromEmail.TabIndex = 0;
            this.LabelFromEmail.Text = "Почта отправителя";
         
            // 
            // FromEmail
            // 
            this.FromEmail.Location = new System.Drawing.Point(132, 47);
            this.FromEmail.Name = "FromEmail";
            this.FromEmail.Size = new System.Drawing.Size(164, 23);
            this.FromEmail.TabIndex = 1;
            // 
            // LablHost
            // 
            this.LablHost.AutoSize = true;
            this.LablHost.Location = new System.Drawing.Point(13, 168);
            this.LablHost.Name = "LablHost";
            this.LablHost.Size = new System.Drawing.Size(32, 15);
            this.LablHost.TabIndex = 2;
            this.LablHost.Text = "Хост";
         
            // 
            // LabelPort
            // 
            this.LabelPort.AutoSize = true;
            this.LabelPort.Location = new System.Drawing.Point(13, 139);
            this.LabelPort.Name = "LabelPort";
            this.LabelPort.Size = new System.Drawing.Size(35, 15);
            this.LabelPort.TabIndex = 3;
            this.LabelPort.Text = "Порт";
            // 
            // LabelSubject
            // 
            this.LabelSubject.AutoSize = true;
            this.LabelSubject.Location = new System.Drawing.Point(13, 110);
            this.LabelSubject.Name = "LabelSubject";
            this.LabelSubject.Size = new System.Drawing.Size(78, 15);
            this.LabelSubject.TabIndex = 4;
            this.LabelSubject.Text = "Тема письма";
           
            // 
            // Body
            // 
            this.Body.Location = new System.Drawing.Point(311, 36);
            this.Body.Name = "Body";
            this.Body.Size = new System.Drawing.Size(626, 348);
            this.Body.TabIndex = 5;
            this.Body.Text = "";
            // 
            // TextOfLetter
            // 
            this.TextOfLetter.AutoSize = true;
            this.TextOfLetter.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TextOfLetter.Location = new System.Drawing.Point(311, 9);
            this.TextOfLetter.Name = "TextOfLetter";
            this.TextOfLetter.Size = new System.Drawing.Size(104, 21);
            this.TextOfLetter.TabIndex = 6;
            this.TextOfLetter.Text = "Текст письма";
         
            // 
            // Port
            // 
            this.Port.Location = new System.Drawing.Point(132, 136);
            this.Port.Name = "Port";
            this.Port.Size = new System.Drawing.Size(164, 23);
            this.Port.TabIndex = 7;
            this.Port.Text = "587";
            // 
            // Subject
            // 
            this.Subject.Location = new System.Drawing.Point(132, 107);
            this.Subject.Name = "Subject";
            this.Subject.Size = new System.Drawing.Size(164, 23);
            this.Subject.TabIndex = 8;
            // 
            // Host
            // 
            this.Host.Location = new System.Drawing.Point(132, 165);
            this.Host.Name = "Host";
            this.Host.Size = new System.Drawing.Size(164, 23);
            this.Host.TabIndex = 9;
            this.Host.Text = "smtp.yandex.com";
            // 
            // FromName
            // 
            this.FromName.Location = new System.Drawing.Point(132, 18);
            this.FromName.Name = "FromName";
            this.FromName.Size = new System.Drawing.Size(164, 23);
            this.FromName.TabIndex = 10;
            // 
            // LabelFromName
            // 
            this.LabelFromName.AutoSize = true;
            this.LabelFromName.Location = new System.Drawing.Point(13, 21);
            this.LabelFromName.Name = "LabelFromName";
            this.LabelFromName.Size = new System.Drawing.Size(104, 15);
            this.LabelFromName.TabIndex = 11;
            this.LabelFromName.Text = "Имя отпровителя";
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(132, 78);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(164, 23);
            this.Password.TabIndex = 12;
            // 
            // LabelPassword
            // 
            this.LabelPassword.AutoSize = true;
            this.LabelPassword.Location = new System.Drawing.Point(13, 81);
            this.LabelPassword.Name = "LabelPassword";
            this.LabelPassword.Size = new System.Drawing.Size(49, 15);
            this.LabelPassword.TabIndex = 13;
            this.LabelPassword.Text = "Пароль";
            // 
            // Ok
            // 
            this.Ok.Location = new System.Drawing.Point(862, 405);
            this.Ok.Name = "Ok";
            this.Ok.Size = new System.Drawing.Size(75, 23);
            this.Ok.TabIndex = 14;
            this.Ok.Text = "Ok";
            this.Ok.UseVisualStyleBackColor = true;
            this.Ok.Click += new System.EventHandler(this.Ok_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 442);
            this.Controls.Add(this.Ok);
            this.Controls.Add(this.LabelPassword);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.LabelFromName);
            this.Controls.Add(this.FromName);
            this.Controls.Add(this.Host);
            this.Controls.Add(this.Subject);
            this.Controls.Add(this.Port);
            this.Controls.Add(this.TextOfLetter);
            this.Controls.Add(this.Body);
            this.Controls.Add(this.LabelSubject);
            this.Controls.Add(this.LabelPort);
            this.Controls.Add(this.LablHost);
            this.Controls.Add(this.FromEmail);
            this.Controls.Add(this.LabelFromEmail);
            this.Name = "Form2";
            this.Text = "Настройки";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelFromEmail;
        public System.Windows.Forms.TextBox FromEmail;
        private System.Windows.Forms.Label LablHost;
        private System.Windows.Forms.Label LabelPort;
        private System.Windows.Forms.Label LabelSubject;
        public System.Windows.Forms.RichTextBox Body;
        private System.Windows.Forms.Label TextOfLetter;
        public System.Windows.Forms.TextBox Port;
        public System.Windows.Forms.TextBox Subject;
        public System.Windows.Forms.TextBox Host;
        public System.Windows.Forms.TextBox FromName;
        private System.Windows.Forms.Label LabelFromName;
        public System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Label LabelPassword;
        private System.Windows.Forms.Button Ok;
    }
} 