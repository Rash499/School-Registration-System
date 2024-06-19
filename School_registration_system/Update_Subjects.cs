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
    public partial class frmUpdate_Subjects : Form
    {
        public frmUpdate_Subjects()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-8AKQICV\SQLEXPRESS;Initial Catalog=Student;Integrated Security=True");
        SqlDataAdapter SqlDa = new SqlDataAdapter();
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
            frmHome_Admin admin = new frmHome_Admin();
            admin.Show();
            this.Hide();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            bool CheckTextBoxEmpty = false;

            if (String.IsNullOrEmpty(txtName.Text))
            {
                CheckTextBoxEmpty = true;
            }
            if(String.IsNullOrEmpty(txtDetails.Text))
            {
                CheckTextBoxEmpty = true;
            }
           
            if(CheckTextBoxEmpty)
            {
                MessageBox.Show("Every Field requierd!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            string subName = txtName.Text;
            string subDetasils = txtDetails.Text;

            try
            {
                con.Open();
                string selque = "INSERT INTO subjects1 VALUES" + "('" + subName + "','" + subDetasils + "')";
                SqlCommand cmd = new SqlCommand(selque,con);
                
                int n = cmd.ExecuteNonQuery();
                con.Close();
                Console.WriteLine(n);
                if (n == 1)
                {
                    MessageBox.Show("Successfully Added","Success",MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtName.Clear();
                    txtDetails.Clear();
                }
                else
                {
                    MessageBox.Show("Failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            catch(Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            

            

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string subID = txtSubjectID.Text;
                string selque = "SELECT * FROM subjects1 WHERE subjectID= '" +subID+ "'";
                con.Open();
                SqlCommand cmd = new SqlCommand(selque, con);
                SqlDataReader R = cmd.ExecuteReader();
                while (R.Read())
                {
                    txtName.Text = R.GetValue(1).ToString();
                    txtDetails.Text = R.GetValue(2).ToString();
                }
                R.Close();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string editData = "UPDATE subjects1 SET subjectName = '" + txtName.Text + "', subjectDetails = '" + txtDetails.Text + "' WHERE subjectID = '" + txtSubjectID.Text + "' ";
            con.Open();
            SqlCommand cmd = new SqlCommand(editData, con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Update Successfull", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtName.Clear();
            txtDetails.Clear();
            txtSubjectID.Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult resDel = MessageBox.Show("Are you sure, you want to Delete no: " +txtSubjectID.Text+ " from the database?", "Delete?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (resDel == DialogResult.Yes)
                {
                    string confDel = "DELETE FROM subjects1 WHERE subjectID= '" + txtSubjectID.Text + "'";
                    con.Open();
                    SqlCommand cmd = new SqlCommand(confDel, con);
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("subject : " + txtName.Text + " Successfully deleted", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtName.Clear();
                    txtDetails.Clear();
                    txtSubjectID.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error While Deleting" + Environment.NewLine + ex);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtSubjectID.Clear();
            txtName.Clear();
            txtDetails.Clear();
        }
    }
}
