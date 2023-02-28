﻿using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrystalReport_A_Lab_07
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ShowReport();
        }
        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            ShowReport();
        }
        private void ShowReport()
        {
            ReportDocument r = new ReportDocument();
            string path = Application.StartupPath;
            string reportpath = @"CrystalReport3.rpt";
            string fpath = Path.Combine(path, reportpath);
            r.Load(fpath);
            crystalReportViewer1.ReportSource = r;
        }
    }
}
