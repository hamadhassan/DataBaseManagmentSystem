using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD_Application_Home_Task
{
    public partial class frmDashboard : Form
    {
        public frmDashboard()
        {
            InitializeComponent();
        }
        private void btnCourses_Click(object sender, EventArgs e)
        {
            frmCourse frmCourse= new frmCourse();
            frmCourse.ShowDialog();

        }

        private void btnStudent_Click(object sender, EventArgs e)
        {
            frmStudent frmStudent=new frmStudent();
            frmStudent.ShowDialog();
        }

        private void btnRegisteration_Click(object sender, EventArgs e)
        {
            frmRegistration frmRegistration = new frmRegistration();
            frmRegistration.ShowDialog();
        }

        private void btnAttendance_Click(object sender, EventArgs e)
        {
            frmAttendence frmAttendence = new frmAttendence();
            frmAttendence.ShowDialog();
        }
    }
}
