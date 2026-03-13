namespace DVDL_Driving_License_Management_WindowsForm.Screens.PeopleScreens
{
    partial class frmAddPerson
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
            this.cntAddPerson1 = new DVDL_Driving_License_Management_WindowsForm.User_Controls.cntAddPerson();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cntAddPerson1
            // 
            this.cntAddPerson1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.cntAddPerson1.Location = new System.Drawing.Point(63, 113);
            this.cntAddPerson1.Name = "cntAddPerson1";
            this.cntAddPerson1.Size = new System.Drawing.Size(799, 310);
            this.cntAddPerson1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(261, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(367, 55);
            this.label1.TabIndex = 1;
            this.label1.Text = "Add New Person";
            // 
            // frmAddPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(942, 433);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cntAddPerson1);
            this.Name = "frmAddPerson";
            this.Text = "Add Person";
            this.Load += new System.EventHandler(this.frmAddPerson_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private User_Controls.cntAddPerson cntAddPerson1;
        private System.Windows.Forms.Label label1;
    }
}