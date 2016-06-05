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
    public partial class SubjectOfferForm : DBConnectionForm
    {
        public SubjectOfferForm()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void handleLbl_Click(object sender, EventArgs e)
        {

        }

        private void handleCb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SubjectOfferForm_Load(object sender, EventArgs e)
        {
            subjectCb.Text = "- - - - - ";
            editBtn.Enabled = false;
            delBtn.Enabled = false;
            cancelBtn.Enabled = false;
            panel1.Enabled = false;
            subjectOfferDVG.DataSource = myConnn.getAllSubjectOffer();
            for (int i = 0; i < subjectOfferDVG.Columns.Count; i++)
            {

                subjectOfferDVG.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            }
            subjectCb.DataSource = new BindingSource(myConnn.getAllSubject(), null);
            subjectCb.DisplayMember = "Sub_Name";
            subjectCb.ValueMember = "Sub_ID";
        }

        private void newBtn_Click(object sender, EventArgs e)
        {
            this.ClearTextBoxes();
            editBtn.Enabled = false;
            delBtn.Enabled = false;
            statusLbl.Text = "Add Offer";
            panel1.Enabled = true;
            unOfferBtn.Enabled = false;
            currCapTb.Text = "0";
            currCapTb.Enabled = false;
            cancelBtn.Enabled = true;
           
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            String msg = "";
            SubjectOffer subjectOffer = new SubjectOffer();
            subjectOffer.CurrentCapacity = Convert.ToInt16(currCapTb.Text);
            subjectOffer.MaxCapacity = Convert.ToInt16(maxCapTb.Text);
            subjectOffer.Sub_ID = Convert.ToInt16(subjectCb.SelectedValue.ToString());
            if (offerBtn.Enabled == false)
                subjectOffer.IsOffer = true;
            else
                subjectOffer.IsOffer = false;
            subjectOffer.Section = sectionTb.Text;

            if (statusLbl.Text == "Add Offer")
            {
                msg = myConnn.subjectOfferInsert(subjectOffer);
                this.ClearTextBoxes();
            }
            if (statusLbl.Text == "Edit Offer")
            {
                subjectOffer.ID = Convert.ToInt16(idValLbl.Text);

            }
            subjectOfferDVG.DataSource = myConnn.getAllSubjectOffer();
        }

        private void offerBtn_Click(object sender, EventArgs e)
        {
            offerBtn.Enabled = false;
            unOfferBtn.Enabled = true;
        }

        private void unOfferBtn_Click(object sender, EventArgs e)
        {
            offerBtn.Enabled = true;
            unOfferBtn.Enabled = false;
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
            subjectCb.Text = "- - - - - ";
            statusLbl.Text = "Status";
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {

            newBtn.Enabled = true;
            editBtn.Enabled = false;
            delBtn.Enabled = false;
            ClearTextBoxes();
            panel1.Enabled = false;
        }

        private void delBtn_Click(object sender, EventArgs e)
        {
            myConnn.itemDelete("SubjectOffer", "SubjectOffer_ID", idValLbl.Text);
            this.ClearTextBoxes();
        }

        private void subjectOfferDVG_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            editBtn.Enabled = true;
            delBtn.Enabled = true;
            idValLbl.Text = subjectOfferDVG.CurrentRow.Cells["SubjectOffer_ID"].Value.ToString();
            sectionTb.Text = subjectOfferDVG.CurrentRow.Cells["section"].Value.ToString();
            
            currCapTb.Text = subjectOfferDVG.CurrentRow.Cells["currentCapacity"].Value.ToString();
            subjectCb.Text = subjectOfferDVG.CurrentRow.Cells["Sub_name"].Value.ToString();
            maxCapTb.Text = subjectOfferDVG.CurrentRow.Cells["maxCapacity"].Value.ToString();
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            newBtn.Enabled = false;
            delBtn.Enabled = false;
            cancelBtn.Enabled = true;
            panel1.Enabled = true;
            offerBtn.Enabled = true;
            unOfferBtn.Enabled = true;

        }
    }
}
