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
    public partial class frmAttendence : Form
    {
        private bool buttonClicked=false;
        public frmAttendence()
        {
            InitializeComponent();
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
       
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cmbxMode.SelectedIndex == 0)
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    var con = Configuration.getInstance().getConnection();
                    SqlCommand cmd = new SqlCommand("Insert into Attendance values (@StudentRegNo, @CourseName,@TimeStamp,@Status)", con);
                    cmd.Parameters.AddWithValue("@StudentRegNo", row.Cells[1].Value);
                    cmd.Parameters.AddWithValue("@CourseName", row.Cells[2].Value);
                    cmd.Parameters.AddWithValue("@TimeStamp", dateTimePicker1.Value);
                    if ((row.Cells[0].Value) == null)
                    {
                        cmd.Parameters.AddWithValue("@Status", false);

                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@Status", true);
                    }
                    cmd.ExecuteNonQuery();
                    lblSignal.Text = "Attendence saved";
                }
            }
            else
            {//save edit attendence 
                
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    var con = Configuration.getInstance().getConnection();
                    bool status;
                    if ((row.Cells[4].Value) == null)
                    {
                       status= false;

                    }
                    else
                    {
                        status = true;
                    }
                    SqlCommand cmd = new SqlCommand("update Attendance set CourseName = '" + row.Cells[2].Value+ "',TimeStamp='"+ row.Cells[3].Value+"',status='"+status + "'where StudentRegNo = '" + row.Cells[1].Value + "'", con);  
                    cmd.ExecuteNonQuery();
                    lblSignal.Text = "Attendence updated";
                }
            }
            
        }
        private void BindDataForMarkAttendance()
        {
            isSelected.Visible = true;
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Select * from enrollments where coursename='" + cmbxCourseName.Text + "'AND coursename='" + cmbxCourseName.Text + "'", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
        }
        private void BindDataForEditAttendance()
        {
            isSelected.Visible = false;
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand(" Select * from Attendance where CAST(timestamp AS Date) ='" + dateTimePicker1.Value + "'AND coursename='" + cmbxCourseName.Text + "'", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
        }
        private void frmAttendence_Load(object sender, EventArgs e)
        {
            bindCourseName();
            cmbxMode.SelectedIndex = 0;
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void dataGridView1_Click(object sender, EventArgs e)
        {
            buttonClicked = true;
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            if(cmbxMode.SelectedIndex == 0)
            {
                BindDataForMarkAttendance();
            }
            else
            {
                BindDataForEditAttendance();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblSignal.Text = "";
        }
    }
}
