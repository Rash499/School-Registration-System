using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School_registration_system
{
    public partial class frmHomeStudent : Form
    {
        public frmHomeStudent()
        {
            InitializeComponent();
        }

        private void btnPrograss_Click(object sender, EventArgs e)
        {
            frmPrograss frmPrograss = new frmPrograss();
            frmPrograss.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult res_exit = MessageBox.Show("Are you sure, You want to Exit?", "Exit?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (res_exit == DialogResult.Yes)
            {
                this.Dispose();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            DialogResult res_logout = MessageBox.Show("Are you sure, You want to Logout?", "Logging Out?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (res_logout == DialogResult.Yes)
            {
                    frmLogIn frmLogIn = new frmLogIn();
                    frmLogIn.Show();
                    this.Hide();
            }
            
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            frmProfile profile = new frmProfile();
            profile.Show();
            this.Hide();
        }

        private void btnSubjects_Click(object sender, EventArgs e)
        {
            frmSubjects subjects = new frmSubjects();
            subjects.Show();
            this.Hide();
        }

        private void btnTeachers_Click(object sender, EventArgs e)
        {
            frmTeachers teachers = new frmTeachers();
            teachers.Show();
            this.Hide();
        }

        private void frmHomeStudent_Load(object sender, EventArgs e)
        {

        }
    }
}
