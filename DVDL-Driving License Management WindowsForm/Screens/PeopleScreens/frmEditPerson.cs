using DVDL_BusinessLayer;
using DVDL_Driving_License_Management_WindowsForm.User_Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVDL_Driving_License_Management_WindowsForm.Screens.PeopleScreens
{
    public partial class frmEditPerson : Form
    {
        clsPerson Person;

        public frmEditPerson(int PersonID)
        {   
            InitializeComponent();
            Person =  clsPerson.Find(PersonID);
            cntAddPerson2.Person = Person;
            cntAddPerson2.ControlMode = cntAddPerson.enControlMode.Edit;
        }

        private void frmEditPerson_Load_1(object sender, EventArgs e)
        {
            lblPersonID.Text = Person.ID.ToString();
        }

    }
}
