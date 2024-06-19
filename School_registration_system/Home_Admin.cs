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
    public partial class frmHome_Admin : Form
    {
        public frmHome_Admin()
        {
            InitializeComponent();
        }

        private void btnUpdateTeachers_Click(object sender, EventArgs e)
        {
          frmUpdate_Teachers frmUpdate_Teachers = new frmUpdate_Teachers();
          frmUpdate_Teachers.Show();
          this.Close();
        }

        private void Home_Admin_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult res_exit = MessageBox.Show("Are you sure, You want to Exit?", "Exit?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (res_exit == DialogResult.Yes)
            {
                this.Dispose();
            }
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            DialogResult res_logout = MessageBox.Show("Are you sure, You want to Logout?", "Logging Out?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (res_logout == DialogResult.Yes)
            {
                frmLogIn frmLogIn = new frmLogIn();
                frmLogIn.Show();
                this.Hide();
            }
          
        }

        private void btnUpdateStudents_Click(object sender, EventArgs e)
        {
          frmUpdate_Students frmUpdate_Students = new frmUpdate_Students();
            frmUpdate_Students.Show();
            this.Hide();
        }

        private void btnUpdateSubjects_Click(object sender, EventArgs e)
        {
            frmUpdate_Subjects frmUpdate_Subjects = new frmUpdate_Subjects();
            frmUpdate_Subjects.Show();
            this.Hide();
        }

        private void btnGrades_Click(object sender, EventArgs e)
        {
            frmGrades grades = new frmGrades();
            grades.Show();
            this.Hide();
        }
    }
}
