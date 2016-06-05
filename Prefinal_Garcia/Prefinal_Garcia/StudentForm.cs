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
    public partial class StudentForm : DBConnectionForm
    {
        public StudentForm()
        {
            InitializeComponent();
        }

        private void StudentForm_Load(object sender, EventArgs e)
        {
            editBtn.Enabled = false;
            delBtn.Enabled = false;
            cancelBtn.Enabled = false;
            panel1.Enabled = false;
            currCreditsTb.Enabled = false;
            maxCreditsTb.Enabled = false;
            studentDVG.DataSource = myConnn.getAllStudent();
            for (int i = 0; i < studentDVG.Columns.Count; i++)
            {

                studentDVG.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            }
            yrLevelCb.Text = "- - - - - ";
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void newBtn_Click(object sender, EventArgs e)
        
        {
            this.ClearTextBoxes();
           
            editBtn.Enabled = false;
            delBtn.Enabled = false;
            cancelBtn.Enabled = true;
            panel1.Enabled = true;
            maxCreditsTb.Text = "0";
            currCreditsTb.Text = "0";
            statusLbl.Text = "Add Student";
            
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            newBtn.Enabled = false;
            delBtn.Enabled = false;
            cancelBtn.Enabled = true;
            panel1.Enabled = true;
            maxCreditsTb.Enabled = true;
            currCreditsTb.Enabled = true;
            statusLbl.Text = "Edit Student";
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            String msg = "";
            Student student = new Student();
            student.Firstname = fnameTb.Text;
            student.Lastname = lnameTb.Text;
            student.Age = Convert.ToInt16(ageTb.Text);
            student.CurrentCredits = Convert.ToInt16(currCreditsTb.Text);
            student.MaxCredits = Convert.ToInt16(maxCreditsTb.Text);
            student.YrLevel = Convert.ToInt16(yrLevelCb.Text);
            if (statusLbl.Text == "Add Student")
            {
               msg =  myConnn.studentInsert(student);
               ClearTextBoxes();

            }
            else if (statusLbl.Text == "Edit Student")
            {
                student.ID = Convert.ToInt16(idValLbl.Text);
                msg = myConnn.studentUpdate(student);
            }
            MessageBox.Show(msg);
            studentDVG.DataSource = myConnn.getAllStudent();
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
            yrLevelCb.Text = "- - - - - ";
            idValLbl.Text = "- - - - - ";
            statusLbl.Text = "Status";
        }

        private void yrLevelCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (yrLevelCb.Text == "1")
                maxCreditsTb.Text = "30";
            if (yrLevelCb.Text == "2")
                maxCreditsTb.Text = "28";
            if (yrLevelCb.Text == "3")
                maxCreditsTb.Text = "25";
            if (yrLevelCb.Text == "4")
                maxCreditsTb.Text = "23";
            if (yrLevelCb.Text == "5")
                maxCreditsTb.Text = "21";
        }

        private void studentDVG_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            editBtn.Enabled = true;
            delBtn.Enabled = true;
            idValLbl.Text = studentDVG.CurrentRow.Cells["stud_id"].Value.ToString();
            fnameTb.Text = studentDVG.CurrentRow.Cells["firstname"].Value.ToString();
            ageTb.Text = studentDVG.CurrentRow.Cells["age"].Value.ToString();
            lnameTb.Text = studentDVG.CurrentRow.Cells["lastname"].Value.ToString();
            yrLevelCb.Text = studentDVG.CurrentRow.Cells["yrLevel"].Value.ToString();
            maxCreditsTb.Text = studentDVG.CurrentRow.Cells["maxCredits"].Value.ToString();
            currCreditsTb.Text = studentDVG.CurrentRow.Cells["currentCredits"].Value.ToString();
            
        }

        private void delBtn_Click(object sender, EventArgs e)
        {
            myConnn.itemDelete("Student", "stud_id", idValLbl.Text);
            this.ClearTextBoxes();
            studentDVG.DataSource = myConnn.getAllStudent();
        }
    }
}
