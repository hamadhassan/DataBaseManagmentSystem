using CRUD_Operations;
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

namespace CRUD_Application_Home_Task
{
    public partial class frmRegistration : Form
    {
        public frmRegistration()
        {
            InitializeComponent();
        }

        private void frmRegistration_Load(object sender, EventArgs e)
        {
            bindRegistrationNumber ();
            bindCourseName();
        }
        private void dataBind()
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Select * from enrollments", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
        }
        private void bindRegistrationNumber()
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("select RegistrationNumber from student ", con);
            SqlDataReader reader= cmd.ExecuteReader();
            DataTable dt= new DataTable();
            dt.Columns.Add("RegistrationNumber", typeof(string));
            dt.Load(reader);
            cmbxRegistrationNumber.ValueMember = "RegistrationNumber";
            cmbxRegistrationNumber.DataSource = dt;
            cmd.ExecuteNonQuery();
            
        }
        private void bindCourseName()
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("select name from course ", con);
            SqlDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("name", typeof(string));
            dt.Load(reader);
            cmbxCourseName.ValueMember = "name";
            cmbxCourseName.DataSource = dt;
            cmd.ExecuteNonQuery();

        }
        private void clearField()
        {
            cmbxCourseName.SelectedIndex=0;
            cmbxCourseName.SelectedIndex=0;
        }
        private void btnRegister_Click(object sender, EventArgs e)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Insert into  enrollments values (@StudentRegNo, @CourseName)", con);
            cmd.Parameters.AddWithValue("@StudentRegNo", cmbxRegistrationNumber.Text);
            cmd.Parameters.AddWithValue("@CourseName", cmbxCourseName.Text);
            cmd.ExecuteNonQuery();
            dataBind();
            clearField();
            lblSignal.Text = "Course Registered";
        }

        private void btnUnRegister_Click(object sender, EventArgs e)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("delete from enrollments where StudentRegNo='" + cmbxRegistrationNumber.Text + "'AND CourseName='" + cmbxCourseName.Text+"'", con);
            cmd.ExecuteNonQuery();
            dataBind();
            clearField();
            lblSignal.Text = "Course Unregistered";

        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            dataBind();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            clearField();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
