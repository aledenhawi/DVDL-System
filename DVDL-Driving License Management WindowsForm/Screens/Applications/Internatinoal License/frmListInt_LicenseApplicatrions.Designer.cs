namespace DVDL_Driving_License_Management_WindowsForm.Screens.Applications.Internatinoal_License
{
    partial class frmListInt_LicenseApplicatrions
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
            this.dgvInternationalLicenseApplications = new System.Windows.Forms.DataGridView();
            this.btnAddNewInternationalLicenseApplication = new System.Windows.Forms.Button();
            this.txbFiltringIntLicenseApplications = new System.Windows.Forms.TextBox();
            this.cmbInternationalLicenseApplicationsFiltring = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTotalRecords = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.cmbIsActive = new System.Windows.Forms.ComboBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsShowPersonDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.tsShowLicenseDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.tsShowPersonLicensesHistory = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInternationalLicenseApplications)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvInternationalLicenseApplications
            // 
            this.dgvInternationalLicenseApplications.AllowUserToAddRows = false;
            this.dgvInternationalLicenseApplications.AllowUserToDeleteRows = false;
            this.dgvInternationalLicenseApplications.BackgroundColor = System.Drawing.Color.SlateGray;
            this.dgvInternationalLicenseApplications.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInternationalLicenseApplications.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvInternationalLicenseApplications.GridColor = System.Drawing.Color.SlateGray;
            this.dgvInternationalLicenseApplications.Location = new System.Drawing.Point(13, 315);
            this.dgvInternationalLicenseApplications.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.dgvInternationalLicenseApplications.Name = "dgvInternationalLicenseApplications";
            this.dgvInternationalLicenseApplications.ReadOnly = true;
            this.dgvInternationalLicenseApplications.RowHeadersWidth = 51;
            this.dgvInternationalLicenseApplications.RowTemplate.Height = 26;
            this.dgvInternationalLicenseApplications.Size = new System.Drawing.Size(1197, 382);
            this.dgvInternationalLicenseApplications.TabIndex = 3;
            // 
            // btnAddNewInternationalLicenseApplication
            // 
            this.btnAddNewInternationalLicenseApplication.BackgroundImage = global::DVDL_Driving_License_Management_WindowsForm.Properties.Resources.application;
            this.btnAddNewInternationalLicenseApplication.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddNewInternationalLicenseApplication.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddNewInternationalLicenseApplication.FlatAppearance.BorderSize = 0;
            this.btnAddNewInternationalLicenseApplication.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNewInternationalLicenseApplication.Location = new System.Drawing.Point(1132, 248);
            this.btnAddNewInternationalLicenseApplication.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddNewInternationalLicenseApplication.Name = "btnAddNewInternationalLicenseApplication";
            this.btnAddNewInternationalLicenseApplication.Size = new System.Drawing.Size(78, 62);
            this.btnAddNewInternationalLicenseApplication.TabIndex = 14;
            this.btnAddNewInternationalLicenseApplication.UseVisualStyleBackColor = true;
            this.btnAddNewInternationalLicenseApplication.Click += new System.EventHandler(this.btnAddNewInternationalLicenseApplication_Click);
            // 
            // txbFiltringIntLicenseApplications
            // 
            this.txbFiltringIntLicenseApplications.Location = new System.Drawing.Point(319, 286);
            this.txbFiltringIntLicenseApplications.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txbFiltringIntLicenseApplications.Name = "txbFiltringIntLicenseApplications";
            this.txbFiltringIntLicenseApplications.Size = new System.Drawing.Size(196, 24);
            this.txbFiltringIntLicenseApplications.TabIndex = 13;
            this.txbFiltringIntLicenseApplications.Visible = false;
            this.txbFiltringIntLicenseApplications.TextChanged += new System.EventHandler(this.txbFiltringIntLicenseApplications_TextChanged);
            this.txbFiltringIntLicenseApplications.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbFiltringIntLicenseApplications_KeyPress);
            // 
            // cmbInternationalLicenseApplicationsFiltring
            // 
            this.cmbInternationalLicenseApplicationsFiltring.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbInternationalLicenseApplicationsFiltring.Font = new System.Drawing.Font("Tahoma", 10F);
            this.cmbInternationalLicenseApplicationsFiltring.FormattingEnabled = true;
            this.cmbInternationalLicenseApplicationsFiltring.Items.AddRange(new object[] {
            "None",
            "Int.License ID",
            "Application ID",
            "Driver ID",
            "Is Active"});
            this.cmbInternationalLicenseApplicationsFiltring.Location = new System.Drawing.Point(113, 282);
            this.cmbInternationalLicenseApplicationsFiltring.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.cmbInternationalLicenseApplicationsFiltring.Name = "cmbInternationalLicenseApplicationsFiltring";
            this.cmbInternationalLicenseApplicationsFiltring.Size = new System.Drawing.Size(182, 29);
            this.cmbInternationalLicenseApplicationsFiltring.TabIndex = 12;
            this.cmbInternationalLicenseApplicationsFiltring.SelectedIndexChanged += new System.EventHandler(this.cmbInternationalLicenseApplicationsFiltring_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.label2.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(11, 282);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 24);
            this.label2.TabIndex = 11;
            this.label2.Text = "Filter By :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SlateGray;
            this.label1.Location = new System.Drawing.Point(325, 212);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(657, 49);
            this.label1.TabIndex = 10;
            this.label1.Text = "International License Applications";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::DVDL_Driving_License_Management_WindowsForm.Properties.Resources.ManageTestTypes_512;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(486, 2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(302, 208);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Perpetua", 16F);
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(13, 699);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 31);
            this.label3.TabIndex = 16;
            this.label3.Text = "Records :";
            // 
            // lblTotalRecords
            // 
            this.lblTotalRecords.AutoSize = true;
            this.lblTotalRecords.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalRecords.Font = new System.Drawing.Font("Perpetua", 16F);
            this.lblTotalRecords.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTotalRecords.Location = new System.Drawing.Point(127, 699);
            this.lblTotalRecords.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalRecords.Name = "lblTotalRecords";
            this.lblTotalRecords.Size = new System.Drawing.Size(26, 31);
            this.lblTotalRecords.TabIndex = 15;
            this.lblTotalRecords.Text = "0";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.DarkCyan;
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnClose.Image = global::DVDL_Driving_License_Management_WindowsForm.Properties.Resources.close__1_;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(1053, 699);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(157, 59);
            this.btnClose.TabIndex = 17;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // cmbIsActive
            // 
            this.cmbIsActive.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIsActive.Font = new System.Drawing.Font("Tahoma", 12F);
            this.cmbIsActive.FormattingEnabled = true;
            this.cmbIsActive.Items.AddRange(new object[] {
            "All",
            "Yes",
            "No"});
            this.cmbIsActive.Location = new System.Drawing.Point(319, 278);
            this.cmbIsActive.Name = "cmbIsActive";
            this.cmbIsActive.Size = new System.Drawing.Size(95, 32);
            this.cmbIsActive.TabIndex = 18;
            this.cmbIsActive.Visible = false;
            this.cmbIsActive.SelectedIndexChanged += new System.EventHandler(this.cmbIsActive_SelectedIndexChanged);
            this.cmbIsActive.VisibleChanged += new System.EventHandler(this.cmbIsActive_VisibleChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsShowPersonDetails,
            this.tsShowLicenseDetails,
            this.tsShowPersonLicensesHistory});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(287, 118);
            // 
            // tsShowPersonDetails
            // 
            this.tsShowPersonDetails.BackColor = System.Drawing.Color.DarkSlateGray;
            this.tsShowPersonDetails.Image = global::DVDL_Driving_License_Management_WindowsForm.Properties.Resources.PersonDetails_32;
            this.tsShowPersonDetails.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsShowPersonDetails.Name = "tsShowPersonDetails";
            this.tsShowPersonDetails.Size = new System.Drawing.Size(286, 38);
            this.tsShowPersonDetails.Text = "Show Person Details";
            this.tsShowPersonDetails.Click += new System.EventHandler(this.tsShowPersonDetails_Click);
            // 
            // tsShowLicenseDetails
            // 
            this.tsShowLicenseDetails.BackColor = System.Drawing.Color.DarkSlateGray;
            this.tsShowLicenseDetails.Image = global::DVDL_Driving_License_Management_WindowsForm.Properties.Resources.License_View_321;
            this.tsShowLicenseDetails.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsShowLicenseDetails.Name = "tsShowLicenseDetails";
            this.tsShowLicenseDetails.Size = new System.Drawing.Size(286, 38);
            this.tsShowLicenseDetails.Text = "Show License Details";
            this.tsShowLicenseDetails.Click += new System.EventHandler(this.tsShowLicenseDetails_Click);
            // 
            // tsShowPersonLicensesHistory
            // 
            this.tsShowPersonLicensesHistory.BackColor = System.Drawing.Color.DarkSlateGray;
            this.tsShowPersonLicensesHistory.Image = global::DVDL_Driving_License_Management_WindowsForm.Properties.Resources.PersonLicenseHistory_32;
            this.tsShowPersonLicensesHistory.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsShowPersonLicensesHistory.Name = "tsShowPersonLicensesHistory";
            this.tsShowPersonLicensesHistory.Size = new System.Drawing.Size(286, 38);
            this.tsShowPersonLicensesHistory.Text = "Show Person Licenses History";
            this.tsShowPersonLicensesHistory.Click += new System.EventHandler(this.tsShowPersonLicensesHistory_Click);
            // 
            // frmListInt_LicenseApplicatrions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(1222, 773);
            this.Controls.Add(this.cmbIsActive);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblTotalRecords);
            this.Controls.Add(this.btnAddNewInternationalLicenseApplication);
            this.Controls.Add(this.txbFiltringIntLicenseApplications);
            this.Controls.Add(this.cmbInternationalLicenseApplicationsFiltring);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dgvInternationalLicenseApplications);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmListInt_LicenseApplicatrions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "List International License Applicatrions";
            this.Load += new System.EventHandler(this.frmListInternationalLicenseApplicatrions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInternationalLicenseApplications)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvInternationalLicenseApplications;
        private System.Windows.Forms.Button btnAddNewInternationalLicenseApplication;
        private System.Windows.Forms.TextBox txbFiltringIntLicenseApplications;
        private System.Windows.Forms.ComboBox cmbInternationalLicenseApplicationsFiltring;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTotalRecords;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ComboBox cmbIsActive;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsShowPersonDetails;
        private System.Windows.Forms.ToolStripMenuItem tsShowLicenseDetails;
        private System.Windows.Forms.ToolStripMenuItem tsShowPersonLicensesHistory;
    }
}