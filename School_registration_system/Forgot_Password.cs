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
    public partial class frmForgot_Password : Form
    {
        public frmForgot_Password()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-8AKQICV\SQLEXPRESS;Initial Catalog=Student;Integrated Security=True");
        SqlDataAdapter SqlDa = new SqlDataAdapter();
        private void lblPassword_Click(object sender, EventArgs e)
        {

        }

        private void chbShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chbShowPassword.Checked)
            {
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '*';
            }
        }

        private void chbShowPassword2_CheckedChanged(object sender, EventArgs e)
        {
            if (chbShowPassword2.Checked)
            {
                txtConfirmPassword.PasswordChar = '\0';
            }
            else
            {
                txtConfirmPassword.PasswordChar = '*';
            }
        }

        private void lblScoolName_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmLogIn frmLogIn = new frmLogIn();
            frmLogIn.Show();
            this.Hide();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            if(txtPassword.Text == txtConfirmPassword.Text)
            {
                string editdat = "UPDATE Login SET password= '" + txtPassword.Text + "'";
                con.Open();
                SqlCommand cmd = new SqlCommand(editdat,con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Password change Successfull","Success",MessageBoxButtons.OK,MessageBoxIcon.Information);
                txtUserName.Clear();
                txtPassword.Clear();
                txtConfirmPassword.Clear();
            }
            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtUserName.Clear();
            txtPassword.Clear();
            txtConfirmPassword.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult res_exit = MessageBox.Show("Are you sure, You want to Exit?", "Exit?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (res_exit == DialogResult.Yes)
            {
                this.Dispose();
            }
        }
    }
}
