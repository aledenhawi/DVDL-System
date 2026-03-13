using DVDL_BusinessLayer;
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

namespace DVDL_Driving_License_Management_WindowsForm
{
    public partial class frmPeople : Form
    {
        DataView PeopleDataView;
        public frmPeople()
        {
            InitializeComponent();
        }

        public async Task RefreshPeopleListAsync()
        {
            DataTable PeopleDataTable = await Task.Run(() => DVDL_BusinessLayer.clsPerson.GetPeopleList());
            dgvPeopleList.DataSource = PeopleDataTable;
            lblTotalRecords.Text = "Records: " + PeopleDataTable.Rows.Count.ToString();
            PeopleDataView = PeopleDataTable.DefaultView;
        }

        private async void frmPeople_Load(object sender, EventArgs e)
        {
            await RefreshPeopleListAsync();
        }

        private void cmbPeopleFiltring_SelectedValueChanged(object sender, EventArgs e)
        {
            if (PeopleDataView == null) return;

            if (cmbPeopleFiltring.SelectedIndex > 0) 
            {
                txbFiltringPeople.Visible = true;
                txbFiltringPeople.Text = string.Empty;
                PeopleDataView.RowFilter = string.Empty;
            }
            else 
            {
                txbFiltringPeople.Visible = false;
                if (PeopleDataView != null)
                    PeopleDataView.RowFilter = string.Empty;
            }
        }

        private void txbFiltringPeople_TextChanged(object sender, EventArgs e)
        {
            if (PeopleDataView == null) return;

            // sanitize single quotes for DataView expressions
            string term = txbFiltringPeople.Text?.Replace("'", "''") ?? string.Empty;

            switch (cmbPeopleFiltring.SelectedIndex)
            {
                case 1: // PersonID (numeric)
                    if (int.TryParse(term, out int id))
                        PeopleDataView.RowFilter = $"PersonID = {id}";
                    else
                        txbFiltringPeople.Text = string.Empty; // reset if not a valid number
                    break;
                case 2: // NationalNo (text)
                    PeopleDataView.RowFilter = $"NationalNo LIKE '%{term}%'";

                    break;
                case 3:
                    PeopleDataView.RowFilter = $"FirstName LIKE '%{term}%'";

                    break;
                case 4:
                    PeopleDataView.RowFilter = $"SecondName LIKE '%{term}%'";

                    break;
                case 5:
                    PeopleDataView.RowFilter = $"ThirdName LIKE '%{term}%'";

                    break;
                case 6:
                    PeopleDataView.RowFilter = $"LastName LIKE '%{term}%'";

                    break;
                case 7:
                    PeopleDataView.RowFilter = $"CountryName LIKE '%{term}%'";

                    break;
                case 8:
                    PeopleDataView.RowFilter = $"Gender LIKE '%{term}%'";

                    break;
                case 9:
                    PeopleDataView.RowFilter = $"Email LIKE '%{term}%'";

                    break;
                case 10:
                    PeopleDataView.RowFilter = $"Phone LIKE '%{term}%'";

                    break;
                default:
                    PeopleDataView.RowFilter = string.Empty;
                    break;
            }
        }

        private async void btnAddNewPerson_Click(object sender, EventArgs e)
        {
            frmAddPerson frmAddPerson = new frmAddPerson();
            frmAddPerson.ShowDialog(this);
            await RefreshPeopleListAsync();
            
        }

        private void txbFiltringPeople_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cmbPeopleFiltring.SelectedIndex == 1) // PersonID should only accept digits
            { 
                if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                {
                e.Handled = true;
                }
            }
        }

        private void tsShowDetails_Click(object sender, EventArgs e)
        {
            frmPersonDetails PersonalDetails = new frmPersonDetails(((int)(dgvPeopleList.CurrentRow.Cells["PersonID"].Value));

        }

        private async void tsAddNew_Click(object sender, EventArgs e)
        {
            if (dgvPeopleList.CurrentRow == null) return;

            frmAddPerson frmAddPerson = new frmAddPerson();
            frmAddPerson.ShowDialog(this);
            await RefreshPeopleListAsync();
        }

        private async void tsEdit_Click(object sender, EventArgs e)
        {
            if(dgvPeopleList.CurrentRow == null) return;

            frmEditPerson frmEditPerson1 = new frmEditPerson((int)(dgvPeopleList.CurrentRow.Cells["PersonID"].Value));
            frmEditPerson1.ShowDialog(this);
            await RefreshPeopleListAsync();
        }

        private async void tsDelete_Click(object sender, EventArgs e)
        {

            int PersonID = (int)(dgvPeopleList.CurrentRow.Cells["PersonID"].Value);

            if(MessageBox.Show("Are you sure to delete person with ID: " + PersonID.ToString() , "Deletion",MessageBoxButtons.YesNo) == DialogResult.Yes) 
            {
                if (clsPerson.DeletePerson(PersonID))
                {
                    MessageBox.Show("Person with ID: " + PersonID.ToString() + " has been deleted successfully.", "Deletion", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    await RefreshPeopleListAsync();
                }
                else 
                {
                     MessageBox.Show("Deletion canceled because person has data linked to it.", "Deletion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }



        }
    }
}
