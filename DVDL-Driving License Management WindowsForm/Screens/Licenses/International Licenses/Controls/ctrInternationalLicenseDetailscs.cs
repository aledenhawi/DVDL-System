using DVDL_BusinessLayer;
using DVDL_Driving_License_Management_WindowsForm.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace DVDL_Driving_License_Management_WindowsForm.Screens.Licenses.International_Licenses.Controls
{
    public partial class ctrInternationalLicenseDetailscs : UserControl
    {
        private int _InternationalLicenseID;
        private clsInternationalLicense _InternationalLicense;

        public int LicenseID { get => _InternationalLicenseID; }

        public clsInternationalLicense SelectedLicenseInfo { get => _InternationalLicense; }

        public ctrInternationalLicenseDetailscs()
        {
            InitializeComponent();
        }

        private void _LoadPersonImage()
        {

            string ImagePath = _InternationalLicense.DriverInfo.PersonInfo.ImagePath;
            if (!String.IsNullOrEmpty(ImagePath))
            {
                if (File.Exists(ImagePath))
                {
                    pbPersonPicture.ImageLocation = ImagePath;
                    return;
                }
                else
                    MessageBox.Show("Person image not found, showing default image", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            pbPersonPicture.Image = (_InternationalLicense.DriverInfo.PersonInfo.Gender == clsPerson.GenderType.Male) ? Resources.Male : Resources.Female;
        }

        public void LoadInfo(int InternationalLicenseID)
        {
            _InternationalLicenseID = InternationalLicenseID;
            _InternationalLicense = clsInternationalLicense.Find(InternationalLicenseID);

            if (_InternationalLicense == null)
            {
                MessageBox.Show("License not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _InternationalLicenseID = -1;
                return;
            }

            lblApplicationID.Text = _InternationalLicense.ApplicationID.ToString();
            lblDateOfBirth.Text = _InternationalLicense.DriverInfo.PersonInfo.DateOfBirth.ToShortDateString();
            lblDriverID.Text = _InternationalLicense.DriverID.ToString();
            lblGender.Text = _InternationalLicense.DriverInfo.PersonInfo.Gender.ToString();
            lblIsActive.Text = _InternationalLicense.IsActive ? "Yes" : "No";
            lblExpirationDate.Text = _InternationalLicense.ExpirationDate.ToShortDateString();
            lblIssueDate.Text = _InternationalLicense.IssueDate.ToShortDateString();
            lblName.Text = _InternationalLicense.DriverInfo.PersonInfo.GetFullName();
            lblInternationalLicenseID.Text = _InternationalLicense.InternationalLicenseID.ToString();
            lblNationalNo.Text = _InternationalLicense.DriverInfo.PersonInfo.NationalNo;
            lblLicenseID.Text = _InternationalLicense.IssuedUsingLocalLicenseID.ToString();

            _LoadPersonImage();
        }
    }
}
