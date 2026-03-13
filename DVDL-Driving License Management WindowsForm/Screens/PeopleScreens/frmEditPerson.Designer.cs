namespace DVDL_Driving_License_Management_WindowsForm.Screens.PeopleScreens
{
    partial class frmEditPerson
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblPersonID = new System.Windows.Forms.Label();
            this.cntAddPerson2 = new DVDL_Driving_License_Management_WindowsForm.User_Controls.cntAddPerson();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Green;
            this.label3.Location = new System.Drawing.Point(267, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(404, 68);
            this.label3.TabIndex = 1;
            this.label3.Text = "Update Person";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label4.Location = new System.Drawing.Point(28, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 24);
            this.label4.TabIndex = 2;
            this.label4.Text = "Person ID :";
            // 
            // lblPersonID
            // 
            this.lblPersonID.AutoSize = true;
            this.lblPersonID.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lblPersonID.Location = new System.Drawing.Point(135, 132);
            this.lblPersonID.Name = "lblPersonID";
            this.lblPersonID.Size = new System.Drawing.Size(21, 24);
            this.lblPersonID.TabIndex = 4;
            this.lblPersonID.Text = "0";
            // 
            // cntAddPerson2
            // 
            this.cntAddPerson2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.cntAddPerson2.Location = new System.Drawing.Point(23, 160);
            this.cntAddPerson2.Margin = new System.Windows.Forms.Padding(4);
            this.cntAddPerson2.Name = "cntAddPerson2";
            this.cntAddPerson2.Size = new System.Drawing.Size(913, 381);
            this.cntAddPerson2.TabIndex = 5;
            // 
            // frmEditPerson
            // 
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(981, 548);
            this.Controls.Add(this.cntAddPerson2);
            this.Controls.Add(this.lblPersonID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Name = "frmEditPerson";
            this.Load += new System.EventHandler(this.frmEditPerson_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private User_Controls.cntAddPerson cntAddPerson1;
        private System.Windows.Forms.Label lblPersonID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private User_Controls.cntAddPerson cntAddPerson2;
    }
}