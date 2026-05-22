namespace DVDL_Driving_License_Management_WindowsForm.Screens.Licenses.International_Licenses
{
    partial class frmAddNewInternationalLicense
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
            this.btnIssue = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.llblShowLicenseInfo = new System.Windows.Forms.LinkLabel();
            this.llblShowLicenseHistory = new System.Windows.Forms.LinkLabel();
            this.ctrInternationalLicenseApplicartionDetails1 = new DVDL_Driving_License_Management_WindowsForm.Screens.Applications.Controls.ctrInternationalLicenseApplicartionDetails();
            this.ctrLicenseInfoWithFilter1 = new DVDL_Driving_License_Management_WindowsForm.Screens.Licenses.Local_Licenses.Controls.ctrLicenseInfoWithFilter();
            this.SuspendLayout();
            // 
            // btnIssue
            // 
            this.btnIssue.BackColor = System.Drawing.Color.DarkCyan;
            this.btnIssue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIssue.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIssue.ForeColor = System.Drawing.SystemColors.Control;
            this.btnIssue.Image = global::DVDL_Driving_License_Management_WindowsForm.Properties.Resources.International_32;
            this.btnIssue.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIssue.Location = new System.Drawing.Point(927, 851);
            this.btnIssue.Name = "btnIssue";
            this.btnIssue.Size = new System.Drawing.Size(158, 61);
            this.btnIssue.TabIndex = 43;
            this.btnIssue.Text = "Issue";
            this.btnIssue.UseVisualStyleBackColor = false;
            this.btnIssue.Click += new System.EventHandler(this.btnIssue_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.DarkCyan;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.SystemColors.Control;
            this.btnClose.Image = global::DVDL_Driving_License_Management_WindowsForm.Properties.Resources.close__1_;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(748, 851);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(158, 61);
            this.btnClose.TabIndex = 42;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SlateGray;
            this.label1.Location = new System.Drawing.Point(240, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(564, 45);
            this.label1.TabIndex = 44;
            this.label1.Text = "Issue New International License";
            // 
            // llblShowLicenseInfo
            // 
            this.llblShowLicenseInfo.AutoSize = true;
            this.llblShowLicenseInfo.Font = new System.Drawing.Font("Tahoma", 12F);
            this.llblShowLicenseInfo.LinkColor = System.Drawing.Color.Navy;
            this.llblShowLicenseInfo.Location = new System.Drawing.Point(280, 869);
            this.llblShowLicenseInfo.Name = "llblShowLicenseInfo";
            this.llblShowLicenseInfo.Size = new System.Drawing.Size(171, 24);
            this.llblShowLicenseInfo.TabIndex = 45;
            this.llblShowLicenseInfo.TabStop = true;
            this.llblShowLicenseInfo.Text = "Show License Info";
            this.llblShowLicenseInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblShowLicenseInfo_LinkClicked);
            // 
            // llblShowLicenseHistory
            // 
            this.llblShowLicenseHistory.AutoSize = true;
            this.llblShowLicenseHistory.Font = new System.Drawing.Font("Tahoma", 12F);
            this.llblShowLicenseHistory.LinkColor = System.Drawing.Color.Navy;
            this.llblShowLicenseHistory.Location = new System.Drawing.Point(50, 869);
            this.llblShowLicenseHistory.Name = "llblShowLicenseHistory";
            this.llblShowLicenseHistory.Size = new System.Drawing.Size(199, 24);
            this.llblShowLicenseHistory.TabIndex = 46;
            this.llblShowLicenseHistory.TabStop = true;
            this.llblShowLicenseHistory.Text = "Show License History";
            this.llblShowLicenseHistory.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblShowLicenseHistory_LinkClicked);
            // 
            // ctrInternationalLicenseApplicartionDetails1
            // 
            this.ctrInternationalLicenseApplicartionDetails1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ctrInternationalLicenseApplicartionDetails1.LocalLicenseID = 0;
            this.ctrInternationalLicenseApplicartionDetails1.Location = new System.Drawing.Point(12, 580);
            this.ctrInternationalLicenseApplicartionDetails1.Name = "ctrInternationalLicenseApplicartionDetails1";
            this.ctrInternationalLicenseApplicartionDetails1.Size = new System.Drawing.Size(1084, 265);
            this.ctrInternationalLicenseApplicartionDetails1.TabIndex = 47;
            // 
            // ctrLicenseInfoWithFilter1
            // 
            this.ctrLicenseInfoWithFilter1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ctrLicenseInfoWithFilter1.FilterEnable = true;
            this.ctrLicenseInfoWithFilter1.Location = new System.Drawing.Point(12, 68);
            this.ctrLicenseInfoWithFilter1.Name = "ctrLicenseInfoWithFilter1";
            this.ctrLicenseInfoWithFilter1.Size = new System.Drawing.Size(1084, 595);
            this.ctrLicenseInfoWithFilter1.TabIndex = 1;
            this.ctrLicenseInfoWithFilter1.OnLicenseSelected += new System.Action<int>(this.ctrLicenseInfoWithFilter1_OnLicenseSelected);
            // 
            // frmAddNewInternationalLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(1097, 917);
            this.Controls.Add(this.ctrInternationalLicenseApplicartionDetails1);
            this.Controls.Add(this.llblShowLicenseHistory);
            this.Controls.Add(this.llblShowLicenseInfo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnIssue);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.ctrLicenseInfoWithFilter1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmAddNewInternationalLicense";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAddNewInternationalLicense";
            this.Load += new System.EventHandler(this.frmAddNewInternationalLicense_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Local_Licenses.Controls.ctrLicenseInfoWithFilter ctrLicenseInfoWithFilter1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnIssue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel llblShowLicenseInfo;
        private System.Windows.Forms.LinkLabel llblShowLicenseHistory;
        private Applications.Controls.ctrInternationalLicenseApplicartionDetails ctrInternationalLicenseApplicartionDetails1;
    }
}