using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace School_registration_system
{
    public partial class frmSubjects : Form
    {
        public frmSubjects()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-8AKQICV\SQLEXPRESS;Initial Catalog=Student;Integrated Security=True");
        SqlDataAdapter SqlDa = new SqlDataAdapter();
        private void Subjects_Load(object sender, EventArgs e)
        {

        }

        private void picIcon_Click(object sender, EventArgs e)
        {

        }

        private void grpSubjects_Enter(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmHomeStudent frmHomeStudent = new frmHomeStudent();
            frmHomeStudent.Show();
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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string subID = txtSubjectID.Text;
                string selque = "SELECT * FROM subjects1 WHERE subjectID= '" + txtSubjectID.Text + "'";
                con.Open();
                SqlCommand cmd = new SqlCommand(selque, con);
                SqlDataReader R = cmd.ExecuteReader();
                while (R.Read())
                {
                    lblDisplayName.Text = R.GetValue(1).ToString();
                    string details = R.GetValue(2).ToString();
                    details = details.Replace("\\n ",Environment.NewLine);
                    lblDisplayDetails.Text = details;
                }
                R.Close();
                con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }
    }
}
