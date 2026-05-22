using DVDL_BusinessLayer;
using DVDL_Driving_License_Management_WindowsForm.Screens.Licenses.International_Licenses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVDL_Driving_License_Management_WindowsForm.Screens.Licenses.Local_Licenses.Controls
{
    public partial class ctrDriverLicenses : UserControl
    {
        private int _DriverID;

        private int _PersonID;

        private clsDriver _Driver;

        private DataTable _dtDriverLocalLicensesHistory = null;
        private DataTable _dtDriverInternationalLicensesHistory = null;

        public ctrDriverLicenses()
        {
            InitializeComponent();
        }

        private void _LoadDriverLocalLicenses()
        {
            _dtDriverLocalLicensesHistory = clsDriver.GetDriverLicenses(_DriverID);

            dgvLocalLicensesHistory.DataSource = _dtDriverLocalLicensesHistory;
       

            if(dgvLocalLicensesHistory.Rows.Count > 0)
            {
                dgvLocalLicensesHistory.Columns[0].HeaderText = "lic.ID";
                dgvLocalLicensesHistory.Columns[0].Width = 130;

                dgvLocalLicensesHistory.Columns[1].HeaderText = "App.ID";
                dgvLocalLicensesHistory.Columns[1].Width = 130;

                dgvLocalLicensesHistory.Columns[2].HeaderText = "Class Name";
                dgvLocalLicensesHistory.Columns[2].Width = 280;

                dgvLocalLicensesHistory.Columns[3].HeaderText = "Issue Date";
                dgvLocalLicensesHistory.Columns[3].Width = 200;

                dgvLocalLicensesHistory.Columns[4].HeaderText = "Expiration Date";
                dgvLocalLicensesHistory.Columns[4].Width = 200;

                dgvLocalLicensesHistory.Columns[5].HeaderText = "Is Active";
                dgvLocalLicensesHistory.Columns[5].Width = 120;

                lblTotalRecords.Text = _dtDriverLocalLicensesHistory.Rows.Count.ToString();

            }
        }

        private void _LoadDriverInternationalLicenses()
        {
            _dtDriverInternationalLicensesHistory = clsInternationalLicense.GetDriverInternationalLicense(_DriverID);

            dgvInternationalLicensesHistory.DataSource = _dtDriverInternationalLicensesHistory;

            if(dgvInternationalLicensesHistory.Columns.Count > 0) 
            {
                dgvInternationalLicensesHistory.Columns[0].HeaderText = "Int.License.ID";
                dgvInternationalLicensesHistory.Columns[0].Width = 160;

                dgvInternationalLicensesHistory.Columns[1].HeaderText = "Application ID";
                dgvInternationalLicensesHistory.Columns[1].Width = 130;

                dgvInternationalLicensesHistory.Columns[2].HeaderText = "L.License ID";
                dgvInternationalLicensesHistory.Columns[2].Width = 130;

                dgvInternationalLicensesHistory.Columns[3].HeaderText = "Issue Date";
                dgvInternationalLicensesHistory.Columns[3].Width = 180;

                dgvInternationalLicensesHistory.Columns[4].HeaderText = "Expiration Date";
                dgvInternationalLicensesHistory.Columns[4].Width = 180;

                dgvInternationalLicensesHistory.Columns[5].HeaderText = "Is Active";
                dgvInternationalLicensesHistory.Columns[5].Width = 120;

                lblTotalInternationalRecords.Text = _dtDriverInternationalLicensesHistory.Rows.Count.ToString();

            }
        }

        public void LoadInfo(int DriverID)
        {
            _Driver = clsDriver.Find(DriverID);
            _DriverID = DriverID;

            if(_Driver == null)
            {
                MessageBox.Show($"There is no driver with id = {DriverID}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _LoadDriverLocalLicenses();
            _LoadDriverInternationalLicenses();
        }

        public void LoadInfoByPersonID(int PersonID)
        {
            _PersonID = PersonID;
            _Driver = clsDriver.FindByPersonID(PersonID);

            if (_Driver == null)
            {
                MessageBox.Show($"There is no driver linked with person id = {PersonID}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _DriverID = _Driver.DriverID;

            _LoadDriverLocalLicenses();
            _LoadDriverInternationalLicenses();
        }

        public void Clear() 
        {
            _dtDriverInternationalLicensesHistory.Clear();
            _dtDriverLocalLicensesHistory.Clear();
        }
        private void tsShowLocalLicenseInfo_Click(object sender, EventArgs e)
        {
            frmLicenseInfo licenseInfo = new frmLicenseInfo(Convert.ToInt32(dgvLocalLicensesHistory.CurrentRow.Cells[0].Value));
            licenseInfo.ShowDialog();
        }

        private void tsShowInternationalLicenseInfo_Click(object sender, EventArgs e)
        {
            frmInternationalLicenseInfo frm = new frmInternationalLicenseInfo(Convert.ToInt32(dgvInternationalLicensesHistory.CurrentRow.Cells[0].Value));
        }
    }
}
