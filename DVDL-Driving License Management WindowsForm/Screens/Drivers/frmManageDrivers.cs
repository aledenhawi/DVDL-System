using DVDL_BusinessLayer;
using DVDL_Driving_License_Management_WindowsForm.Screens.Licenses;
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

namespace DVDL_Driving_License_Management_WindowsForm.Screens.Drivers
{
    public partial class frmManageDrivers : Form
    {
        DataTable DriversTable = null;

        public frmManageDrivers()
        {
            InitializeComponent();
        }

        private void frmManageDrivers_Load(object sender, EventArgs e)
        {
            DriversTable = clsDriver.GetAllDrivers();
            dgvDriversList.DataSource = DriversTable;
            cmbDriversFiltring.SelectedIndex = 0;

            if (dgvDriversList.Rows.Count > 0)
            {
                dgvDriversList.Columns["PersonID"].HeaderText = "Person ID";
                dgvDriversList.Columns["PersonID"].Width = 110;

                dgvDriversList.Columns["DriverID"].HeaderText = "Driver ID";
                dgvDriversList.Columns["DriverID"].Width = 120;

                dgvDriversList.Columns["NationalNo"].HeaderText = "National No.";
                dgvDriversList.Columns["NationalNo"].Width = 120;

                dgvDriversList.Columns["FullName"].HeaderText = "Full Name";
                dgvDriversList.Columns["FullName"].Width = 380;

                dgvDriversList.Columns["CreatedDate"].HeaderText = "Date";
                dgvDriversList.Columns["CreatedDate"].Width = 170;

                dgvDriversList.Columns["NumberOfActiveLicenses"].HeaderText = "Active Licenses";
                dgvDriversList.Columns["NumberOfActiveLicenses"].Width = 150;

            }
        }

        private void txbFiltringDrivers_TextChanged(object sender, EventArgs e)
        {
            if (DriversTable == null) return;

            // sanitize single quotes for DataView expressions
            string term = txbFiltringDrivers.Text?.Replace("'", "''") ?? string.Empty;
            string FilterColumn = default;

            switch (cmbDriversFiltring.Text)
            {
                case "None":
                    FilterColumn = "";
                    break;
                case "Person ID":
                    FilterColumn = "PersonID";
                    break;
                case "National No.":
                    FilterColumn = "NationalNo";
                    break;
                case "Driver ID":
                    FilterColumn = "DriverID";
                    break;
                case "Full Name":
                    FilterColumn = "FullName";
                    break;
                case "Active Licenses":
                    FilterColumn = "NumberOfActiveLicenses";
                    break;
                default:
                    break;
            }

            if (txbFiltringDrivers.Text == "")
            {
                DriversTable.DefaultView.RowFilter = "";
                lblTotalRecords.Text = dgvDriversList.Rows.Count.ToString();
                return;
            }

            if (FilterColumn == "PersonID" || FilterColumn == "DriverID" || FilterColumn == "NumberOfActiveLicenses")
            {
                DriversTable.DefaultView.RowFilter = $"{FilterColumn} = {term}";
            }
            else
            {
                DriversTable.DefaultView.RowFilter = $"{FilterColumn} LIKE '{term}%'";
            }

            lblTotalRecords.Text = dgvDriversList.Rows.Count.ToString();
        }


        private void cmbDriversFiltring_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DriversTable == null) return;


            txbFiltringDrivers.Visible = (cmbDriversFiltring.Text == "None") ? false : true;

            if (txbFiltringDrivers.Visible)
            {
                txbFiltringDrivers.Text = string.Empty;
                txbFiltringDrivers.Focus();
            }
        }

        private void txbFiltringDrivers_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cmbDriversFiltring.SelectedIndex == 1 || cmbDriversFiltring.SelectedIndex == 2
                || cmbDriversFiltring.SelectedIndex == 5) // ActiveLicenses & DriverID &PersonID should only accept digits
            {
                if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsShowPersonInfo_Click(object sender, EventArgs e)
        {
            frmPersonDetails PersonDetails1 = new frmPersonDetails((int)(dgvDriversList.CurrentRow.Cells["PersonID"].Value));
            PersonDetails1.ShowDialog();
        }

        private void tsLicenseHistory_Click(object sender, EventArgs e)
        {
            frmShowPersonDrivingLicensesHistory showPersonDrivingLicensesHistory = new frmShowPersonDrivingLicensesHistory((int)(dgvDriversList.CurrentRow.Cells["PersonID"].Value));
            showPersonDrivingLicensesHistory.ShowDialog();
        }
    }
}
