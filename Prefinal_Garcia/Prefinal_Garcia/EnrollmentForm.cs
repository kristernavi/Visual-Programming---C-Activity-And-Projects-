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
    public partial class EnrollmentForm : DBConnectionForm
    {
        public EnrollmentForm()
        {
            InitializeComponent();
            
            this.AutoCompleteForStudent();
            AutoCompleteForSubject();
        }

        private void EnrollmentForm_Load(object sender, EventArgs e)
        {
            studentDGV.DataSource = myConnn.getAllStudentForEnroll();
            studentDGV.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            studentDGV.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            studentDGV.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            studentDGV.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            studentDGV.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            studentDGV.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            studentDGV.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            subjectDGV.DataSource = myConnn.getAllSubjectForEnroll();
            subjectDGV.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            subjectDGV.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            subjectDGV.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            subjectDGV.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            subjectDGV.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            subjectDGV.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            subjectDGV.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            subjectDGV.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            subjectDGV.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            //studentDGV.Rows[0].Selected = true;
            
        }
        private void dataGridView1_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
{
    if (Convert.ToInt32(subjectDGV.Rows[e.RowIndex].Cells["currentCapacity"].Value) >= Convert.ToInt32(subjectDGV.Rows[e.RowIndex].Cells["maxCapacity"].Value)) 
        
       subjectDGV.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Red;
    else
        subjectDGV.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Green;

}
        private void nameValLbl_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String msg = "";
            int valCredits,valCapacity;
            valCapacity = subjectCurrentCapacity + 1;
            valCredits = studentCurrentCredits + subjectUnits;
            if (valCredits <= studentMaxCredits && valCapacity<=subjectMaxCapacity)
            {
                SubjectEnroll subjEnroll = new SubjectEnroll();
                subjEnroll.Date_Enroll = DateTime.Now;
                subjEnroll.SubjectOfferID = Convert.ToInt16(offerIDValLbl.Text);
                subjEnroll.StudentID = Convert.ToInt16(idValLbl.Text);
                subjEnroll.SubjectID = Convert.ToInt16(subIDValLbl.Text);
                msg = myConnn.subjecEnrollInsert(subjEnroll);
                if (msg == "Successfull Added")
                {
                    myConnn.updateStudentCurrentCredits(idValLbl.Text, valCredits);
                    myConnn.updateSubjectOfferCurrentCapacity(offerIDValLbl.Text, valCapacity);
                }
                
            }
            else
            msg = "Fail";
            MessageBox.Show(msg);

        }

        
        int studentCurrentCredits, studentMaxCredits, subjectCurrentCapacity, subjectMaxCapacity,subjectUnits;
        private void studentDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                idValLbl.Text = studentDGV.CurrentRow.Cells["stud_id"].Value.ToString();
                fnameValLbl.Text = studentDGV.CurrentRow.Cells["firstname"].Value.ToString();
                lnameValLbl.Text = studentDGV.CurrentRow.Cells["lastname"].Value.ToString();
                yrLevelValLbl.Text = studentDGV.CurrentRow.Cells["yrLevel"].Value.ToString();
                studentMaxCredits = Convert.ToInt16(studentDGV.CurrentRow.Cells["maxCredits"].Value.ToString());
                studentCurrentCredits = Convert.ToInt16(studentDGV.CurrentRow.Cells["currentCredits"].Value.ToString());
                creditsValLbl.Text = studentDGV.CurrentRow.Cells["currentCredits"].Value.ToString() + "/" + studentDGV.CurrentRow.Cells["maxCredits"].Value.ToString();
            }
            catch (Exception ex)
            {
                idValLbl.Text = "- - - - - ";
                fnameValLbl.Text = "- - - - - ";
                lnameValLbl.Text = "- - - - - ";
                yrLevelValLbl.Text = "- - - - - ";
                creditsValLbl.Text = "- - - - - ";




            }
        }
        
        private void subjectDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                subIDValLbl.Text = subjectDGV.CurrentRow.Cells["Sub_ID"].Value.ToString();
                subNameValLbl.Text = subjectDGV.CurrentRow.Cells["Sub_Name"].Value.ToString();
                sectionValLbl.Text = subjectDGV.CurrentRow.Cells["section"].Value.ToString();
                subjectUnits = Convert.ToInt16(subjectDGV.CurrentRow.Cells["Units"].Value.ToString());
                unitsValLbl.Text = subjectDGV.CurrentRow.Cells["Units"].Value.ToString();
                subjectCurrentCapacity = Convert.ToInt16(subjectDGV.CurrentRow.Cells["currentCapacity"].Value.ToString());
                subjectMaxCapacity = Convert.ToInt16(subjectDGV.CurrentRow.Cells["maxCapacity"].Value.ToString());
                capacityValLbl.Text = subjectDGV.CurrentRow.Cells["currentCapacity"].Value.ToString() + "/" + subjectDGV.CurrentRow.Cells["maxCapacity"].Value.ToString();
                handleValLbl.Text = subjectDGV.CurrentRow.Cells["Handle"].Value.ToString();
                offerIDValLbl.Text = subjectDGV.CurrentRow.Cells["SubjectOffer_ID"].Value.ToString();
            }
            catch (Exception ex)
            {
                subIDValLbl.Text = "- - - - - ";
                subNameValLbl.Text = "- - - - - ";
                sectionValLbl.Text = "- - - - - ";
               capacityValLbl.Text = "- - - - - ";
              unitsValLbl.Text  = "- - - - - ";
               handleValLbl.Text = "- - - - - ";
                offerIDValLbl.Text = "- - - - - ";
                //= "- - - - - ";

            }
        }

        private void subIDValLbl_Click(object sender, EventArgs e)
        {
            
        }

        private void subjectDGV_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DataView DV = new DataView(myConnn.getAllStudentForEnroll());
            DV.RowFilter = string.Format("firstname LIKE '%{0}%' OR lastname LIKE '%{0}%' OR Convert(stud_id, 'System.String') LIKE '%{0}%'", textBox1.Text);
            studentDGV.DataSource = DV;
            studentDGV.Rows[0].Selected = true;
            studentDGV_CellClick(studentDGV, new DataGridViewCellEventArgs(0, 0));
        }
        
        private void AutoCompleteForStudent()
        {
            textBox1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            textBox1.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection coll = new AutoCompleteStringCollection();
            textBox1.AutoCompleteCustomSource = coll;
            DataTable dt = myConnn.getAllStudentForEnroll();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string fnames = dt.Rows[i]["firstname"].ToString();
                string lname = dt.Rows[i]["lastname"].ToString();
                string id = dt.Rows[i]["stud_id"].ToString();
                coll.Add(fnames);
                coll.Add(lname);
                coll.Add(id);

            }
        }
        private void AutoCompleteForSubject()
        {
            textBox2.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            textBox2.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection coll = new AutoCompleteStringCollection();
            textBox2.AutoCompleteCustomSource = coll;
            DataTable dt = myConnn.getAllSubjectForEnroll();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string fnames = dt.Rows[i]["Handle"].ToString();
                string lname = dt.Rows[i]["Sub_Name"].ToString();
                string id = dt.Rows[i]["Sub_ID"].ToString();
                coll.Add(fnames);
                coll.Add(lname);
                coll.Add(id);

            }
        }

        private void studentDGV_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
           
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            DataView DV = new DataView(myConnn.getAllSubjectForEnroll());
            DV.RowFilter = string.Format("Handle LIKE '%{0}%' OR Convert(Sub_ID, 'System.String') LIKE '%{0}%' OR Sub_Name LIKE '%{0}%'", textBox2.Text);
            subjectDGV.DataSource = DV;
            subjectDGV.Rows[0].Selected = true;
            subjectDGV_CellClick(subjectDGV, new DataGridViewCellEventArgs(0, 0));
        }

        private void studentDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        

    }

}
