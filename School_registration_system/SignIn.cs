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
    public partial class frmSignIn : Form
    {
        public frmSignIn()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-8AKQICV\SQLEXPRESS;Initial Catalog=Student;Integrated Security=True");
        SqlDataAdapter SqlDa = new SqlDataAdapter();
        private void btnClear_Click(object sender, EventArgs e)
        {
            DialogResult res_exit = MessageBox.Show("Are you sure, You want to Clear?", "Clear?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (res_exit == DialogResult.Yes)
            {
                txtUserName.Clear();
                txtPassword.Clear();
            }
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
            frmWelcome frmWelcome = new frmWelcome();
            frmWelcome.Show();
            this.Hide();
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

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            bool CheckTextBoxEmpty = false;

            if (String.IsNullOrEmpty(txtPassword.Text))
            {
                CheckTextBoxEmpty = true;
            }
            if (String.IsNullOrEmpty(txtUserName.Text))
            {
                CheckTextBoxEmpty=true;
            }
            if(CheckTextBoxEmpty)
            {

                MessageBox.Show("Every Field requierd!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            try
            {
                string user_name = txtUserName.Text;
                string password = txtPassword.Text; 
                con.Open();
                string selque = "INSERT INTO Login VALUES" + "('"+user_name+"','"+password+"')";
                SqlCommand cmd = new SqlCommand(selque, con);

                int n = cmd.ExecuteNonQuery();
                con.Close();
                Console.WriteLine(n);
                if (n == 1)
                {
                    MessageBox.Show("Successfully Signed in", "Sign in", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtUserName.Clear();
                    txtPassword.Clear();
                    frmHomeStudent frmHomeStudent = new frmHomeStudent();
                    frmHomeStudent.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Failed :(", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
         
        }

        private void lblScoolName_Click(object sender, EventArgs e)
        {

        }
    }
}
