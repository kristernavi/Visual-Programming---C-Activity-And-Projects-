namespace Prefinal_Garcia
{
    partial class SubjectOfferForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.unOfferBtn = new System.Windows.Forms.Button();
            this.offerBtn = new System.Windows.Forms.Button();
            this.subjectCb = new System.Windows.Forms.ComboBox();
            this.handleLbl = new System.Windows.Forms.Label();
            this.saveBtn = new System.Windows.Forms.Button();
            this.subIdLbl = new System.Windows.Forms.Label();
            this.currCapTb = new System.Windows.Forms.TextBox();
            this.maxCapLbl = new System.Windows.Forms.Label();
            this.maxCapTb = new System.Windows.Forms.TextBox();
            this.currCapLbl = new System.Windows.Forms.Label();
            this.sectionTb = new System.Windows.Forms.TextBox();
            this.sectionLbl = new System.Windows.Forms.Label();
            this.idValLbl = new System.Windows.Forms.Label();
            this.idLbl = new System.Windows.Forms.Label();
            this.statusLbl = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.delBtn = new System.Windows.Forms.Button();
            this.editBtn = new System.Windows.Forms.Button();
            this.newBtn = new System.Windows.Forms.Button();
            this.subjectOfferDVG = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.subjectOfferDVG)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.unOfferBtn);
            this.panel1.Controls.Add(this.offerBtn);
            this.panel1.Controls.Add(this.subjectCb);
            this.panel1.Controls.Add(this.handleLbl);
            this.panel1.Controls.Add(this.saveBtn);
            this.panel1.Controls.Add(this.subIdLbl);
            this.panel1.Controls.Add(this.currCapTb);
            this.panel1.Controls.Add(this.maxCapLbl);
            this.panel1.Controls.Add(this.maxCapTb);
            this.panel1.Controls.Add(this.currCapLbl);
            this.panel1.Controls.Add(this.sectionTb);
            this.panel1.Controls.Add(this.sectionLbl);
            this.panel1.Controls.Add(this.idValLbl);
            this.panel1.Controls.Add(this.idLbl);
            this.panel1.Controls.Add(this.statusLbl);
            this.panel1.Location = new System.Drawing.Point(11, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(274, 282);
            this.panel1.TabIndex = 9;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // unOfferBtn
            // 
            this.unOfferBtn.Location = new System.Drawing.Point(177, 188);
            this.unOfferBtn.Name = "unOfferBtn";
            this.unOfferBtn.Size = new System.Drawing.Size(75, 23);
            this.unOfferBtn.TabIndex = 19;
            this.unOfferBtn.Text = "Unoffer";
            this.unOfferBtn.UseVisualStyleBackColor = true;
            this.unOfferBtn.Click += new System.EventHandler(this.unOfferBtn_Click);
            // 
            // offerBtn
            // 
            this.offerBtn.Location = new System.Drawing.Point(96, 188);
            this.offerBtn.Name = "offerBtn";
            this.offerBtn.Size = new System.Drawing.Size(75, 23);
            this.offerBtn.TabIndex = 18;
            this.offerBtn.Text = "Offer";
            this.offerBtn.UseVisualStyleBackColor = true;
            this.offerBtn.Click += new System.EventHandler(this.offerBtn_Click);
            // 
            // subjectCb
            // 
            this.subjectCb.FormattingEnabled = true;
            this.subjectCb.Location = new System.Drawing.Point(96, 86);
            this.subjectCb.Name = "subjectCb";
            this.subjectCb.Size = new System.Drawing.Size(156, 21);
            this.subjectCb.TabIndex = 17;
            this.subjectCb.SelectedIndexChanged += new System.EventHandler(this.handleCb_SelectedIndexChanged);
            // 
            // handleLbl
            // 
            this.handleLbl.AutoSize = true;
            this.handleLbl.Location = new System.Drawing.Point(46, 195);
            this.handleLbl.Name = "handleLbl";
            this.handleLbl.Size = new System.Drawing.Size(41, 13);
            this.handleLbl.TabIndex = 16;
            this.handleLbl.Text = "Is Offer";
            this.handleLbl.Click += new System.EventHandler(this.handleLbl_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(106, 248);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(75, 23);
            this.saveBtn.TabIndex = 15;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // subIdLbl
            // 
            this.subIdLbl.AutoSize = true;
            this.subIdLbl.Location = new System.Drawing.Point(51, 94);
            this.subIdLbl.Name = "subIdLbl";
            this.subIdLbl.Size = new System.Drawing.Size(43, 13);
            this.subIdLbl.TabIndex = 10;
            this.subIdLbl.Text = "Subject";
            // 
            // currCapTb
            // 
            this.currCapTb.Location = new System.Drawing.Point(96, 136);
            this.currCapTb.Name = "currCapTb";
            this.currCapTb.Size = new System.Drawing.Size(44, 20);
            this.currCapTb.TabIndex = 9;
            // 
            // maxCapLbl
            // 
            this.maxCapLbl.AutoSize = true;
            this.maxCapLbl.Location = new System.Drawing.Point(16, 169);
            this.maxCapLbl.Name = "maxCapLbl";
            this.maxCapLbl.Size = new System.Drawing.Size(71, 13);
            this.maxCapLbl.TabIndex = 8;
            this.maxCapLbl.Text = "Max Capacity";
            // 
            // maxCapTb
            // 
            this.maxCapTb.Location = new System.Drawing.Point(96, 162);
            this.maxCapTb.Name = "maxCapTb";
            this.maxCapTb.Size = new System.Drawing.Size(44, 20);
            this.maxCapTb.TabIndex = 7;
            // 
            // currCapLbl
            // 
            this.currCapLbl.AutoSize = true;
            this.currCapLbl.Location = new System.Drawing.Point(9, 139);
            this.currCapLbl.Name = "currCapLbl";
            this.currCapLbl.Size = new System.Drawing.Size(85, 13);
            this.currCapLbl.TabIndex = 6;
            this.currCapLbl.Text = "Current Capacity";
            // 
            // sectionTb
            // 
            this.sectionTb.Location = new System.Drawing.Point(96, 113);
            this.sectionTb.Name = "sectionTb";
            this.sectionTb.Size = new System.Drawing.Size(44, 20);
            this.sectionTb.TabIndex = 5;
            // 
            // sectionLbl
            // 
            this.sectionLbl.AutoSize = true;
            this.sectionLbl.Location = new System.Drawing.Point(51, 123);
            this.sectionLbl.Name = "sectionLbl";
            this.sectionLbl.Size = new System.Drawing.Size(43, 13);
            this.sectionLbl.TabIndex = 4;
            this.sectionLbl.Text = "Section";
            // 
            // idValLbl
            // 
            this.idValLbl.AutoSize = true;
            this.idValLbl.Location = new System.Drawing.Point(116, 66);
            this.idValLbl.Name = "idValLbl";
            this.idValLbl.Size = new System.Drawing.Size(37, 13);
            this.idValLbl.TabIndex = 3;
            this.idValLbl.Text = "- - - - - ";
            // 
            // idLbl
            // 
            this.idLbl.AutoSize = true;
            this.idLbl.Location = new System.Drawing.Point(29, 66);
            this.idLbl.Name = "idLbl";
            this.idLbl.Size = new System.Drawing.Size(58, 13);
            this.idLbl.TabIndex = 2;
            this.idLbl.Text = "ID Number";
            // 
            // statusLbl
            // 
            this.statusLbl.AutoSize = true;
            this.statusLbl.Location = new System.Drawing.Point(103, 35);
            this.statusLbl.Name = "statusLbl";
            this.statusLbl.Size = new System.Drawing.Size(37, 13);
            this.statusLbl.TabIndex = 0;
            this.statusLbl.Text = "Status";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cancelBtn);
            this.panel2.Controls.Add(this.delBtn);
            this.panel2.Controls.Add(this.editBtn);
            this.panel2.Controls.Add(this.newBtn);
            this.panel2.Location = new System.Drawing.Point(11, 300);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(383, 59);
            this.panel2.TabIndex = 8;
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(291, 15);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 3;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // delBtn
            // 
            this.delBtn.Location = new System.Drawing.Point(199, 15);
            this.delBtn.Name = "delBtn";
            this.delBtn.Size = new System.Drawing.Size(75, 23);
            this.delBtn.TabIndex = 2;
            this.delBtn.Text = "Delete";
            this.delBtn.UseVisualStyleBackColor = true;
            this.delBtn.Click += new System.EventHandler(this.delBtn_Click);
            // 
            // editBtn
            // 
            this.editBtn.Location = new System.Drawing.Point(106, 15);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(75, 23);
            this.editBtn.TabIndex = 1;
            this.editBtn.Text = "Edit";
            this.editBtn.UseVisualStyleBackColor = true;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // newBtn
            // 
            this.newBtn.Location = new System.Drawing.Point(19, 15);
            this.newBtn.Name = "newBtn";
            this.newBtn.Size = new System.Drawing.Size(75, 23);
            this.newBtn.TabIndex = 0;
            this.newBtn.Text = "New";
            this.newBtn.UseVisualStyleBackColor = true;
            this.newBtn.Click += new System.EventHandler(this.newBtn_Click);
            // 
            // subjectOfferDVG
            // 
            this.subjectOfferDVG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.subjectOfferDVG.Location = new System.Drawing.Point(317, 12);
            this.subjectOfferDVG.Name = "subjectOfferDVG";
            this.subjectOfferDVG.Size = new System.Drawing.Size(580, 282);
            this.subjectOfferDVG.TabIndex = 10;
            this.subjectOfferDVG.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.subjectOfferDVG_CellClick);
            // 
            // SubjectOfferForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 371);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.subjectOfferDVG);
            this.Name = "SubjectOfferForm";
            this.Text = "SubjectOfferForm";
            this.Load += new System.EventHandler(this.SubjectOfferForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.subjectOfferDVG)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox subjectCb;
        private System.Windows.Forms.Label handleLbl;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Label subIdLbl;
        private System.Windows.Forms.TextBox currCapTb;
        private System.Windows.Forms.Label maxCapLbl;
        private System.Windows.Forms.TextBox maxCapTb;
        private System.Windows.Forms.Label currCapLbl;
        private System.Windows.Forms.TextBox sectionTb;
        private System.Windows.Forms.Label sectionLbl;
        private System.Windows.Forms.Label idValLbl;
        private System.Windows.Forms.Label idLbl;
        private System.Windows.Forms.Label statusLbl;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button delBtn;
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.Button newBtn;
        private System.Windows.Forms.DataGridView subjectOfferDVG;
        private System.Windows.Forms.Button unOfferBtn;
        private System.Windows.Forms.Button offerBtn;
    }
}