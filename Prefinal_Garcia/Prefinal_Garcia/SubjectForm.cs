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
    public partial class SubjectForm : DBConnectionForm
    {
        public SubjectForm()
        {
            InitializeComponent();
        }

        private void SubjectForm_Load(object sender, EventArgs e)
        {
            editBtn.Enabled = false;
            delBtn.Enabled = false;
            cancelBtn.Enabled = false;
            panel1.Enabled = false;
            subjectDVG.DataSource = myConnn.getAllSubject();
            for (int i = 0; i < subjectDVG.Columns.Count; i++)
            {
                
                subjectDVG.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                
            }
            handleCb.DataSource = new BindingSource(myConnn.getAllProfessor(), null);
            handleCb.DisplayMember = "Professor";
            handleCb.ValueMember = "Prof_Id";
            handleCb.Text = "- - - - -";

        }

        private void handleCb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            string msg = "";
            Subject subject = new Subject();
            subject.Code = codeTb.Text;
            subject.Description = descTb.Text;
            subject.Name = nameTb.Text;
            subject.Units = Convert.ToInt16(unitTb.Text);
            subject.Prof_ID = Convert.ToInt16(handleCb.SelectedValue.ToString());
            if (statusLbl.Text == "Add Subject")
            {
                msg = myConnn.subjectInsert(subject);
                this.ClearTextBoxes();
            }
            else if (statusLbl.Text == "Edit Subject")
            {
                subject.ID = Convert.ToInt16(idValLbl.Text);
                msg = myConnn.subjectUpdate(subject);

                
            }
            MessageBox.Show(msg);
        }

        private void newBtn_Click(object sender, EventArgs e)
        {
            this.ClearTextBoxes();
            editBtn.Enabled = false;
            delBtn.Enabled = false;
            statusLbl.Text = "Add Subject";
            panel1.Enabled = true;
            cancelBtn.Enabled = true;

        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            statusLbl.Text = "Edit Subject";
            newBtn.Enabled = false;
            delBtn.Enabled = false;
            cancelBtn.Enabled = true;
            panel1.Enabled = true;
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
            handleCb.Text = "- - - - -";
        }

        private void subjectDVG_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            editBtn.Enabled = true;
            delBtn.Enabled = true;
            idValLbl.Text = subjectDVG.CurrentRow.Cells["Sub_ID"].Value.ToString();
            codeTb.Text = subjectDVG.CurrentRow.Cells["Sub_Code"].Value.ToString();
            nameTb.Text = subjectDVG.CurrentRow.Cells["Sub_Name"].Value.ToString();
            descTb.Text = subjectDVG.CurrentRow.Cells["Description"].Value.ToString();
            handleCb.Text = subjectDVG.CurrentRow.Cells["Handle"].Value.ToString();
            unitTb.Text = subjectDVG.CurrentRow.Cells["units"].Value.ToString();
            
        }

        private void delBtn_Click(object sender, EventArgs e)
        {
            myConnn.itemDelete("Subject", "Sub_ID", idValLbl.Text);
            this.ClearTextBoxes();
        }
    }
}
