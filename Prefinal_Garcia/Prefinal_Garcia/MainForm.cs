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
    public partial class MainForm : DBConnectionForm
    {
        public MainForm()
        {
            InitializeComponent();
        }
        DBConnectionForm formOpen = null;
        private void studentToolStripMenuItem_Click(object sender, EventArgs e)
        {




            if (this.ActiveMdiChild != null)
                this.ActiveMdiChild.Close();
            formOpen = new StudentForm();
            formOpen.MdiParent = this;
            formOpen.TopMost = true;
            formOpen.StartPosition = FormStartPosition.CenterScreen;
            formOpen.WindowState = FormWindowState.Normal;
            formOpen.Show();

        }

        
        private void subjectToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (this.ActiveMdiChild != null)
                this.ActiveMdiChild.Close();
            formOpen = new SubjectForm();
            formOpen.MdiParent = this;
            formOpen.StartPosition = FormStartPosition.CenterScreen;
            formOpen.WindowState = FormWindowState.Normal;
            formOpen.Show();
        }

        private void offersToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (this.ActiveMdiChild != null)
                this.ActiveMdiChild.Close();
            formOpen = new SubjectOfferForm();
            formOpen.MdiParent = this;
            formOpen.StartPosition = FormStartPosition.CenterScreen;
            formOpen.WindowState = FormWindowState.Normal;
            formOpen.Show();
        }

        private void enrollToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (this.ActiveMdiChild != null)
                this.ActiveMdiChild.Close();
            formOpen = new EnrollmentForm();
            formOpen.MdiParent = this;
            formOpen.StartPosition = FormStartPosition.CenterScreen;
            formOpen.WindowState = FormWindowState.Normal;
            formOpen.Show();
        }

        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {


            if (this.ActiveMdiChild != null)
                this.ActiveMdiChild.Close();
            formOpen = new EnrollmentView();
            formOpen.MdiParent = this;
            formOpen.StartPosition = FormStartPosition.CenterScreen;
            formOpen.WindowState = FormWindowState.Normal;
            formOpen.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //manageToolStripMenuItem.Enabled = false;
            //enrollmentToolStripMenuItem.Enabled = false;
            //generateReportsToolStripMenuItem.Enabled = false;
             myConnn.ConnectToDatabase();
             formOpen = new LoginForm();
             formOpen.MdiParent = this;
             //formOpen.StartPosition = FormStartPosition.CenterScreen;
             formOpen.WindowState = FormWindowState.Normal;
             formOpen.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void professorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null)
                this.ActiveMdiChild.Close();
            formOpen = new ProfessorForm();
            formOpen.MdiParent = this;
            formOpen.StartPosition = FormStartPosition.CenterScreen;
            formOpen.Show();
        }

        private void MainForm_MaximizedBoundsChanged(object sender, EventArgs e)
        {

        }

        private void generateReportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null)
                this.ActiveMdiChild.Close();
            formOpen = new GeneratReportsForm();
            formOpen.MdiParent = this;
            formOpen.StartPosition = FormStartPosition.CenterScreen;
            formOpen.Show();
        }

        private void manageToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
