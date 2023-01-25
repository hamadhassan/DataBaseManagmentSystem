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
    public partial class frmCourse : Form
    {
        public frmCourse()
        {
            InitializeComponent();
        }
        private void dataBind()
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Select * from course", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
        }
        private void clearField()
        {
            txtbxName.Clear();
            txtbxCode.Clear();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Insert into course values (@Name, @Code)", con);
            cmd.Parameters.AddWithValue("@Name", txtbxName.Text);
            cmd.Parameters.AddWithValue("@Code", txtbxCode.Text);
            cmd.ExecuteNonQuery();
            dataBind();
            clearField();
            lblSignal.Text = "Data Sucessfully Saved";
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            lblSignal.Text = "";
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            dataBind();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DataGridView dgv = new DataGridView();
            dgv = dataGridView1;
            string code = dgv.CurrentRow.Cells[1].Value.ToString();
            if (dgv.Rows.Count >= 1 && code.Length >= 1)
            {
                var con = Configuration.getInstance().getConnection();
                SqlCommand cmd = new SqlCommand("delete from course where Code='" + code + "'", con);
                cmd.ExecuteNonQuery();
                lblSignal.Text = "Selected row deleted";
                dataBind();
            }
            else
            {
                lblSignal.Text = "Select a row from the table";
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DataGridView dgv = new DataGridView();
            dgv = dataGridView1;
            string name = dgv.CurrentRow.Cells[0].Value.ToString();
            string code = dgv.CurrentRow.Cells[1].Value.ToString();
            if (code != txtbxCode.Text || name != txtbxName.Text)
            {
                var con = Configuration.getInstance().getConnection();
                SqlCommand cmd = new SqlCommand("update course set Name = '" + txtbxName.Text + "'where Code = '" + txtbxCode.Text + "'", con);
                cmd.ExecuteNonQuery();
                dataBind();
                lblSignal.Text = "Data Sucessfully Updated";
                clearField();
                txtbxCode.Enabled=false;
            }
            else
            {
                lblSignal.Text = "Data not Updated";
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearField();
            txtbxCode.Enabled = true;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = new DataGridView();
            dgv = dataGridView1;
            txtbxName.Text = dgv.CurrentRow.Cells[0].Value.ToString();
            txtbxCode.Text = dgv.CurrentRow.Cells[1].Value.ToString();
            txtbxCode.Enabled = false;
        }
    }
}
