using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace School_registration_system
{
    public partial class frmTeachers : Form
    {
        public frmTeachers()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-8AKQICV\SQLEXPRESS;Initial Catalog=Student;Integrated Security=True");
        SqlDataAdapter SqlDa = new SqlDataAdapter();

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmHomeStudent frmHomeStudent = new frmHomeStudent();  
            frmHomeStudent.Show();
            this.Hide();
        }

        private void picIcon_Click(object sender, EventArgs e)
        {

        }

        private void lblWelcome_Click(object sender, EventArgs e)
        {

        }

        private void frmTeachers_Load(object sender, EventArgs e)
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

        private void lblTeacherID_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string subID = txtTeacherID.Text;
                string selque = "SELECT * FROM Teachers WHERE teacherID= '" + subID + "'";
                con.Open();
                SqlCommand cmd = new SqlCommand(selque, con);
                SqlDataReader R = cmd.ExecuteReader();
                while (R.Read())
                {
                    lblDisplayName.Text = R.GetValue(1).ToString();
                    lblDisplayEmail.Text = R.GetValue(2).ToString();
                    lblDisplaySection.Text = R.GetValue(3).ToString();
                    lblDisplayContactNo.Text = R.GetValue(4).ToString();
                }
                R.Close();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }
    }
}
