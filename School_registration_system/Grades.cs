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
    public partial class frmGrades : Form
    {
        public frmGrades()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-8AKQICV\SQLEXPRESS;Initial Catalog=Student;Integrated Security=True");
        SqlDataAdapter SqlDa = new SqlDataAdapter();

        private void frmGrades_Load(object sender, EventArgs e)
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

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmHome_Admin admin = new frmHome_Admin();
            admin.Show();
            this.Hide();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(txtGrade.Text.Length == 0)
            {
                MessageBox.Show("Enter Grade","Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            string grade = txtGrade.Text;
            string subName = txtSubjectName.Text;
            string regno = txtRegNo.Text;
            try
            {
                con.Open();
                string selque = "INSERT INTO Marks VALUES" + "('" + regno + "','" +subName+ "','" +grade+ "')";
                SqlCommand cmd = new SqlCommand(selque, con);

                int n = cmd.ExecuteNonQuery();
                con.Close();
                Console.WriteLine(n);
                if (n == 1)
                {
                    MessageBox.Show("Successfully Add Grade", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtGrade.Clear();
                    txtSubjectName.Clear();
                    txtRegNo.Clear();
                    txtSubjectID.Clear();
                    lblDisplayName.Text = "";
                    lblDisplayEmail.Text = "";
                }
                else
                {
                    MessageBox.Show("Failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSearchStudent_Click(object sender, EventArgs e)
        {
            try
            {
                string regno = txtRegNo.Text;
                string selque = "SELECT * FROM Registration1 WHERE regNo= '" + regno + "'";
                con.Open() ;
                SqlCommand cmd = new SqlCommand (selque, con);
                SqlDataReader rdr = cmd.ExecuteReader();
            while(rdr.Read()) 
            {
                lblDisplayName.Text = rdr.GetValue(1).ToString();
                lblDisplayEmail.Text = rdr.GetValue(6).ToString();
            
            }
            rdr.Close();
            con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }

        private void btnSearchSubject_Click(object sender, EventArgs e)
        {
            try
            {
                string subID = txtSubjectID.Text;
                string selque = "SELECT * FROM subjects1 WHERE subjectID= '" + subID+ "'";
                con.Open();
                SqlCommand cmd = new SqlCommand(selque, con);
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    txtSubjectName.Text = rdr.GetValue(1).ToString();

                }
                rdr.Close();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string editData = "UPDATE Marks SET regNo= '" + txtRegNo.Text + "',subjectName= '" + txtSubjectName.Text + "',grade= '" + txtGrade.Text + "'";
            SqlCommand cmd = new SqlCommand(editData,con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Update Successfull","Success",MessageBoxButtons.OK,MessageBoxIcon.Information);

            txtGrade.Clear();
            txtSubjectName.Clear();
            txtSubjectID.Clear();
            txtSubjectName.Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult resdel = MessageBox.Show("Are you sure,you want to delete No: " + txtRegNo.Text + "from the database?", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if(resdel == DialogResult.Yes)
                {
                    string confdel = "DELETE FROM Marks WHERE regNo= '" + txtRegNo.Text + "'";
                    con.Open();
                    SqlCommand cmd = new SqlCommand(confdel,con);
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Mark of regNo: " + txtRegNo.Text + " Successfully deleted","Deleted", MessageBoxButtons.OK,MessageBoxIcon.Information );
                    txtRegNo.Clear();
                    txtSubjectName.Clear();
                    txtSubjectID.Clear();
                    txtSubjectName.Clear();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error while deleting" + Environment.NewLine + ex);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtGrade.Clear();
            txtRegNo.Clear();
            txtSubjectName.Clear();
            txtSubjectID.Clear();
        }
    }
}
