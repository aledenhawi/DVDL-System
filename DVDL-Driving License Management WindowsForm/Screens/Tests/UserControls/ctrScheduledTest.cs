using DVDL_BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DVDL_BusinessLayer.clsTestType;

namespace DVDL_Driving_License_Management_WindowsForm.Screens.Tests.UserControls
{
    public partial class ctrScheduledTest : UserControl
    {
        private clsTestType.enTestType _TestType;
        public clsTestType.enTestType TestType
        {
            get { return _TestType; }
            set
            {
                _TestType = value;

                switch (value)
                {
                    case clsTestType.enTestType.Vision:
                        pbTestType.Image = Properties.Resources.Vision_512;
                        gbTestDetails.Text = "Vision Test";
                        break;
                    case clsTestType.enTestType.Written:
                        pbTestType.Image = Properties.Resources.Written_Test_512;
                        gbTestDetails.Text = "Written Test";
                        break;
                    case clsTestType.enTestType.Street:
                        pbTestType.Image = Properties.Resources.driving_test_512;
                        gbTestDetails.Text = "Street Test";
                        break;
                    default:
                        break;
                }
            }
        }

        public int AppointmentID;

        public int TestID = -1;

        public clsTest Test;

        public ctrScheduledTest()
        {
            InitializeComponent();
        }

        public void LoadData(int AppointmentID) 
        {
            clsTestAppointment testAppointment = clsTestAppointment.Find(AppointmentID);
            
            if (testAppointment == null)
            {
                MessageBox.Show("Test appointment is not found, please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                AppointmentID = -1;
                return;

            }


            AppointmentID = testAppointment.TestAppointmentID;
            clsLocalDrivingLicenseApplication LocalDrivingLicenseApplication = clsLocalDrivingLicenseApplication.Find(testAppointment.LocalDrivingLicenseApplicationID);

            clsTest Test = clsTest.FindLastTestPerPersonIDAndLicenseClassID(LocalDrivingLicenseApplication.ApplicantPersonID, testAppointment.LocalDrivingLicenseApplicationID, TestType);


            TestID = (Test != null) ? Test.TestAppointmentID : -1;
            this.Test = (Test != null) ? Test : null;

            lblDate.Text = LocalDrivingLicenseApplication.ApplicationDate.ToShortDateString();
            lblDrivingLicenseClass.Text = LocalDrivingLicenseApplication.LicenseClassInfo.Name;
            lblFees.Text = clsTestType.Find(TestType).Fees.ToString();
            lblFullName.Text = LocalDrivingLicenseApplication.PersonInfo.GetFullName();
            lblLocalDrivingLicenseAppID.Text = LocalDrivingLicenseApplication.LocalDrivingLicenseApplicationID.ToString();
            lblTrial.Text = clsLocalDrivingLicenseApplication.TotalTrialsPerTest(LocalDrivingLicenseApplication.LocalDrivingLicenseApplicationID, TestType).ToString();
            lblTestID.Text = "Not Taken Yet";
        }
    }
}
