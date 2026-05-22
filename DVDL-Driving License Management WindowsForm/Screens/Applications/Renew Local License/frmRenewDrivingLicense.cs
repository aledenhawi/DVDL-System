using DVDL_BusinessLayer;
using DVLD_Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVDL_Driving_License_Management_WindowsForm.Screens.Licenses.Local_Licenses
{
    public partial class frmRenewDrivingLicense : Form
    {
        private int _NewLicenseID = -1;

        public frmRenewDrivingLicense()
        {
            InitializeComponent();
        }

        private void ctrLicenseInfoWithFilter1_OnLicenseSelected(int obj)
        {
            int LicenseID = obj;

            llblShowlicenseHistory.Enabled = false;
            llblShowNewLicenseInfo.Enabled = false;
            btnRenew.Enabled = false;

            if (LicenseID == -1)
               return;

            // add the license info to the form
            llblShowlicenseHistory.Enabled = true;
            lblOldLicenseID.Text = LicenseID.ToString();
            lblLicenseFees.Text = ctrLicenseInfoWithFilter1.SelectedLicenseInfo.LicenseClassInfo.Fees.ToString();
            lblTotalFees.Text = (Convert.ToSingle(lblLicenseFees.Text) + Convert.ToSingle(lblApplicationFees.Text)).ToString();
            lblExpirationDate.Text = DateTime.Now.AddYears(ctrLicenseInfoWithFilter1.SelectedLicenseInfo.LicenseClassInfo.DefualtValidityLength).ToString("dd/MM/yyyy");
            txbNotes.Text = ctrLicenseInfoWithFilter1.SelectedLicenseInfo.Notes;

            if (!ctrLicenseInfoWithFilter1.SelectedLicenseInfo.IsLicenseExpired()) 
            {
                MessageBox.Show("Selected license is not expired yet. You can only renew expired licenses.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!ctrLicenseInfoWithFilter1.SelectedLicenseInfo.IsActive) 
            {
                MessageBox.Show("Selected license is not active. You can only renew active licenses.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            btnRenew.Enabled = true;
        }

        private void frmRenewDrivingLicense_Load(object sender, EventArgs e)
        {
            ctrLicenseInfoWithFilter1.TxbLicenseIDFocus();
            llblShowlicenseHistory.Enabled = false;
            llblShowNewLicenseInfo.Enabled = false;
            btnRenew.Enabled = false;

            lblApplicationDate.Text = DateTime.Now.ToString("dd/MM/yyyy");
            lblApplicationFees.Text = clsApplicationType.Find((int)clsApplication.enApplicationType.RenewDrivingLicense).Fees.ToString();
            lblCreatedBy.Text = clsGlobal.CurrentUser.Username;
            lblIssueDate.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRenew_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to Renew this License?", "Confirm Renewing", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            clsLicense NewLicense = ctrLicenseInfoWithFilter1.SelectedLicenseInfo.RenewLicense(txbNotes.Text.Trim(),clsGlobal.CurrentUser.ID);

            if (NewLicense != null) 
            {
                MessageBox.Show("License renewed successfully.", "Renewed Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Show the new license info in form
                lblRenewedLicenseID.Text = NewLicense.LicenseID.ToString();
                lblRenewApplicationID.Text = NewLicense.ApplicationID.ToString();
                _NewLicenseID = NewLicense.LicenseID;

                btnRenew.Enabled = false;
                ctrLicenseInfoWithFilter1.FilterEnable = false;
                llblShowNewLicenseInfo.Enabled = true;
            }
            else 
            {
                MessageBox.Show("Error : error ocured while renewing license.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void llblShowNewLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (_NewLicenseID == -1)
                return;

            frmLicenseInfo frm = new frmLicenseInfo(_NewLicenseID);
            frm.ShowDialog();
        }

        private void llblShowlicenseHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowPersonDrivingLicensesHistory frm = new frmShowPersonDrivingLicensesHistory(ctrLicenseInfoWithFilter1.SelectedLicenseInfo.DriverInfo.PersonID);
            frm.ShowDialog();
        }

    }
}
