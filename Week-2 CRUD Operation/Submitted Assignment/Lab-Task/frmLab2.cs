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

namespace CRUDA
{
    public partial class frmLab2 : Form
    {
        public frmLab2()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Insert into student values (@RegistrationNumber, @Name, @Department,@Session)", con);
            cmd.Parameters.AddWithValue("@RegistrationNumber", txtbxRegNumber.Text);
            cmd.Parameters.AddWithValue("@Name", txtbxName.Text);
            cmd.Parameters.AddWithValue("@Department", txtbxDepartment.Text);
            cmd.Parameters.AddWithValue("@Session", int.Parse(txtbxSession.Text));
            cmd.ExecuteNonQuery();
            MessageBox.Show("Successfully saved");
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Select * from student", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("delete from student where RegistrationNumber=" + txtbxRegNumber.Text, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Successfully deleted");
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("update student set Name = '" + txtbxName.Text + "',Department='" + txtbxDepartment.Text + "',Session='"+int.Parse(txtbxSession.Text)+ "'where RegistrationNumber = '" + txtbxRegNumber.Text + "'", con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Successfully updated");
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Select * from student where RegistrationNumber='" + txtbxSearch.Text+"'OR Name='"+ txtbxSearch.Text+ "' OR Department='"+ txtbxSearch.Text+ "' OR Session='"+int.Parse(txtbxSearch.Text)+"'", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
