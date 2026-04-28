using DVDL_BusinessLayer;
using DVDL_Driving_License_Management_WindowsForm.Properties;
using DVLD_Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DVDL_BusinessLayer.clsTestType;

namespace DVDL_Driving_License_Management_WindowsForm.Screens.TestAppointments
{
    public partial class frmSchedualTest : Form
    {
        clsTestType.enTestType _TestType;



        enum enMode { AddNew , Update }
        enMode _Mode;
        
        static int Trial =0;

        int _TestAppointmentID = 0;

        float RetakeApplicationFees = 0;

        float TestFees = 0;

        private int _LocalDrivingLicenceApplicationID = 0;

        clsLocalDrivingLicenseApplication _AppointmentsApplication;

        clsTestAppointment _TestAppointment;

        public frmSchedualTest(int LocalDrivingLicenseID,clsTestType.enTestType TestType)
        {
            InitializeComponent();
            _LocalDrivingLicenceApplicationID = LocalDrivingLicenseID;
            _TestType = TestType;
            _TestAppointment = new clsTestAppointment();
            _Mode = enMode.AddNew;
        }

        public frmSchedualTest(int LocalDrivingLicenseID, clsTestType.enTestType TestType,int TestAppointmentID)
        {
            InitializeComponent();
            _LocalDrivingLicenceApplicationID = LocalDrivingLicenseID;
            _TestType = TestType;
            _TestAppointmentID=TestAppointmentID;
            _TestAppointment = clsTestAppointment.Find(_TestAppointmentID);
            _Mode = enMode.Update;
        }


        private void _ResetDefualValues() 
        {
            _AppointmentsApplication = clsLocalDrivingLicenseApplication.Find(_LocalDrivingLicenceApplicationID);

            _SetPictureBoxImage();

            dtpAppointmentDate.MaxDate = DateTime.Now.AddDays(30);
            dtpAppointmentDate.MinDate = DateTime.Now;

             Trial = clsLocalDrivingLicenseApplication.TotalTrialsPerTest(_LocalDrivingLicenceApplicationID, _TestType);

            if (_AppointmentsApplication != null)
            {
                TestFees = clsTestType.Find(_TestType).Fees;
                lblDrivingLicenseAppID.Text = _LocalDrivingLicenceApplicationID.ToString();
                lblDrivingLicenseClass.Text = _AppointmentsApplication.LicenseClass.Name;
                lblFees.Text = TestFees.ToString();
                lblName.Text = _AppointmentsApplication.PersonInfo.GetFullName();
                lblTrial.Text = Trial.ToString();
                lblRetakeTestID.Text = "N/A";

                if (clsLocalDrivingLicenseApplication.DoesAttentedTestType(_LocalDrivingLicenceApplicationID, _TestType))
                {
                    gbRetakeExam.Enabled = false;
                    lblRetakeApplicationFees.Text = "0";
                    lblTotalFees.Text = lblFees.Text;
                }
                else
                {
                    RetakeApplicationFees = clsApplicationType.Find(8).Fees;
                    gbRetakeExam.Enabled = true;
                    lblRetakeApplicationFees.Text = "0";
                    lblTotalFees.Text = (Convert.ToSingle(lblFees.Text) + RetakeApplicationFees).ToString();
                }
            }
            else 
            {
                MessageBox.Show("Error while loading the application data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void _LoadData() 
        {
            if (_TestAppointment.AppoitmentDate < dtpAppointmentDate.MinDate) 
            {
                dtpAppointmentDate.Value = dtpAppointmentDate.MinDate;
                return;
            }

            dtpAppointmentDate.Value = _TestAppointment.AppoitmentDate;

          
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
             
             // if he is here and he didn't pass the exam then he has faild before 
             if (clsLocalDrivingLicenseApplication.DoesAttentedTestType(_LocalDrivingLicenceApplicationID,_TestType))
             {
                 clsApplication RetakeApplication = new clsApplication();
                 RetakeApplication.ApplicationTypeID = 8;
                 RetakeApplication.ApplicantPersonID = _AppointmentsApplication.ApplicantPersonID;
                 RetakeApplication.ApplicationDate = DateTime.Now;
                 RetakeApplication.CreatedByUserID = clsGlobal.CurrentUser.ID;
                 RetakeApplication.ApplicationStatus = clsApplication.enApplicationStatus.New;
                 RetakeApplication.LastStatusDate = DateTime.Now;
                 RetakeApplication.PaidFees = RetakeApplicationFees;

                 if (RetakeApplication.Save()) 
                 {
                     MessageBox.Show("Appointment saved successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                 }
                 else 
                 {
                     MessageBox.Show("Appointment did not save successfully .", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                 }

             }
             else 
             {
                 _TestAppointment.PaidFees = TestFees;
                 _TestAppointment.AppoitmentDate = dtpAppointmentDate.Value;
                 _TestAppointment.CreatedByUserID = clsGlobal.CurrentUser.ID;
                 _TestAppointment.IsLocked = false;
                 _TestAppointment.LocalDrivingLicenseApplicationID = _LocalDrivingLicenceApplicationID;
                 _TestAppointment.TestTypeID = (int)_TestType;

                 if (_TestAppointment.Save()) 
                 {
                     _Mode = enMode.Update;
                     MessageBox.Show("Appointment saved successfully .", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                 }
                 else 
                 {
                     MessageBox.Show("Appointment did not save successfully .", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                     
                 }

             }
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void _SetPictureBoxImage()
        {

            switch (_TestType)
            {
                case clsTestType.enTestType.Vision:
                    pbTestType.Image = Resources.Vision_512;
                    break;
                case clsTestType.enTestType.Written:
                    pbTestType.Image = Resources.Written_Test_512;
                    break;
                case clsTestType.enTestType.Street:
                    pbTestType.Image = Resources.driving_test_512;
                    break;
                default:
                    break;
            }
        }

        private void frmAddNewTestAppointment_Load(object sender, EventArgs e)
        {
            _ResetDefualValues();

            if (_Mode == enMode.Update)
                _LoadData();
        }
    }
}
