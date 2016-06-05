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
    public partial class ProfessorForm : DBConnectionForm
    {
        public ProfessorForm()
        {
            InitializeComponent();
        }

        private void curCreditsLbl_Click(object sender, EventArgs e)
        {

        }

        private void ProfessorForm_Load(object sender, EventArgs e)
        {
            editBtn.Enabled = false;
            delBtn.Enabled = false;
            cancelBtn.Enabled = false;
            panel1.Enabled = false;
            professorDVG.DataSource = myConnn.getAllProfessor();
            for (int i = 0; i < professorDVG.Columns.Count; i++)
            {

                professorDVG.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            }
        }

        private void newBtn_Click(object sender, EventArgs e)
        {
            this.ClearTextBoxes();
            editBtn.Enabled = false;
            delBtn.Enabled = false;
            cancelBtn.Enabled = true;
            panel1.Enabled = true;
            statusLbl.Text = "Add Professor";
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            newBtn.Enabled = false;
            delBtn.Enabled = false;
            cancelBtn.Enabled = true;
            panel1.Enabled = true;
            statusLbl.Text = "Edit Professor";
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            string msg = "";
            Professor professor = new Professor();
            professor.Contact = contactTb.Text;
            professor.Field = fieldTb.Text;
            professor.Firstname = fnameTb.Text;
            professor.Lastname = lnameTb.Text;
            if(statusLbl.Text == "Add Professor")
            {
                msg = myConnn.professorInsert(professor);
                ClearTextBoxes();
            }
            else if(statusLbl.Text == "Edit Professor")
            {
                professor.ID = Convert.ToInt16(idValLbl.Text);
                msg = myConnn.professorUpdate(professor);
            }
            MessageBox.Show(msg);
            professorDVG.DataSource = myConnn.getAllProfessor();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            newBtn.Enabled = true;
            editBtn.Enabled = false;
            delBtn.Enabled = false;
            ClearTextBoxes();
            panel1.Enabled = false;
        }
        private void ClearTextBoxes()
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).Clear();
                    else
                        func(control.Controls);
            };

            func(Controls);
            
            idValLbl.Text = "- - - - - ";
            statusLbl.Text = "Status";
        }

        private void professorDVG_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            editBtn.Enabled = true;
            delBtn.Enabled = true;
            idValLbl.Text = professorDVG.CurrentRow.Cells["Prof_id"].Value.ToString();
            fnameTb.Text = professorDVG.CurrentRow.Cells["Professor"].Value.ToString();
            //lnameTb.Text = professorDVG.CurrentRow.Cells["lastname"].Value.ToString();
            contactTb.Text = professorDVG.CurrentRow.Cells["contact"].Value.ToString();
            fieldTb.Text = professorDVG.CurrentRow.Cells["field"].Value.ToString();
            
        }

        private void delBtn_Click(object sender, EventArgs e)
        {
            myConnn.itemDelete("Professor", "Prof_id", idValLbl.Text);
            this.ClearTextBoxes();
        }
    }
}
