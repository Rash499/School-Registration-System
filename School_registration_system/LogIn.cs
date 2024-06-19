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
    public partial class frmLogIn : Form
    {
        public frmLogIn()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-8AKQICV\SQLEXPRESS;Initial Catalog=Student;Integrated Security=True");
        SqlDataAdapter SqlDa = new SqlDataAdapter();
        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmLogIn_Load(object sender, EventArgs e)
        {

        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {

        }

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
            DialogResult res_exit = MessageBox.Show("Are you sure, You want to Exit?","Exit?",MessageBoxButtons.YesNo,MessageBoxIcon.Question);

            if(res_exit == DialogResult.Yes)
            {
                this.Dispose();
            }

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmWelcome wel = new frmWelcome();
            wel.Show();
            this.Hide();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            string email = txtUserName.Text;
            string password = txtPassword.Text;
            bool CheckTextBoxEmpty = false;

            if (String.IsNullOrEmpty(txtUserName.Text))
            {
                CheckTextBoxEmpty = true;
            }
            if(String.IsNullOrEmpty(txtPassword.Text))
            {
                CheckTextBoxEmpty = true;
            }

            if (CheckTextBoxEmpty)
            {
                MessageBox.Show("Every Field requierd!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if(email =="Admin@123" &&  password == "1234")
            {
                MessageBox.Show("Login Success! :)","Logged in",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
                frmHome_Admin frmHome_Admin = new frmHome_Admin();
                frmHome_Admin.Show();
                this.Hide();
            }
            else
            {
                if (email == "Rashmika@123" && password == "Rashmika")
                {
                    MessageBox.Show("Login Success! :)", "Logged in", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    frmHomeStudent frmHomeStudent = new frmHomeStudent();
                    frmHomeStudent.Show();
                    this.Hide();
                }
                 
                
                try
                {
                        con.Open();
                        string selque = "SELECT * FROM Login WHERE (username = @username) and  (password = @password) ";
                        SqlCommand cmd = new SqlCommand(selque, con);
                        cmd.Parameters.AddWithValue("@username", txtUserName.Text);
                        cmd.Parameters.AddWithValue("@password", txtPassword.Text);
                        SqlDataReader rdr = cmd.ExecuteReader();
                        int count = 0;
                        while (rdr.Read())
                        {
                            count++;
                        }
                        con.Close();

                        if (count == 1)
                        {
                            MessageBox.Show("Login Success! :)", "Logged in", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            frmHomeStudent frmHomeStudent = new frmHomeStudent();
                            frmHomeStudent.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Login Failed! :(", "Log in Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                }
                
            }
           

        }

        private void groupBox1_Enter(object sender, EventArgs e)
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

        private void btnForgotPassword_Click(object sender, EventArgs e)
        {
            frmForgot_Password fb = new frmForgot_Password();
            fb.Show();
            this.Hide();

        }
    }
}
