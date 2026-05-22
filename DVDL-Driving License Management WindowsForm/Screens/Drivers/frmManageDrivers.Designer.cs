namespace DVDL_Driving_License_Management_WindowsForm.Screens.Drivers
{
    partial class frmManageDrivers
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
            this.label1 = new System.Windows.Forms.Label();
            this.txbFiltringDrivers = new System.Windows.Forms.TextBox();
            this.cmbDriversFiltring = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvDriversList = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTotalRecords = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnClose = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tsShowPersonInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsLicenseHistory = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDriversList)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.SlateGray;
            this.label1.Location = new System.Drawing.Point(437, 287);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(311, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "Manage Drivers";
            // 
            // txbFiltringDrivers
            // 
            this.txbFiltringDrivers.Location = new System.Drawing.Point(309, 344);
            this.txbFiltringDrivers.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txbFiltringDrivers.Name = "txbFiltringDrivers";
            this.txbFiltringDrivers.Size = new System.Drawing.Size(196, 24);
            this.txbFiltringDrivers.TabIndex = 8;
            this.txbFiltringDrivers.Visible = false;
            this.txbFiltringDrivers.TextChanged += new System.EventHandler(this.txbFiltringDrivers_TextChanged);
            this.txbFiltringDrivers.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbFiltringDrivers_KeyPress);
            // 
            // cmbDriversFiltring
            // 
            this.cmbDriversFiltring.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDriversFiltring.Font = new System.Drawing.Font("Tahoma", 10F);
            this.cmbDriversFiltring.FormattingEnabled = true;
            this.cmbDriversFiltring.Items.AddRange(new object[] {
            "None",
            "Driver ID",
            "Person ID",
            "National No.",
            "Full Name",
            "Active Licenses"});
            this.cmbDriversFiltring.Location = new System.Drawing.Point(103, 340);
            this.cmbDriversFiltring.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.cmbDriversFiltring.Name = "cmbDriversFiltring";
            this.cmbDriversFiltring.Size = new System.Drawing.Size(182, 29);
            this.cmbDriversFiltring.TabIndex = 7;
            this.cmbDriversFiltring.SelectedIndexChanged += new System.EventHandler(this.cmbDriversFiltring_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.label2.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(1, 340);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "Filter By :";
            // 
            // dgvDriversList
            // 
            this.dgvDriversList.AllowUserToAddRows = false;
            this.dgvDriversList.AllowUserToDeleteRows = false;
            this.dgvDriversList.BackgroundColor = System.Drawing.Color.SlateGray;
            this.dgvDriversList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDriversList.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvDriversList.GridColor = System.Drawing.Color.SlateGray;
            this.dgvDriversList.Location = new System.Drawing.Point(-4, 382);
            this.dgvDriversList.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.dgvDriversList.Name = "dgvDriversList";
            this.dgvDriversList.ReadOnly = true;
            this.dgvDriversList.RowHeadersWidth = 51;
            this.dgvDriversList.RowTemplate.Height = 26;
            this.dgvDriversList.Size = new System.Drawing.Size(1148, 356);
            this.dgvDriversList.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Perpetua", 16F);
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(13, 740);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 31);
            this.label3.TabIndex = 11;
            this.label3.Text = "Records :";
            // 
            // lblTotalRecords
            // 
            this.lblTotalRecords.AutoSize = true;
            this.lblTotalRecords.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalRecords.Font = new System.Drawing.Font("Perpetua", 16F);
            this.lblTotalRecords.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTotalRecords.Location = new System.Drawing.Point(127, 740);
            this.lblTotalRecords.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalRecords.Name = "lblTotalRecords";
            this.lblTotalRecords.Size = new System.Drawing.Size(26, 31);
            this.lblTotalRecords.TabIndex = 10;
            this.lblTotalRecords.Text = "0";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsShowPersonInfo,
            this.toolStripSeparator2,
            this.tsLicenseHistory});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(281, 114);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.DarkCyan;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.SystemColors.Control;
            this.btnClose.Image = global::DVDL_Driving_License_Management_WindowsForm.Properties.Resources.close__1_;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(913, 755);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(206, 51);
            this.btnClose.TabIndex = 40;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::DVDL_Driving_License_Management_WindowsForm.Properties.Resources.Driver_Main;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(367, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(440, 283);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // tsShowPersonInfo
            // 
            this.tsShowPersonInfo.BackColor = System.Drawing.Color.DarkSlateGray;
            this.tsShowPersonInfo.Image = global::DVDL_Driving_License_Management_WindowsForm.Properties.Resources.PersonDetails_321;
            this.tsShowPersonInfo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsShowPersonInfo.Name = "tsShowPersonInfo";
            this.tsShowPersonInfo.Size = new System.Drawing.Size(280, 38);
            this.tsShowPersonInfo.Text = "Show Person Info";
            this.tsShowPersonInfo.Click += new System.EventHandler(this.tsShowPersonInfo_Click);
            // 
            // tsLicenseHistory
            // 
            this.tsLicenseHistory.BackColor = System.Drawing.Color.DarkSlateGray;
            this.tsLicenseHistory.Image = global::DVDL_Driving_License_Management_WindowsForm.Properties.Resources.PersonLicenseHistory_321;
            this.tsLicenseHistory.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsLicenseHistory.Name = "tsLicenseHistory";
            this.tsLicenseHistory.Size = new System.Drawing.Size(280, 38);
            this.tsLicenseHistory.Text = "Show Person License History";
            this.tsLicenseHistory.Click += new System.EventHandler(this.tsLicenseHistory_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(277, 6);
            // 
            // frmManageDrivers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(1144, 827);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblTotalRecords);
            this.Controls.Add(this.dgvDriversList);
            this.Controls.Add(this.txbFiltringDrivers);
            this.Controls.Add(this.cmbDriversFiltring);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmManageDrivers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Drivers";
            this.Load += new System.EventHandler(this.frmManageDrivers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDriversList)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txbFiltringDrivers;
        private System.Windows.Forms.ComboBox cmbDriversFiltring;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvDriversList;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTotalRecords;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsLicenseHistory;
        private System.Windows.Forms.ToolStripMenuItem tsShowPersonInfo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    }
}