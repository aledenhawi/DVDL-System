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

namespace DVDL_Driving_License_Management_WindowsForm.Screens.Tests
{
    public partial class frmTakeTest : Form
    {
        private clsTestType.enTestType _TestType;

        private int _AppointmentID;

        private clsTest _Test;

        public frmTakeTest(clsTestType.enTestType TestType,int AppointmentID)
        {
            InitializeComponent();
            this._TestType = TestType;
            _AppointmentID = AppointmentID;
        }

        private void frmTakeTest_Load(object sender, EventArgs e)
        {
            ctrScheduledTest1.TestType = _TestType;
            ctrScheduledTest1.LoadData(_AppointmentID);

            if(ctrScheduledTest1.AppointmentID == -1)
                btnSave.Enabled = false;
            else 
                btnSave.Enabled = true;

            if (ctrScheduledTest1.TestID != -1)
            {
                _Test = ctrScheduledTest1.Test;
                rbPass.Checked = (_Test.TestResult);
                rbFail.Enabled = false;
                rbPass.Enabled = false;
                txbNotes.Text = _Test.TestResult.ToString();
            }
            else
                _Test = new clsTest();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            clsTest Test = new clsTest();
            
            Test.TestResult = rbPass.Checked;
            Test.TestAppointmentID = _AppointmentID;
            Test.Notes = txbNotes.Text;
            Test.CreatedByUserID = clsGlobal.CurrentUser.ID;

            if(MessageBox.Show("Are you sure you want to save the test result?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (Test.Save())
                {
                    MessageBox.Show("Test result saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ctrScheduledTest1.lblTestID.Text = Test.TestID.ToString();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Failed to save the test result, please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ctrScheduledTest1_Load(object sender, EventArgs e)
        {

        }
    }
}
