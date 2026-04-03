namespace DVDL_Driving_License_Management_WindowsForm.Screens.Users
{
    partial class frmAddUpdateUser
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tbLoginInfo = new System.Windows.Forms.TabPage();
            this.lblPassword = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txbPassword = new System.Windows.Forms.TextBox();
            this.txbUsername = new System.Windows.Forms.TextBox();
            this.txbConfirmPasswrod = new System.Windows.Forms.TextBox();
            this.cbIsActive = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblUserID = new System.Windows.Forms.Label();
            this.PersonInfo = new System.Windows.Forms.TabPage();
            this.ctrPersonDetailsWithFilter1 = new DVDL_Driving_License_Management_WindowsForm.User_Controls.ctrPersonDetailsWithFilter();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.tabPage = new System.Windows.Forms.TabControl();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.tbLoginInfo.SuspendLayout();
            this.PersonInfo.SuspendLayout();
            this.tabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Times New Roman", 36F);
            this.lblTitle.ForeColor = System.Drawing.Color.SlateGray;
            this.lblTitle.Location = new System.Drawing.Point(519, 38);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(387, 68);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Add New User";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.DarkCyan;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.SystemColors.Control;
            this.btnClose.Image = global::DVDL_Driving_License_Management_WindowsForm.Properties.Resources.close__1_;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(1188, 913);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(202, 57);
            this.btnClose.TabIndex = 79;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // tabPage2
            // 
            this.tbLoginInfo.BackColor = System.Drawing.Color.DarkSlateGray;
            this.tbLoginInfo.Controls.Add(this.lblUserID);
            this.tbLoginInfo.Controls.Add(this.btnSave);
            this.tbLoginInfo.Controls.Add(this.label3);
            this.tbLoginInfo.Controls.Add(this.cbIsActive);
            this.tbLoginInfo.Controls.Add(this.txbConfirmPasswrod);
            this.tbLoginInfo.Controls.Add(this.txbUsername);
            this.tbLoginInfo.Controls.Add(this.txbPassword);
            this.tbLoginInfo.Controls.Add(this.label2);
            this.tbLoginInfo.Controls.Add(this.label4);
            this.tbLoginInfo.Controls.Add(this.lblPassword);
            this.tbLoginInfo.Location = new System.Drawing.Point(4, 30);
            this.tbLoginInfo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbLoginInfo.Name = "tabPage2";
            this.tbLoginInfo.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbLoginInfo.Size = new System.Drawing.Size(1357, 736);
            this.tbLoginInfo.TabIndex = 1;
            this.tbLoginInfo.Text = "Login Info";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Tahoma", 14F);
            this.lblPassword.Location = new System.Drawing.Point(228, 283);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(130, 29);
            this.lblPassword.TabIndex = 87;
            this.lblPassword.Text = "Password :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 14F);
            this.label4.Location = new System.Drawing.Point(221, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 29);
            this.label4.TabIndex = 86;
            this.label4.Text = "Username :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 14F);
            this.label2.Location = new System.Drawing.Point(138, 336);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(220, 29);
            this.label2.TabIndex = 89;
            this.label2.Text = "Confirm Password :";
            // 
            // txbPassword
            // 
            this.txbPassword.Font = new System.Drawing.Font("Tahoma", 14F);
            this.txbPassword.Location = new System.Drawing.Point(377, 283);
            this.txbPassword.Name = "txbPassword";
            this.txbPassword.PasswordChar = '*';
            this.txbPassword.Size = new System.Drawing.Size(224, 36);
            this.txbPassword.TabIndex = 85;
            this.txbPassword.Validating += new System.ComponentModel.CancelEventHandler(this.txbConfirmPasswrod_Validating);
            // 
            // txbUsername
            // 
            this.txbUsername.Font = new System.Drawing.Font("Tahoma", 14F);
            this.txbUsername.Location = new System.Drawing.Point(377, 230);
            this.txbUsername.Name = "txbUsername";
            this.txbUsername.Size = new System.Drawing.Size(224, 36);
            this.txbUsername.TabIndex = 84;
            this.txbUsername.Validating += new System.ComponentModel.CancelEventHandler(this.UserExistsValidation);
            // 
            // txbConfirmPasswrod
            // 
            this.txbConfirmPasswrod.Font = new System.Drawing.Font("Tahoma", 14F);
            this.txbConfirmPasswrod.Location = new System.Drawing.Point(377, 336);
            this.txbConfirmPasswrod.Name = "txbConfirmPasswrod";
            this.txbConfirmPasswrod.PasswordChar = '*';
            this.txbConfirmPasswrod.Size = new System.Drawing.Size(224, 36);
            this.txbConfirmPasswrod.TabIndex = 88;
            this.txbConfirmPasswrod.Validating += new System.ComponentModel.CancelEventHandler(this.txbConfirmPasswrod_Validating);
            // 
            // cbIsActive
            // 
            this.cbIsActive.AutoSize = true;
            this.cbIsActive.Font = new System.Drawing.Font("Tahoma", 14F);
            this.cbIsActive.Location = new System.Drawing.Point(397, 410);
            this.cbIsActive.Name = "cbIsActive";
            this.cbIsActive.Size = new System.Drawing.Size(126, 33);
            this.cbIsActive.TabIndex = 90;
            this.cbIsActive.Text = "Is Active";
            this.cbIsActive.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 14F);
            this.label3.Location = new System.Drawing.Point(255, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 29);
            this.label3.TabIndex = 91;
            this.label3.Text = "UserID :";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Teal;
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSave.Image = global::DVDL_Driving_License_Management_WindowsForm.Properties.Resources.save1;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(1134, 647);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(199, 57);
            this.btnSave.TabIndex = 78;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblUserID
            // 
            this.lblUserID.AutoSize = true;
            this.lblUserID.Font = new System.Drawing.Font("Tahoma", 14F);
            this.lblUserID.Location = new System.Drawing.Point(373, 177);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(46, 29);
            this.lblUserID.TabIndex = 92;
            this.lblUserID.Text = "???";
            // 
            // tabPage1
            // 
            this.PersonInfo.BackColor = System.Drawing.Color.DarkSlateGray;
            this.PersonInfo.Controls.Add(this.btnReset);
            this.PersonInfo.Controls.Add(this.btnNext);
            this.PersonInfo.Controls.Add(this.ctrPersonDetailsWithFilter1);
            this.PersonInfo.Location = new System.Drawing.Point(4, 30);
            this.PersonInfo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PersonInfo.Name = "tabPage1";
            this.PersonInfo.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PersonInfo.Size = new System.Drawing.Size(1357, 736);
            this.PersonInfo.TabIndex = 0;
            this.PersonInfo.Text = "Person Info";
            // 
            // ctrPersonDetailsWithFilter1
            // 
            this.ctrPersonDetailsWithFilter1.AddNewVisablity = true;
            this.ctrPersonDetailsWithFilter1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ctrPersonDetailsWithFilter1.FilterEnable = true;
            this.ctrPersonDetailsWithFilter1.Location = new System.Drawing.Point(16, 8);
            this.ctrPersonDetailsWithFilter1.Margin = new System.Windows.Forms.Padding(4);
            this.ctrPersonDetailsWithFilter1.Name = "ctrPersonDetailsWithFilter1";
            this.ctrPersonDetailsWithFilter1.Size = new System.Drawing.Size(1338, 638);
            this.ctrPersonDetailsWithFilter1.TabIndex = 0;
            this.ctrPersonDetailsWithFilter1.OnPersonSelected += new System.Action<int>(this.ctrPersonDetailsWithFilter1_OnPersonSelected);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.DarkCyan;
            this.btnNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnNext.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Font = new System.Drawing.Font("Tahoma", 14F);
            this.btnNext.ForeColor = System.Drawing.SystemColors.Control;
            this.btnNext.Image = global::DVDL_Driving_License_Management_WindowsForm.Properties.Resources.Next_32px;
            this.btnNext.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNext.Location = new System.Drawing.Point(1065, 653);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(265, 70);
            this.btnNext.TabIndex = 1;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.DarkCyan;
            this.btnReset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnReset.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Tahoma", 14F);
            this.btnReset.ForeColor = System.Drawing.SystemColors.Control;
            this.btnReset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReset.Location = new System.Drawing.Point(861, 653);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(161, 70);
            this.btnReset.TabIndex = 2;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // tabPage
            // 
            this.tabPage.Controls.Add(this.PersonInfo);
            this.tabPage.Controls.Add(this.tbLoginInfo);
            this.tabPage.Location = new System.Drawing.Point(29, 133);
            this.tabPage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage.Name = "tabPage";
            this.tabPage.SelectedIndex = 0;
            this.tabPage.Size = new System.Drawing.Size(1365, 770);
            this.tabPage.TabIndex = 0;
            // 
            // frmAddUpdateUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(1435, 982);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.tabPage);
            this.Font = new System.Drawing.Font("Tahoma", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmAddUpdateUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddUpdateUser";
            this.Load += new System.EventHandler(this.frmAddUpdateUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.tbLoginInfo.ResumeLayout(false);
            this.tbLoginInfo.PerformLayout();
            this.PersonInfo.ResumeLayout(false);
            this.tabPage.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TabControl tabPage;
        private System.Windows.Forms.TabPage PersonInfo;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnNext;
        private User_Controls.ctrPersonDetailsWithFilter ctrPersonDetailsWithFilter1;
        private System.Windows.Forms.TabPage tbLoginInfo;
        private System.Windows.Forms.Label lblUserID;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox cbIsActive;
        private System.Windows.Forms.TextBox txbConfirmPasswrod;
        private System.Windows.Forms.TextBox txbUsername;
        private System.Windows.Forms.TextBox txbPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblPassword;
    }
}