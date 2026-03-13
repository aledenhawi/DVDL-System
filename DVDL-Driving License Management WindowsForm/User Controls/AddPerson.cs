using DVDL_BusinessLayer;
using DVDL_Driving_License_Management_WindowsForm.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace DVDL_Driving_License_Management_WindowsForm.User_Controls
{
    public partial class cntAddPerson : UserControl
    {
        public clsPerson Person = new clsPerson();
        string LastImagePath = string.Empty;

        public enum enControlMode
        {
            Add,
            Edit
        }

        public enControlMode ControlMode;

        public cntAddPerson()
        {  
            InitializeComponent();
        } 

        private void _LoadData()
        {
                // Store the original image path to handle deletion of old image if changed
                LastImagePath = Person.ImagePath;

                txbFirstName.Text = Person.FirstName;
                txbLastName.Text = Person.LastName;
                txbSecondName.Text = Person.SecondName;
                txbThirdName.Text = Person.ThirdName;
                txbNationalNo.Text = Person.NationalNo;
                txbEmail.Text = Person.Email;
                txbPhone.Text = Person.Phone;
                txbAddress.Text = Person.Address;
                dtbDateOfBirth.Value = Person.DateOfBirth;
                cmbCountries.SelectedValue = Person.NationalityCountryID;

                if (!string.IsNullOrEmpty(Person.ImagePath) && File.Exists(Person.ImagePath))
                {
                    using (Image img = Image.FromFile(Person.ImagePath))
                    {
                        pbPersonImage.Image = new Bitmap(img); 
                    }

                    pbPersonImage.BackgroundImage = null;
                    pbPersonImage.SizeMode = PictureBoxSizeMode.Zoom;
                    llblRemove.Visible = true;
                }
                
                if ((byte)Person.Gender == 1)
                    rbFemale.Checked = true;
        }

        private void cntAddPerson_Load(object sender, EventArgs e)
        {
            dtbDateOfBirth.MaxDate = DateTime.Today.AddYears(-18); // Set max date to 18 years ago
            dtbDateOfBirth.Value = dtbDateOfBirth.MaxDate; // Default to 18 years ago
            dtbDateOfBirth.MinDate = DateTime.Today.AddYears(-100); // Set min date to 100 years ago
            cmbCountries.DataSource = clsPerson.GetCountriesList();
            cmbCountries.DisplayMember = "CountryName";
            cmbCountries.ValueMember = "CountryID";
            saveFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

            if (ControlMode == enControlMode.Edit)
                _LoadData();

        }

        private void llblSetImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Person.ImagePath = saveFileDialog1.FileName;

                pbPersonImage.BackgroundImage = null;

                if (pbPersonImage.Image != null)
                {
                    pbPersonImage.Image.Dispose();
                    pbPersonImage.Image = null;
                }

                using (Image img = Image.FromFile(saveFileDialog1.FileName))
                {
                    pbPersonImage.Image = new Bitmap(img); 
                }

                pbPersonImage.SizeMode = PictureBoxSizeMode.Zoom;
                llblRemove.Visible = true;
            }

        }

        private void textBox6_Validating(object sender, CancelEventArgs e)
        {
            if (clsPerson.IsNationalNoExists(txbNationalNo.Text.ToString()))
            {
                e.Cancel = true;
                txbNationalNo.Focus();
                errorProvider1.SetError(txbNationalNo, "This National Number is already exists.");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txbNationalNo, null);
            }
;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

                Person.FirstName = txbFirstName.Text;
                Person.LastName = txbLastName.Text;
                Person.SecondName = txbSecondName.Text;
                Person.ThirdName = txbThirdName.Text;
                Person.NationalNo = txbNationalNo.Text;
                Person.Email = txbEmail.Text;
                Person.Phone = txbPhone.Text;
                Person.Address = txbAddress.Text;
                Person.DateOfBirth = dtbDateOfBirth.Value;
                Person.Address = txbAddress.Text;
                Person.NationalityCountryID = (int)cmbCountries.SelectedValue;
            
            if (rbFemale.Checked)
                Person.Gender = clsPerson.GenderType.Female;
            else Person.Gender = clsPerson.GenderType.Female;
            

            if (Person.Save())
            {
                if(Person.ImagePath != LastImagePath && !string.IsNullOrEmpty(LastImagePath) && File.Exists(LastImagePath))
                {
                    try
                    {
                        File.Delete(LastImagePath);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Failed to Delete Old Image: " + ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }

                MessageBox.Show("Data Saved Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.FindForm().Close();
            }
            else
                MessageBox.Show("Failed to Save Data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.FindForm().Close();
        }

        private void llblRemove_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            if (pbPersonImage.Image != null)
            {
                Image temp = pbPersonImage.Image;
                pbPersonImage.Image = null;
                temp.Dispose();
            }

            pbPersonImage.BackgroundImage = rbFemale.Checked ? Resources.question : Resources.questionPerson;

            Person.ImagePath = "";
            llblRemove.Visible = false;
        }

        private void rbFemale_CheckedChanged(object sender, EventArgs e)
        {
            pbPersonImage.BackgroundImage = Resources.question;

        }

        private void rbMale_CheckedChanged(object sender, EventArgs e)
        {
            pbPersonImage.BackgroundImage = Resources.questionPerson;
        }

        private void NotNull_Validating(object sender, CancelEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (string.IsNullOrEmpty(textBox.Text))
            {
                errorProvider1.SetError(textBox, "Last Name Can't be Empty!");
            }
            else
            {
                errorProvider1.SetError(textBox, null);
            }
        }

        private void txbEmail_Validating(object sender, CancelEventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(txbEmail.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$") && !string.IsNullOrEmpty(txbEmail.Text))
            {
                errorProvider1.SetError(txbEmail, "Invalid Email Format!");
            }
            else 
            {
                errorProvider1.SetError(txbEmail, null);
            }
        }

        private void txbPhone_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txbPhone.Text))
            {
                errorProvider1.SetError(txbPhone, "Phone Number Can't be Empty!");
            }
            else if (!System.Text.RegularExpressions.Regex.IsMatch(txbPhone.Text, @"^\d+$"))
            {
                errorProvider1.SetError(txbPhone, "Phone Number Must Contain Only Digits!");
            }
            else
            {
                errorProvider1.SetError(txbPhone, null);
            }
        }
    }
}
