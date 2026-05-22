namespace DVDL_Driving_License_Management_WindowsForm.Screens.Applications.Repleacment_Application
{
    partial class frmReplacmentApplication
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReplacmentApplication));
            this.ctrLicenseInfoWithFilter1 = new DVDL_Driving_License_Management_WindowsForm.Screens.Licenses.Local_Licenses.Controls.ctrLicenseInfoWithFilter();
            this.gbRepleacmentFor = new System.Windows.Forms.GroupBox();
            this.fbForLost = new System.Windows.Forms.RadioButton();
            this.rbForDamaged = new System.Windows.Forms.RadioButton();
            this.btnIssueRepleacment = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.llblShowNewLicenseInfo = new System.Windows.Forms.LinkLabel();
            this.llblShowlicenseHistory = new System.Windows.Forms.LinkLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.lblRepleacedLicenseID = new System.Windows.Forms.Label();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblOldLicenseID = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblApplicationFees = new System.Windows.Forms.Label();
            this.lblCreatedBy = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblApplicationDate = new System.Windows.Forms.Label();
            this.lable32 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblRepleacmentApplicationID = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.gbRepleacmentFor.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // ctrLicenseInfoWithFilter1
            // 
            this.ctrLicenseInfoWithFilter1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ctrLicenseInfoWithFilter1.FilterEnable = true;
            this.ctrLicenseInfoWithFilter1.Location = new System.Drawing.Point(12, 89);
            this.ctrLicenseInfoWithFilter1.Name = "ctrLicenseInfoWithFilter1";
            this.ctrLicenseInfoWithFilter1.Size = new System.Drawing.Size(1084, 514);
            this.ctrLicenseInfoWithFilter1.TabIndex = 1;
            this.ctrLicenseInfoWithFilter1.OnLicenseSelected += new System.Action<int>(this.ctrLicenseInfoWithFilter1_OnLicenseSelected);
            // 
            // gbRepleacmentFor
            // 
            this.gbRepleacmentFor.Controls.Add(this.fbForLost);
            this.gbRepleacmentFor.Controls.Add(this.rbForDamaged);
            this.gbRepleacmentFor.Font = new System.Drawing.Font("Tahoma", 12F);
            this.gbRepleacmentFor.Location = new System.Drawing.Point(797, 71);
            this.gbRepleacmentFor.Name = "gbRepleacmentFor";
            this.gbRepleacmentFor.Size = new System.Drawing.Size(288, 128);
            this.gbRepleacmentFor.TabIndex = 2;
            this.gbRepleacmentFor.TabStop = false;
            this.gbRepleacmentFor.Text = "Repleacment For : ";
            // 
            // fbForLost
            // 
            this.fbForLost.AutoSize = true;
            this.fbForLost.Location = new System.Drawing.Point(9, 71);
            this.fbForLost.Name = "fbForLost";
            this.fbForLost.Size = new System.Drawing.Size(102, 28);
            this.fbForLost.TabIndex = 1;
            this.fbForLost.Text = "For Lost";
            this.fbForLost.UseVisualStyleBackColor = true;
            // 
            // rbForDamaged
            // 
            this.rbForDamaged.AutoSize = true;
            this.rbForDamaged.Checked = true;
            this.rbForDamaged.Location = new System.Drawing.Point(9, 37);
            this.rbForDamaged.Name = "rbForDamaged";
            this.rbForDamaged.Size = new System.Drawing.Size(151, 28);
            this.rbForDamaged.TabIndex = 0;
            this.rbForDamaged.TabStop = true;
            this.rbForDamaged.Text = "For Damaged";
            this.rbForDamaged.UseVisualStyleBackColor = true;
            this.rbForDamaged.CheckedChanged += new System.EventHandler(this.rbForDamaged_CheckedChanged);
            // 
            // btnIssueRepleacment
            // 
            this.btnIssueRepleacment.BackColor = System.Drawing.Color.DarkCyan;
            this.btnIssueRepleacment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIssueRepleacment.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btnIssueRepleacment.ForeColor = System.Drawing.SystemColors.Control;
            this.btnIssueRepleacment.Image = global::DVDL_Driving_License_Management_WindowsForm.Properties.Resources.Renew_Driving_License_32;
            this.btnIssueRepleacment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIssueRepleacment.Location = new System.Drawing.Point(829, 781);
            this.btnIssueRepleacment.Name = "btnIssueRepleacment";
            this.btnIssueRepleacment.Size = new System.Drawing.Size(256, 56);
            this.btnIssueRepleacment.TabIndex = 50;
            this.btnIssueRepleacment.Text = "Issue Repleacment";
            this.btnIssueRepleacment.UseVisualStyleBackColor = false;
            this.btnIssueRepleacment.Click += new System.EventHandler(this.btnIssueRepleacment_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.DarkCyan;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.SystemColors.Control;
            this.btnClose.Image = global::DVDL_Driving_License_Management_WindowsForm.Properties.Resources.close__1_;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(655, 782);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(158, 55);
            this.btnClose.TabIndex = 49;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // llblShowNewLicenseInfo
            // 
            this.llblShowNewLicenseInfo.AutoSize = true;
            this.llblShowNewLicenseInfo.Font = new System.Drawing.Font("Tahoma", 12F);
            this.llblShowNewLicenseInfo.LinkColor = System.Drawing.Color.Navy;
            this.llblShowNewLicenseInfo.Location = new System.Drawing.Point(268, 800);
            this.llblShowNewLicenseInfo.Name = "llblShowNewLicenseInfo";
            this.llblShowNewLicenseInfo.Size = new System.Drawing.Size(216, 24);
            this.llblShowNewLicenseInfo.TabIndex = 48;
            this.llblShowNewLicenseInfo.TabStop = true;
            this.llblShowNewLicenseInfo.Text = "Show New License Info";
            this.llblShowNewLicenseInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblShowNewLicenseInfo_LinkClicked);
            // 
            // llblShowlicenseHistory
            // 
            this.llblShowlicenseHistory.AutoSize = true;
            this.llblShowlicenseHistory.Font = new System.Drawing.Font("Tahoma", 12F);
            this.llblShowlicenseHistory.LinkColor = System.Drawing.Color.Navy;
            this.llblShowlicenseHistory.Location = new System.Drawing.Point(34, 799);
            this.llblShowlicenseHistory.Name = "llblShowlicenseHistory";
            this.llblShowlicenseHistory.Size = new System.Drawing.Size(199, 24);
            this.llblShowlicenseHistory.TabIndex = 47;
            this.llblShowlicenseHistory.TabStop = true;
            this.llblShowlicenseHistory.Text = "Show License History";
            this.llblShowlicenseHistory.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblShowlicenseHistory_LinkClicked);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.lblRepleacedLicenseID);
            this.groupBox2.Controls.Add(this.pictureBox11);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.lblOldLicenseID);
            this.groupBox2.Controls.Add(this.pictureBox2);
            this.groupBox2.Controls.Add(this.lblApplicationFees);
            this.groupBox2.Controls.Add(this.lblCreatedBy);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.lblApplicationDate);
            this.groupBox2.Controls.Add(this.lable32);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.lblRepleacmentApplicationID);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.pictureBox8);
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Controls.Add(this.pictureBox6);
            this.groupBox2.Controls.Add(this.pictureBox3);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 12F);
            this.groupBox2.Location = new System.Drawing.Point(12, 609);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1073, 167);
            this.groupBox2.TabIndex = 46;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "R.L.Application Info : ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(469, 41);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(241, 24);
            this.label13.TabIndex = 63;
            this.label13.Text = "Repleaced License ID :";
            // 
            // lblRepleacedLicenseID
            // 
            this.lblRepleacedLicenseID.AutoSize = true;
            this.lblRepleacedLicenseID.Location = new System.Drawing.Point(769, 41);
            this.lblRepleacedLicenseID.Name = "lblRepleacedLicenseID";
            this.lblRepleacedLicenseID.Size = new System.Drawing.Size(53, 24);
            this.lblRepleacedLicenseID.TabIndex = 65;
            this.lblRepleacedLicenseID.Text = "[???]";
            // 
            // pictureBox11
            // 
            this.pictureBox11.Image = global::DVDL_Driving_License_Management_WindowsForm.Properties.Resources.id_card__1_;
            this.pictureBox11.Location = new System.Drawing.Point(716, 41);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(34, 30);
            this.pictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox11.TabIndex = 64;
            this.pictureBox11.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(541, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 24);
            this.label2.TabIndex = 57;
            this.label2.Text = "Old License ID :";
            // 
            // lblOldLicenseID
            // 
            this.lblOldLicenseID.AutoSize = true;
            this.lblOldLicenseID.Location = new System.Drawing.Point(766, 123);
            this.lblOldLicenseID.Name = "lblOldLicenseID";
            this.lblOldLicenseID.Size = new System.Drawing.Size(53, 24);
            this.lblOldLicenseID.TabIndex = 59;
            this.lblOldLicenseID.Text = "[???]";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::DVDL_Driving_License_Management_WindowsForm.Properties.Resources.id_card__1_;
            this.pictureBox2.Location = new System.Drawing.Point(716, 123);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(34, 30);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 58;
            this.pictureBox2.TabStop = false;
            // 
            // lblApplicationFees
            // 
            this.lblApplicationFees.AutoSize = true;
            this.lblApplicationFees.Location = new System.Drawing.Point(316, 123);
            this.lblApplicationFees.Name = "lblApplicationFees";
            this.lblApplicationFees.Size = new System.Drawing.Size(53, 24);
            this.lblApplicationFees.TabIndex = 43;
            this.lblApplicationFees.Text = "[???]";
            // 
            // lblCreatedBy
            // 
            this.lblCreatedBy.AutoSize = true;
            this.lblCreatedBy.Location = new System.Drawing.Point(766, 82);
            this.lblCreatedBy.Name = "lblCreatedBy";
            this.lblCreatedBy.Size = new System.Drawing.Size(53, 24);
            this.lblCreatedBy.TabIndex = 48;
            this.lblCreatedBy.Text = "[???]";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 24);
            this.label1.TabIndex = 25;
            this.label1.Text = "L.R Application ID :";
            // 
            // lblApplicationDate
            // 
            this.lblApplicationDate.AutoSize = true;
            this.lblApplicationDate.Location = new System.Drawing.Point(316, 82);
            this.lblApplicationDate.Name = "lblApplicationDate";
            this.lblApplicationDate.Size = new System.Drawing.Size(53, 24);
            this.lblApplicationDate.TabIndex = 46;
            this.lblApplicationDate.Text = "[???]";
            // 
            // lable32
            // 
            this.lable32.AutoSize = true;
            this.lable32.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lable32.Location = new System.Drawing.Point(15, 123);
            this.lable32.Name = "lable32";
            this.lable32.Size = new System.Drawing.Size(189, 24);
            this.lable32.TabIndex = 27;
            this.lable32.Text = "Application Fees :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(14, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(190, 24);
            this.label6.TabIndex = 30;
            this.label6.Text = "Application Date :";
            // 
            // lblRepleacmentApplicationID
            // 
            this.lblRepleacmentApplicationID.AutoSize = true;
            this.lblRepleacmentApplicationID.Location = new System.Drawing.Point(315, 41);
            this.lblRepleacmentApplicationID.Name = "lblRepleacmentApplicationID";
            this.lblRepleacmentApplicationID.Size = new System.Drawing.Size(53, 24);
            this.lblRepleacmentApplicationID.TabIndex = 41;
            this.lblRepleacmentApplicationID.Text = "[???]";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(576, 82);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(134, 24);
            this.label8.TabIndex = 32;
            this.label8.Text = "Created By :";
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = global::DVDL_Driving_License_Management_WindowsForm.Properties.Resources.User_32__2;
            this.pictureBox8.Location = new System.Drawing.Point(716, 82);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(34, 30);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox8.TabIndex = 40;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DVDL_Driving_License_Management_WindowsForm.Properties.Resources.id_card__1_;
            this.pictureBox1.Location = new System.Drawing.Point(260, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(34, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(260, 82);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(34, 30);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 38;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::DVDL_Driving_License_Management_WindowsForm.Properties.Resources.money_32;
            this.pictureBox3.Location = new System.Drawing.Point(260, 123);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(34, 30);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 35;
            this.pictureBox3.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.SlateGray;
            this.lblTitle.Location = new System.Drawing.Point(185, 23);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(614, 45);
            this.lblTitle.TabIndex = 52;
            this.lblTitle.Text = "Repleacment for Damaged License";
            // 
            // frmReplacmentApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(1097, 839);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnIssueRepleacment);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.llblShowNewLicenseInfo);
            this.Controls.Add(this.llblShowlicenseHistory);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gbRepleacmentFor);
            this.Controls.Add(this.ctrLicenseInfoWithFilter1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmReplacmentApplication";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Replacment For Lost Or Damaged";
            this.Load += new System.EventHandler(this.frmReplacmentApplication_Load);
            this.gbRepleacmentFor.ResumeLayout(false);
            this.gbRepleacmentFor.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Licenses.Local_Licenses.Controls.ctrLicenseInfoWithFilter ctrLicenseInfoWithFilter1;
        private System.Windows.Forms.GroupBox gbRepleacmentFor;
        private System.Windows.Forms.Button btnIssueRepleacment;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.LinkLabel llblShowNewLicenseInfo;
        private System.Windows.Forms.LinkLabel llblShowlicenseHistory;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblRepleacedLicenseID;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.Label lblApplicationFees;
        private System.Windows.Forms.Label lblCreatedBy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblApplicationDate;
        private System.Windows.Forms.Label lable32;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblRepleacmentApplicationID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.RadioButton fbForLost;
        private System.Windows.Forms.RadioButton rbForDamaged;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblOldLicenseID;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}