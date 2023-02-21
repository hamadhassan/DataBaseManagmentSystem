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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CRUD_Application_Home_Task
{
    public partial class frmStudent : Form
    {
        public frmStudent()
        {
            InitializeComponent();
           
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Insert into student values (@RegistrationNumber, @Name, @Department,@Session,@Address)", con);
            cmd.Parameters.AddWithValue("@RegistrationNumber", txtbxRegNumber.Text);
            cmd.Parameters.AddWithValue("@Name", txtbxName.Text);
            cmd.Parameters.AddWithValue("@Department", txtbxDepartment.Text);
            cmd.Parameters.AddWithValue("@Session", int.Parse(txtbxSession.Text));
            cmd.Parameters.AddWithValue("@Address", rtxtbxAddress.Text);
            cmd.ExecuteNonQuery();
            dataBind();
            clearField();
            lblSignal.Text = "Data Sucessfully Saved";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DataGridView dgv = new DataGridView();
            dgv = dataGridView1;
            string regNumber = dgv.CurrentRow.Cells[0].Value.ToString();
            if (dgv.Rows.Count >= 1 && regNumber.Length>=1)
            {
                var con = Configuration.getInstance().getConnection();
                SqlCommand cmd = new SqlCommand("delete from student where RegistrationNumber='" + regNumber+"'", con);
                cmd.ExecuteNonQuery();
                lblSignal.Text = "Selected row deleted";
                dataBind();
            }
            else
            {
                lblSignal.Text = "Select a row from the table";
            }
        }
        private void dataBind()
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Select * from student", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DataGridView dgv = new DataGridView();
            dgv = dataGridView1;
            string regNumber = dgv.CurrentRow.Cells[0].Value.ToString();
            string name = dgv.CurrentRow.Cells[1].Value.ToString();
            string department = dgv.CurrentRow.Cells[2].Value.ToString();
            string  session =dgv.CurrentRow.Cells[3].Value.ToString();
            string address = dgv.CurrentRow.Cells[4].Value.ToString();
            if(regNumber!=txtbxRegNumber.Text || name!=txtbxName.Text || department!=txtbxDepartment.Text || session!=txtbxSession.Text || address!=rtxtbxAddress.Text)
            {
                var con = Configuration.getInstance().getConnection();
                SqlCommand cmd = new SqlCommand("update student set Name = '" + txtbxName.Text + "',Department='" + txtbxDepartment.Text + "',Session='" + int.Parse(txtbxSession.Text) + "', Address='" + rtxtbxAddress.Text + "'where RegistrationNumber = '" + txtbxRegNumber.Text + "'", con);
                cmd.ExecuteNonQuery();
                dataBind();
                lblSignal.Text = "Data Sucessfully Updated";
                clearField();
            }
            else
            {
                lblSignal.Text = "Data not Updated";
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearField();
            txtbxRegNumber.Enabled = true;
        }
        private void clearField()
        {
            txtbxRegNumber.Clear();
            txtbxName.Clear();
            txtbxDepartment.Clear();
            txtbxSession.Clear();
            rtxtbxAddress.Clear();
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = new DataGridView();
            dgv = dataGridView1;
            txtbxRegNumber.Text = dgv.CurrentRow.Cells[0].Value.ToString();
            txtbxName.Text= dgv.CurrentRow.Cells[1].Value.ToString();
            txtbxDepartment.Text= dgv.CurrentRow.Cells[2].Value.ToString();
            txtbxSession.Text = dgv.CurrentRow.Cells[3].Value.ToString() ;
            rtxtbxAddress.Text= dgv.CurrentRow.Cells[4].Value.ToString();
            txtbxRegNumber.Enabled = false;
            txtbxRegNumber.ForeColor = Color.Black;
            txtbxName.ForeColor = Color.Black;
            txtbxDepartment.ForeColor = Color.Black;
            txtbxSession.ForeColor = Color.Black;
            rtxtbxAddress.ForeColor = Color.Black;
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            dataBind();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            lblSignal.Text = " ";
        }

        private void txtbxRegNumber_Enter(object sender, EventArgs e)
        {
            if (txtbxRegNumber.Text == "Registration Number")
            {
                txtbxRegNumber.Text = "";
                txtbxRegNumber.ForeColor = Color.Black;
            }

        }

        private void txtbxRegNumber_Leave(object sender, EventArgs e)
        {
            if(txtbxRegNumber.Text== "")
            {
                txtbxRegNumber.Text = "Registration Number";
                txtbxRegNumber.ForeColor = Color.Silver;
            }
        }

        private void txtbxName_Enter(object sender, EventArgs e)
        {
            if (txtbxName.Text == "Name")
            {
                txtbxName.Text = "";
                txtbxName.ForeColor = Color.Black;
            }

        }

        private void txtbxName_Leave(object sender, EventArgs e)
        {
            if (txtbxName.Text == "")
            {
                txtbxName.Text = "Name";
                txtbxName.ForeColor = Color.Silver;
            }
        }

        private void txtbxDepartment_Enter(object sender, EventArgs e)
        {
            if (txtbxDepartment.Text == "Department")
            {
                txtbxDepartment.Text = "";
                txtbxDepartment.ForeColor = Color.Black;
            }
        }

        private void txtbxDepartment_Leave(object sender, EventArgs e)
        {
            if (txtbxDepartment.Text == "")
            {
                txtbxDepartment.Text = "Department";
                txtbxDepartment.ForeColor = Color.Silver;
            }
        }

        private void txtbxSession_Enter(object sender, EventArgs e)
        {
            if (txtbxSession.Text == "Session")
            {
                txtbxSession.Text = "";
                txtbxSession.ForeColor = Color.Black;
            }
        }

        private void txtbxSession_Leave(object sender, EventArgs e)
        {
            if (txtbxSession.Text == "")
            {
                txtbxSession.Text = "Session";
                txtbxSession.ForeColor = Color.Silver;
            }
        }

        private void rtxtbxAddress_Enter(object sender, EventArgs e)
        {
            if (rtxtbxAddress.Text == "Address")
            {
                rtxtbxAddress.Text = "";
                rtxtbxAddress.ForeColor = Color.Black;
            }
        }

        private void rtxtbxAddress_Leave(object sender, EventArgs e)
        {
            if (rtxtbxAddress.Text == "")
            {
                rtxtbxAddress.Text = "Address";
                rtxtbxAddress.ForeColor = Color.Silver;
            }
        }
    }
}
