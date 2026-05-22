using DVDL_BusinessLayer;
using DVDL_Driving_License_Management_WindowsForm.Screens.Licenses;
using DVDL_Driving_License_Management_WindowsForm.Screens.Licenses.International_Licenses;
using DVDL_Driving_License_Management_WindowsForm.Screens.Licenses.Local_Licenses;
using DVDL_Driving_License_Management_WindowsForm.Screens.PeopleScreens;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVDL_Driving_License_Management_WindowsForm.Screens.Applications.Internatinoal_License
{
    public partial class frmListInt_LicenseApplicatrions : Form
    {

        private static DataTable InternationalLicenses = DVDL_BusinessLayer.clsInternationalLicense.GetAllInternationalLicenses();

        public frmListInt_LicenseApplicatrions()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAddNewInternationalLicenseApplication_Click(object sender, EventArgs e)
        {
            frmAddNewInternationalLicense AddNewInternationalLicense = new frmAddNewInternationalLicense();
            AddNewInternationalLicense.ShowDialog();
            frmListInternationalLicenseApplicatrions_Load(null, null);
        }

        private void frmListInternationalLicenseApplicatrions_Load(object sender, EventArgs e)
        {
            dgvInternationalLicenseApplications.DataSource = InternationalLicenses;
            cmbInternationalLicenseApplicationsFiltring.SelectedIndex = 0;

            lblTotalRecords.Text = InternationalLicenses.Rows.Count.ToString();

            if (dgvInternationalLicenseApplications.Rows.Count > 0)
            {
                dgvInternationalLicenseApplications.Columns["InternationalLicenseID"].HeaderText = "Int.License ID";
                dgvInternationalLicenseApplications.Columns["InternationalLicenseID"].Width = 110;

                dgvInternationalLicenseApplications.Columns["ApplicationID"].HeaderText = "Application ID";
                dgvInternationalLicenseApplications.Columns["ApplicationID"].Width = 120;

                dgvInternationalLicenseApplications.Columns["DriverID"].HeaderText = "Driver ID";
                dgvInternationalLicenseApplications.Columns["DriverID"].Width = 120;

                dgvInternationalLicenseApplications.Columns["IssuedUsingLocalLicenseID"].HeaderText = "L.License ID";
                dgvInternationalLicenseApplications.Columns["IssuedUsingLocalLicenseID"].Width = 120;

                dgvInternationalLicenseApplications.Columns["IssueDate"].HeaderText = "Issue Date";
                dgvInternationalLicenseApplications.Columns["IssueDate"].Width = 200;

                dgvInternationalLicenseApplications.Columns["ExpirationDate"].HeaderText = "Expiration Date";
                dgvInternationalLicenseApplications.Columns["ExpirationDate"].Width = 200;

                dgvInternationalLicenseApplications.Columns["IsActive"].HeaderText = "Is Active";
                dgvInternationalLicenseApplications.Columns["IsActive"].Width = 120;

            }
        }

        private void cmbInternationalLicenseApplicationsFiltring_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (InternationalLicenses == null) return;


            txbFiltringIntLicenseApplications.Visible = (cmbInternationalLicenseApplicationsFiltring.Text == "None" 
                || cmbInternationalLicenseApplicationsFiltring.Text == "Is Active") ? false : true;

            cmbIsActive.Visible = (cmbInternationalLicenseApplicationsFiltring.Text == "Is Active") ? true : false;

            if (txbFiltringIntLicenseApplications.Visible)
            {
                txbFiltringIntLicenseApplications.Text = string.Empty;
                txbFiltringIntLicenseApplications.Focus();
            }
        }

        private void txbFiltringIntLicenseApplications_TextChanged(object sender, EventArgs e)
        {

            if (InternationalLicenses == null) return;

            // sanitize single quotes for DataView expressions
            string term = txbFiltringIntLicenseApplications.Text?.Replace("'", "''") ?? string.Empty;
            string FilterColumn = default;

            switch (cmbInternationalLicenseApplicationsFiltring.Text)
            {
                case "None":
                    FilterColumn = "";
                    break;
                case "Int.License ID":
                    FilterColumn = "InternationalLicenseID";
                    break;
                case "Application ID":
                    FilterColumn = "ApplicationID";
                    break;
                case "Driver ID":
                    FilterColumn = "DriverID";
                    break;
                case "L.License ID":
                    FilterColumn = "IssuedUsingLocalLicenseID";
                    break;
                case "Is Active":
                    FilterColumn = "IsActive";
                    break;
                default:
                    break;
            }

            if (txbFiltringIntLicenseApplications.Text == "")
            {
                InternationalLicenses.DefaultView.RowFilter = "";
                lblTotalRecords.Text = dgvInternationalLicenseApplications.Rows.Count.ToString();
                return;
            }


            InternationalLicenses.DefaultView.RowFilter = $"{FilterColumn} = {term}";

            lblTotalRecords.Text = dgvInternationalLicenseApplications.Rows.Count.ToString();

        }

        private void txbFiltringIntLicenseApplications_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void cmbIsActive_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbIsActive.Text)
            {
                case "All":
                    InternationalLicenses.DefaultView.RowFilter = "";
                    lblTotalRecords.Text = dgvInternationalLicenseApplications.Rows.Count.ToString();
                    return;
                case "Yes":
                    InternationalLicenses.DefaultView.RowFilter = $"IsActive = 1";
                    lblTotalRecords.Text = dgvInternationalLicenseApplications.Rows.Count.ToString();
                    break;
                case "No":
                    InternationalLicenses.DefaultView.RowFilter = $"IsActive = 0";
                    lblTotalRecords.Text = dgvInternationalLicenseApplications.Rows.Count.ToString();
                    break;
                default:
                    break;
            }
        }

        private void cmbIsActive_VisibleChanged(object sender, EventArgs e)
        {
            cmbIsActive.SelectedIndex = 0;
        }

        private void tsShowPersonLicensesHistory_Click(object sender, EventArgs e)
        {
            clsDriver driver = DVDL_BusinessLayer.clsDriver.Find((int)dgvInternationalLicenseApplications.CurrentRow.Cells["DriverID"].Value);
            frmShowPersonDrivingLicensesHistory personDrivingLicensesHistory = new frmShowPersonDrivingLicensesHistory(driver.PersonID);
            personDrivingLicensesHistory.ShowDialog();
        }

        private void tsShowLicenseDetails_Click(object sender, EventArgs e)
        {
            frmLicenseInfo licenseInfo = new frmLicenseInfo((int)dgvInternationalLicenseApplications.CurrentRow.Cells["IssuedUsingLocalLicenseID"].Value);
            licenseInfo.ShowDialog();
        }

        private void tsShowPersonDetails_Click(object sender, EventArgs e)
        {
            clsDriver driver = DVDL_BusinessLayer.clsDriver.Find((int)dgvInternationalLicenseApplications.CurrentRow.Cells["DriverID"].Value);
            frmPersonDetails personDetails = new frmPersonDetails(driver.PersonID);
            personDetails.ShowDialog();
        }
    }
}
