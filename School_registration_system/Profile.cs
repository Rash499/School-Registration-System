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
    public partial class frmProfile : Form
    {
        public frmProfile()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-8AKQICV\SQLEXPRESS;Initial Catalog=Student;Integrated Security=True");
        SqlDataAdapter SqlDa = new SqlDataAdapter();
        private void button1_Click(object sender, EventArgs e)
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

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                string selque = "SELECT * FROM Registration1";
                con.Open();
                SqlCommand cmd = new SqlCommand(selque, con);
                SqlDataReader R = cmd.ExecuteReader();
                while (R.Read())
                {
                    lblDisplayName.Text = R.GetValue(1).ToString();
                    lblDisplayEmail.Text = R.GetValue(2).ToString();
                    lblDisplayPhoneNumber.Text = R.GetValue(7).ToString();
                    lblDisplayBirthday.Text = R.GetValue(3).ToString();

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
