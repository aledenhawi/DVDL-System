using DVDL_BusinessLayer;
using DVDL_Driving_License_Management_WindowsForm.Screens.Licenses.Local_Licenses;
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

namespace DVDL_Driving_License_Management_WindowsForm.Screens.Licenses.International_Licenses
{
    public partial class frmAddNewInternationalLicense : Form
    {

        private int _InternationalLicenseID = -1;

        public frmAddNewInternationalLicense()
        {
            InitializeComponent();
        }

        private void btnIssue_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure you want to issue this International License?", "Confirm Issue", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            clsInternationalLicense internationalLicense = new clsInternationalLicense();

            internationalLicense.IssuedUsingLocalLicenseID = ctrLicenseInfoWithFilter1.SelectedLicenseInfo.LicenseID;
            internationalLicense.DriverID = ctrLicenseInfoWithFilter1.SelectedLicenseInfo.DriverID;
            internationalLicense.IssueDate = DateTime.Now;
            internationalLicense.ExpirationDate = DateTime.Now.AddYears(1);
            internationalLicense.IsActive = true;
            internationalLicense.CreatedByUserID = clsGlobal.CurrentUser.ID;
            internationalLicense.ApplicationTypeID = (int)clsApplication.enApplicationType.NewInternationalLicense;
            internationalLicense.ApplicantPersonID = ctrLicenseInfoWithFilter1.SelectedLicenseInfo.DriverInfo.PersonID;
            internationalLicense.ApplicationStatus = clsApplication.enApplicationStatus.Completed;
            internationalLicense.PaidFees = clsApplicationType.Find((int)clsApplication.enApplicationType.NewInternationalLicense).Fees;
            
            if(internationalLicense.Save())
            {
                MessageBox.Show("International License issued successfully.","Issued Successfully",MessageBoxButtons.OK,MessageBoxIcon.Information);
                ctrInternationalLicenseApplicartionDetails1.LoadInternationalLicenseInfo(internationalLicense.InternationalLicenseID);
                btnIssue.Enabled = false;
                ctrLicenseInfoWithFilter1.FilterEnable = false;
                llblShowLicenseInfo.Enabled = true;
                _InternationalLicenseID = internationalLicense.InternationalLicenseID;
            }
            else
            {
                MessageBox.Show("Error : error ocured while issuing International License.","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

        }

        private void lblShowLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmInternationalLicenseInfo frm = new frmInternationalLicenseInfo(_InternationalLicenseID);
            frm.ShowDialog();
        }

        private void llblShowLicenseHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowPersonDrivingLicensesHistory frmShowPersonDrivingLicensesHistory = new frmShowPersonDrivingLicensesHistory(ctrLicenseInfoWithFilter1.SelectedLicenseInfo.DriverInfo.PersonID);
            frmShowPersonDrivingLicensesHistory.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ctrLicenseInfoWithFilter1_OnLicenseSelected(int obj)
        {
            int LicenseID = obj;
            clsLicense License = clsLicense.Find(LicenseID);


            if (LicenseID == -1)
                return;

            // check if the license is already used to issue an international license
            int InternationalLicenseID = clsInternationalLicense.GetDriverActiveInternationalLicenseID(License.DriverID);

            if (InternationalLicenseID != -1)
            {
                MessageBox.Show("The driver already has an active international license.", "Warnning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                _InternationalLicenseID = InternationalLicenseID;
                btnIssue.Enabled = false;
                llblShowLicenseInfo.Enabled = true;
                return;
            }

            if (License.IsActive == false)
            {
                MessageBox.Show("The selected license is not active. Please select an active license.", "Inactive License", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ctrLicenseInfoWithFilter1.TxbLicenseIDFocus();
                btnIssue.Enabled = false;
                return;

            }

            if(License.LicenseClass != 3)
            {
                MessageBox.Show("The selected license class is not valid for an international license. Please select a license with class orandiry driving license"
                    , "Invalid License Class", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ctrLicenseInfoWithFilter1.TxbLicenseIDFocus();
                btnIssue.Enabled = false;
                return;
            }

            ctrInternationalLicenseApplicartionDetails1.LocalLicenseID = LicenseID;
            btnIssue.Enabled = true;
            llblShowLicenseHistory.Enabled = true;
        }

        private void frmAddNewInternationalLicense_Load(object sender, EventArgs e)
        {
            ctrLicenseInfoWithFilter1.FilterEnable = true;
            llblShowLicenseInfo.Enabled = false;
            llblShowLicenseHistory.Enabled = false;
            btnIssue.Enabled = false;
            ctrInternationalLicenseApplicartionDetails1.ResetDefualtValues();
        }

    }
}
