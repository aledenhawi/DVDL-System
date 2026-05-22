namespace DVDL_Driving_License_Management_WindowsForm
{
    partial class frmTEst
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
            this.ctrInternationalLicenseApplicartionDetails1 = new DVDL_Driving_License_Management_WindowsForm.Screens.Applications.Controls.ctrInternationalLicenseApplicartionDetails();
            this.SuspendLayout();
            // 
            // ctrInternationalLicenseApplicartionDetails1
            // 
            this.ctrInternationalLicenseApplicartionDetails1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ctrInternationalLicenseApplicartionDetails1.LocalLicenseID = 0;
            this.ctrInternationalLicenseApplicartionDetails1.Location = new System.Drawing.Point(12, 204);
            this.ctrInternationalLicenseApplicartionDetails1.Name = "ctrInternationalLicenseApplicartionDetails1";
            this.ctrInternationalLicenseApplicartionDetails1.Size = new System.Drawing.Size(1087, 266);
            this.ctrInternationalLicenseApplicartionDetails1.TabIndex = 0;
            // 
            // frmTEst
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1137, 691);
            this.Controls.Add(this.ctrInternationalLicenseApplicartionDetails1);
            this.Name = "frmTEst";
            this.Text = "frmTEst";
            this.Load += new System.EventHandler(this.frmTEst_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Screens.Applications.Controls.ctrInternationalLicenseApplicartionDetails ctrInternationalLicenseApplicartionDetails1;
    }
}