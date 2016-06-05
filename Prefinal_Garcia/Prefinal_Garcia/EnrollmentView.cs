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
    public partial class EnrollmentView : DBConnectionForm
    {
        public EnrollmentView()
        {
            InitializeComponent();
        }

        private void EnrollmentView_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = myConnn.getAllSubjectEnroll();
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {

                dataGridView1.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
