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
using System.Drawing.Text;

namespace School_registration_system
{
    public partial class frmUpdate_Students : Form
    {
        public frmUpdate_Students()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-8AKQICV\SQLEXPRESS;Initial Catalog=Student;Integrated Security=True");
        SqlDataAdapter sqlda = new SqlDataAdapter();

   

        private void clearForm()
        {
            
            txtFirstName.Clear();
            txtLastName.Clear();
            this.dateTimePicker1.Text = "";
            rdoMale.Checked = false;
            rdoFemale.Checked = false;
            txtAddress.Clear();
            txtEmail.Clear();
            txtMobileNo.Clear();
            txtHomeNo.Clear();
            txtParentName.Clear();
            txtNIC.Clear();
            txtContactNo.Clear();
        }
        private void Update_Students_Load(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmHome_Admin frmHome_Admin = new frmHome_Admin();
            frmHome_Admin.Show();
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

        private void btnRegister_Click(object sender, EventArgs e)
        {
            bool CheckTextBoxEmpty = false;
            bool CheckPhoneNumberLength = false;

            if (String.IsNullOrEmpty(txtFirstName.Text))
            {
               
                CheckTextBoxEmpty = true;
            }
            if (String.IsNullOrEmpty(txtLastName.Text))
            {
               
                CheckTextBoxEmpty = true;
            }
            if (String.IsNullOrEmpty(txtAddress.Text))
            {
               
                CheckTextBoxEmpty = true;
            }
            if (String.IsNullOrEmpty(txtEmail.Text))
            {
              
                CheckTextBoxEmpty = true;
            }
            if (txtMobileNo.Text.Length == 0)
            {
               
                CheckTextBoxEmpty = true;
            }
            if (txtHomeNo.Text.Length == 0)
            {
               
                CheckTextBoxEmpty = true;
            }
            if (String.IsNullOrEmpty(txtParentName.Text))
            {
               
                CheckTextBoxEmpty = true;
            }
            if (txtNIC.Text.Length == 0)
            {
              
                CheckTextBoxEmpty = true;
            }
            if (txtContactNo.Text.Length == 0)
            {
               
                CheckTextBoxEmpty = true;
            }
            if (!rdoMale.Checked && !rdoFemale.Checked)
            {
                CheckTextBoxEmpty = true;
            }
           
            if (CheckTextBoxEmpty)
            {
                MessageBox.Show("Every Field requierd!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            try
            {
                int input1 = int.Parse(txtMobileNo.Text);
                int input2 = int.Parse(txtHomeNo.Text);
                int input3 = int.Parse(txtContactNo.Text);
                
            }
            catch 
            {
                MessageBox.Show("Enter valid Datatype","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            
            if(!(txtMobileNo.Text.Length == 10))
            {
                CheckPhoneNumberLength = true;
            }
            if(!(txtHomeNo.Text.Length == 10))
            {
                CheckPhoneNumberLength = true;
            }
            if(!(txtContactNo.Text.Length == 10))
            {
                CheckPhoneNumberLength = true;
            }
            if (CheckPhoneNumberLength)
            {
                MessageBox.Show("Enter valid Number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);       
            }
            //if(!(txtNIC.Text.Length == 12))
            //{
            //    MessageBox.Show("Enter valid NIC number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            

            string firstName = txtFirstName.Text;
            string lastName = txtLastName.Text;
            DateTime dob = this.dateTimePicker1.Value.Date;
            string gender = "";
            bool isChecked = rdoMale.Checked;
            if (isChecked)
            {
                gender = rdoMale.Text; 
            }
            else
            {
                gender = rdoFemale.Text;
            }
            string address = txtAddress.Text;
            string email = txtEmail.Text;
            int mobileNo = int.Parse(txtMobileNo.Text);
            int homeNo = int.Parse(txtHomeNo.Text);
            string parent = txtParentName.Text;
            string nic = (txtNIC.Text);
            int contactNo = int.Parse(txtContactNo.Text);
            try
            {
                con.Open();
                string seique = "INSERT INTO Registration1 VALUES" + "('" + firstName + " ',' " + lastName + " ',' " + dob + " ',' " + gender + " ',' " + address + " ',' " + email + " ',' " + mobileNo + " ',' " + homeNo + " ',' " + parent + " ',' " + nic + " ',' " + contactNo + "')";
                SqlCommand cmd = new SqlCommand(seique, con);

                int n = cmd.ExecuteNonQuery();
                con.Close();
                Console.WriteLine(n);
                if (n == 1)
                {
                    MessageBox.Show("Successfully Registered!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clearForm();
                }
                else
                {
                    MessageBox.Show("Registration Failed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearForm();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string editData = "UPDATE Registration1 SET firstName = '" + txtFirstName.Text + "', lastName = '" + txtLastName.Text + "' , dateOfBirth = '" + dateTimePicker1.Value.Date + "' , gender = '" +(rdoMale.Checked ? "Male":"Female")+ "' , address = '" + txtAddress.Text + "' , email = '" + txtEmail.Text + "' , mobilePhone = '" + int.Parse(txtMobileNo.Text) + "' , homePhone = '" + int.Parse(txtHomeNo.Text) + "' , parentName = '" + txtParentName.Text + "' , nic = '" + txtNIC.Text + "' , contactNo = '" + txtContactNo.Text + "' WHERE regNo = '" + txtRegNo.Text + "' ";
            con.Open();
            SqlCommand cmd = new SqlCommand(editData,con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Update Successfull","Updated",MessageBoxButtons.OK, MessageBoxIcon.Information);
            clearForm();
            
        }

        private void cmbRegNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string regno = txtRegNo.Text;
                string selque = "SELECT * FROM Registration1 WHERE regNo= '"+regno+"' ";
                con.Open();
                SqlCommand cmd = new SqlCommand(selque, con);
                SqlDataReader R = cmd.ExecuteReader();
                while (R.Read())
                {
                    txtFirstName.Text = R.GetValue(1).ToString();
                    txtLastName.Text = R.GetValue(2).ToString();
                    dateTimePicker1.Value = R.GetDateTime(3);
                    string gender = R.GetString(4);

                    rdoMale.Checked = (gender == "Male");
                    rdoFemale.Checked = (gender == "Female");
                    txtAddress.Text = R.GetValue(5).ToString();
                    txtEmail.Text = R.GetValue(6).ToString();
                    txtMobileNo.Text = R.GetValue(7).ToString();
                    txtHomeNo.Text = R.GetValue(8).ToString();
                    txtParentName.Text = R.GetValue(9).ToString();
                    txtNIC.Text = R.GetValue(10).ToString();
                    txtContactNo.Text = R.GetValue(11).ToString();


                }
                R.Close();
                con.Close();
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Error" + ex);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult resDel = MessageBox.Show("Are you sure, you want to Delete no: " + txtRegNo.Text + " from the database?", "Delete?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if( resDel == DialogResult.Yes)
                {
                    string confDel = "DELETE FROM Registration1 WHERE regNo = '"+txtRegNo.Text+"'";
                    con.Open();
                    SqlCommand cmd = new SqlCommand(confDel,con);
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Student No: " + txtRegNo.Text + "Successfully deleted", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clearForm();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error While Deleting" +Environment.NewLine + ex);
            }
        }
    }
}
