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
    public partial class frmUpdate_Teachers : Form
    {
        public frmUpdate_Teachers()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-8AKQICV\SQLEXPRESS;Initial Catalog=Student;Integrated Security=True");
        SqlDataAdapter adapter = new SqlDataAdapter();

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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string tchName = txtName.Text;
            string tchEmail = txtEmail.Text;
            string tchSection = txtSection.Text;
            int tchConno = int.Parse(txtContactNo.Text);

            try
            {
                con.Open();
                string selque = "INSERT INTO teachers VALUES" + "('"+tchName+ "','" +tchEmail+ "','" +tchSection+ "','" +tchConno+"')";
                SqlCommand cmd = new SqlCommand(selque,con);

                int n = cmd.ExecuteNonQuery(); 
                con.Close();
                Console.WriteLine(n);
                if(n == 1)
                {
                    MessageBox.Show("Successfully Add to the database","Success",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    txtName.Clear();
                    txtEmail.Clear();
                    txtSection.Clear();
                    txtContactNo.Clear();

                }
                else
                {
                    MessageBox.Show("Failed :(", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                string tchid = txtTeacherID.Text;
                string selque = "SELECT * FROM teachers WHERE teacherID = '" + tchid + "'";
                con.Open();
                SqlCommand cmd = new SqlCommand(selque, con);
                SqlDataReader R = cmd.ExecuteReader();
                while (R.Read())
                {
                    txtName.Text = R.GetValue(1).ToString();
                    txtEmail.Text = R.GetValue(2).ToString();
                    txtSection.Text = R.GetValue(3).ToString();
                    txtContactNo.Text = R.GetValue(4).ToString();
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
            string editData = "UPDATE teachers SET teacherName = '" + txtName.Text + "',teacherEmail= '" + txtEmail.Text + "',section= '" + txtSection.Text + "',contactno= '" + txtContactNo.Text + "'";
            con.Open();
            SqlCommand cmd = new SqlCommand(editData, con);
            cmd.ExecuteNonQuery();
            con.Close() ;
            MessageBox.Show("Update Successfull","Updated",MessageBoxButtons.OK,MessageBoxIcon.Information);

            txtTeacherID.Clear();
            txtName.Clear();
            txtEmail.Clear();
            txtSection.Clear();
            txtContactNo.Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult resdel = MessageBox.Show("Are you sure, you want to delete no: " + txtTeacherID.Text + "from the database?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(resdel == DialogResult.Yes)
                {
                    string confdel = "DELETE FROM teachers WHERE teacherID= '" + txtTeacherID.Text + "'";
                    con.Open();
                    SqlCommand cmd = new SqlCommand(confdel, con);
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Teacher ID: " + txtTeacherID.Text + "Successfully Deleted from the database!", "DELETEd", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    txtTeacherID.Clear();
                    txtName.Clear();
                    txtEmail.Clear();
                    txtSection.Clear();
                    txtContactNo.Clear();
                    
                }
            }
            catch(Exception delerr)
            {
                MessageBox.Show("Error" + Environment.NewLine + delerr);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtEmail.Clear();
            txtSection.Clear();
            txtContactNo.Clear();

        }
    }
}
