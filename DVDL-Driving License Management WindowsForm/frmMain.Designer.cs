namespace DVDL_Driving_License_Management_WindowsForm
{
    partial class frmMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sdPeople = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.accountSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsCurrentUserInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsChangePassword = new System.Windows.Forms.ToolStripMenuItem();
            this.tsSingOut = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.AllowMerge = false;
            this.menuStrip1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(70, 70);
            this.menuStrip1.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.sdPeople,
            this.toolStripMenuItem2,
            this.accountSettingsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(1540, 78);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(14, 74);
            // 
            // sdPeople
            // 
            this.sdPeople.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.sdPeople.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sdPeople.ForeColor = System.Drawing.Color.SlateGray;
            this.sdPeople.Image = global::DVDL_Driving_License_Management_WindowsForm.Properties.Resources.PeopleButton;
            this.sdPeople.Name = "sdPeople";
            this.sdPeople.Size = new System.Drawing.Size(176, 74);
            this.sdPeople.Text = "People";
            this.sdPeople.Click += new System.EventHandler(this.sdPeople_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.toolStripMenuItem2.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem2.ForeColor = System.Drawing.Color.SlateGray;
            this.toolStripMenuItem2.Image = global::DVDL_Driving_License_Management_WindowsForm.Properties.Resources.UsersWithColors;
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(164, 74);
            this.toolStripMenuItem2.Text = "Users";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // accountSettingsToolStripMenuItem
            // 
            this.accountSettingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsCurrentUserInfo,
            this.tsChangePassword,
            this.tsSingOut});
            this.accountSettingsToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountSettingsToolStripMenuItem.ForeColor = System.Drawing.Color.SlateGray;
            this.accountSettingsToolStripMenuItem.Image = global::DVDL_Driving_License_Management_WindowsForm.Properties.Resources.account_settings;
            this.accountSettingsToolStripMenuItem.Name = "accountSettingsToolStripMenuItem";
            this.accountSettingsToolStripMenuItem.Size = new System.Drawing.Size(299, 74);
            this.accountSettingsToolStripMenuItem.Text = "Account Settings";
            // 
            // tsCurrentUserInfo
            // 
            this.tsCurrentUserInfo.BackColor = System.Drawing.Color.DarkSlateGray;
            this.tsCurrentUserInfo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsCurrentUserInfo.ForeColor = System.Drawing.Color.SlateGray;
            this.tsCurrentUserInfo.Image = global::DVDL_Driving_License_Management_WindowsForm.Properties.Resources.info__1_;
            this.tsCurrentUserInfo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsCurrentUserInfo.Name = "tsCurrentUserInfo";
            this.tsCurrentUserInfo.Size = new System.Drawing.Size(251, 38);
            this.tsCurrentUserInfo.Text = "Current User Info";
            this.tsCurrentUserInfo.Click += new System.EventHandler(this.tsCurrentUserInfo_Click);
            // 
            // tsChangePassword
            // 
            this.tsChangePassword.BackColor = System.Drawing.Color.DarkSlateGray;
            this.tsChangePassword.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsChangePassword.ForeColor = System.Drawing.Color.SlateGray;
            this.tsChangePassword.Image = global::DVDL_Driving_License_Management_WindowsForm.Properties.Resources.Changepassword;
            this.tsChangePassword.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsChangePassword.Name = "tsChangePassword";
            this.tsChangePassword.Size = new System.Drawing.Size(251, 38);
            this.tsChangePassword.Text = "Chnage Password";
            this.tsChangePassword.Click += new System.EventHandler(this.tsChangePassword_Click);
            // 
            // tsSingOut
            // 
            this.tsSingOut.BackColor = System.Drawing.Color.DarkSlateGray;
            this.tsSingOut.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsSingOut.ForeColor = System.Drawing.Color.SlateGray;
            this.tsSingOut.Image = global::DVDL_Driving_License_Management_WindowsForm.Properties.Resources.close__1_;
            this.tsSingOut.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsSingOut.Name = "tsSingOut";
            this.tsSingOut.Size = new System.Drawing.Size(251, 38);
            this.tsSingOut.Text = "Sing Out";
            this.tsSingOut.Click += new System.EventHandler(this.tsSingOut_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.BackgroundImage = global::DVDL_Driving_License_Management_WindowsForm.Properties.Resources.photo_2026_03_27_17_48_05;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1540, 846);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sdPeople;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem accountSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsCurrentUserInfo;
        private System.Windows.Forms.ToolStripMenuItem tsChangePassword;
        private System.Windows.Forms.ToolStripMenuItem tsSingOut;
    }
}

