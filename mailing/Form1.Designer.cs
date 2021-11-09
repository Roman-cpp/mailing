
namespace mailing
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Settings = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.IsOpen = new System.Windows.Forms.Label();
            this.File = new System.Windows.Forms.Button();
            this.Mailing = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Settings
            // 
            this.Settings.BackgroundImage = global::mailing.Properties.Resources.pngegg;
            this.Settings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Settings.FlatAppearance.BorderSize = 0;
            this.Settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Settings.Location = new System.Drawing.Point(379, 8);
            this.Settings.Name = "Settings";
            this.Settings.Size = new System.Drawing.Size(50, 50);
            this.Settings.TabIndex = 0;
            this.Settings.UseVisualStyleBackColor = true;
            this.Settings.Click += new System.EventHandler(this.Settings_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.IsOpen);
            this.panel1.Controls.Add(this.File);
            this.panel1.Controls.Add(this.Mailing);
            this.panel1.Location = new System.Drawing.Point(-4, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(452, 114);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.IsOpen_Paint);
            // 
            // IsOpen
            // 
            this.IsOpen.AutoSize = true;
            this.IsOpen.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.IsOpen.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.IsOpen.Location = new System.Drawing.Point(27, 39);
            this.IsOpen.Name = "IsOpen";
            this.IsOpen.Size = new System.Drawing.Size(266, 19);
            this.IsOpen.TabIndex = 6;
            this.IsOpen.Text = "Выберите файл с адресами получателей";
            // 
            // File
            // 
            this.File.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.File.BackgroundImage = global::mailing.Properties.Resources.pngwing_com;
            this.File.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.File.FlatAppearance.BorderSize = 0;
            this.File.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.File.Location = new System.Drawing.Point(309, 28);
            this.File.Name = "File";
            this.File.Size = new System.Drawing.Size(40, 40);
            this.File.TabIndex = 4;
            this.File.UseVisualStyleBackColor = false;
            this.File.Click += new System.EventHandler(this.OpenFile_Click);
            // 
            // Mailing
            // 
            this.Mailing.FlatAppearance.BorderSize = 0;
            this.Mailing.Location = new System.Drawing.Point(363, 28);
            this.Mailing.Name = "Mailing";
            this.Mailing.Size = new System.Drawing.Size(70, 40);
            this.Mailing.TabIndex = 3;
            this.Mailing.Text = "Разослать";
            this.Mailing.UseVisualStyleBackColor = true;
            this.Mailing.Click += new System.EventHandler(this.SendingMailinglist_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(434, 161);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Settings);
            this.MaximumSize = new System.Drawing.Size(450, 200);
            this.MinimumSize = new System.Drawing.Size(450, 200);
            this.Name = "Form1";
            this.Text = "Рассылка";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Settings;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Mailing;
        private System.Windows.Forms.Button File;
        public System.Windows.Forms.Label IsOpen;
    }
}

