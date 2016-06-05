using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Prefinal_Garcia
{
    public partial class GeneratReportsForm : DBConnectionForm
    {
        public GeneratReportsForm()
        {
            InitializeComponent();
        }

        private void GeneratReportsForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'EnrollmentSystemDataSet.DataTable1' table. You can move, or remove it, as needed.
            this.reportViewer1.RefreshReport();
            this.DataTable1TableAdapter.Fill(this.EnrollmentSystemDataSet.DataTable1);

            this.reportViewer1.RefreshReport();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.DataTable1TableAdapter.FillBy(this.EnrollmentSystemDataSet.DataTable1,textBox1.Text);

            this.reportViewer1.RefreshReport();
        }
       
    }
}
