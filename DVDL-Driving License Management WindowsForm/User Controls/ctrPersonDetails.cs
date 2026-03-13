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

namespace DVDL_Driving_License_Management_WindowsForm.User_Controls
{
    public partial class ctrPersonDetails : UserControl
    {
        public clsPerson person = new clsPerson();

        public ctrPersonDetails()
        {
            InitializeComponent();
        }

        private void ctrPersonDetails_Load(object sender, EventArgs e)
        {
            
        }
    }
}
