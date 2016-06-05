namespace Prefinal_Garcia
{
    partial class StudentForm
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
            this.saveBtn = new System.Windows.Forms.Button();
            this.yrLevelCb = new System.Windows.Forms.ComboBox();
            this.yrLevelLbl = new System.Windows.Forms.Label();
            this.maxCreditsLbl = new System.Windows.Forms.Label();
            this.maxCreditsTb = new System.Windows.Forms.TextBox();
            this.curCreditsLbl = new System.Windows.Forms.Label();
            this.currCreditsTb = new System.Windows.Forms.TextBox();
            this.ageLbl = new System.Windows.Forms.Label();
            this.ageTb = new System.Windows.Forms.TextBox();
            this.lnameLbl = new System.Windows.Forms.Label();
            this.lnameTb = new System.Windows.Forms.TextBox();
            this.fnameLbl = new System.Windows.Forms.Label();
            this.idValLbl = new System.Windows.Forms.Label();
            this.idLbl = new System.Windows.Forms.Label();
            this.fnameTb = new System.Windows.Forms.TextBox();
            this.statusLbl = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.delBtn = new System.Windows.Forms.Button();
            this.editBtn = new System.Windows.Forms.Button();
            this.newBtn = new System.Windows.Forms.Button();
            this.studentDVG = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentDVG)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.saveBtn);
            this.panel1.Controls.Add(this.yrLevelCb);
            this.panel1.Controls.Add(this.yrLevelLbl);
            this.panel1.Controls.Add(this.maxCreditsLbl);
            this.panel1.Controls.Add(this.maxCreditsTb);
            this.panel1.Controls.Add(this.curCreditsLbl);
            this.panel1.Controls.Add(this.currCreditsTb);
            this.panel1.Controls.Add(this.ageLbl);
            this.panel1.Controls.Add(this.ageTb);
            this.panel1.Controls.Add(this.lnameLbl);
            this.panel1.Controls.Add(this.lnameTb);
            this.panel1.Controls.Add(this.fnameLbl);
            this.panel1.Controls.Add(this.idValLbl);
            this.panel1.Controls.Add(this.idLbl);
            this.panel1.Controls.Add(this.fnameTb);
            this.panel1.Controls.Add(this.statusLbl);
            this.panel1.Location = new System.Drawing.Point(12, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(274, 282);
            this.panel1.TabIndex = 0;
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
            // yrLevelCb
            // 
            this.yrLevelCb.FormattingEnabled = true;
            this.yrLevelCb.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.yrLevelCb.Location = new System.Drawing.Point(96, 163);
            this.yrLevelCb.Name = "yrLevelCb";
            this.yrLevelCb.Size = new System.Drawing.Size(121, 21);
            this.yrLevelCb.TabIndex = 14;
            this.yrLevelCb.SelectedIndexChanged += new System.EventHandler(this.yrLevelCb_SelectedIndexChanged);
            // 
            // yrLevelLbl
            // 
            this.yrLevelLbl.AutoSize = true;
            this.yrLevelLbl.Location = new System.Drawing.Point(29, 163);
            this.yrLevelLbl.Name = "yrLevelLbl";
            this.yrLevelLbl.Size = new System.Drawing.Size(58, 13);
            this.yrLevelLbl.TabIndex = 13;
            this.yrLevelLbl.Text = "Year Level";
            // 
            // maxCreditsLbl
            // 
            this.maxCreditsLbl.AutoSize = true;
            this.maxCreditsLbl.Location = new System.Drawing.Point(25, 217);
            this.maxCreditsLbl.Name = "maxCreditsLbl";
            this.maxCreditsLbl.Size = new System.Drawing.Size(62, 13);
            this.maxCreditsLbl.TabIndex = 12;
            this.maxCreditsLbl.Text = "Max Credits";
            // 
            // maxCreditsTb
            // 
            this.maxCreditsTb.Location = new System.Drawing.Point(96, 217);
            this.maxCreditsTb.Name = "maxCreditsTb";
            this.maxCreditsTb.Size = new System.Drawing.Size(121, 20);
            this.maxCreditsTb.TabIndex = 11;
            this.maxCreditsTb.Text = "0";
            // 
            // curCreditsLbl
            // 
            this.curCreditsLbl.AutoSize = true;
            this.curCreditsLbl.Location = new System.Drawing.Point(16, 194);
            this.curCreditsLbl.Name = "curCreditsLbl";
            this.curCreditsLbl.Size = new System.Drawing.Size(76, 13);
            this.curCreditsLbl.TabIndex = 10;
            this.curCreditsLbl.Text = "Current Credits";
            // 
            // currCreditsTb
            // 
            this.currCreditsTb.Location = new System.Drawing.Point(96, 191);
            this.currCreditsTb.Name = "currCreditsTb";
            this.currCreditsTb.Size = new System.Drawing.Size(121, 20);
            this.currCreditsTb.TabIndex = 9;
            this.currCreditsTb.Text = "0";
            // 
            // ageLbl
            // 
            this.ageLbl.AutoSize = true;
            this.ageLbl.Location = new System.Drawing.Point(61, 142);
            this.ageLbl.Name = "ageLbl";
            this.ageLbl.Size = new System.Drawing.Size(26, 13);
            this.ageLbl.TabIndex = 8;
            this.ageLbl.Text = "Age";
            // 
            // ageTb
            // 
            this.ageTb.Location = new System.Drawing.Point(96, 142);
            this.ageTb.Name = "ageTb";
            this.ageTb.Size = new System.Drawing.Size(121, 20);
            this.ageTb.TabIndex = 7;
            // 
            // lnameLbl
            // 
            this.lnameLbl.AutoSize = true;
            this.lnameLbl.Location = new System.Drawing.Point(34, 116);
            this.lnameLbl.Name = "lnameLbl";
            this.lnameLbl.Size = new System.Drawing.Size(53, 13);
            this.lnameLbl.TabIndex = 6;
            this.lnameLbl.Text = "Lastname";
            // 
            // lnameTb
            // 
            this.lnameTb.Location = new System.Drawing.Point(96, 113);
            this.lnameTb.Name = "lnameTb";
            this.lnameTb.Size = new System.Drawing.Size(121, 20);
            this.lnameTb.TabIndex = 5;
            // 
            // fnameLbl
            // 
            this.fnameLbl.AutoSize = true;
            this.fnameLbl.Location = new System.Drawing.Point(35, 94);
            this.fnameLbl.Name = "fnameLbl";
            this.fnameLbl.Size = new System.Drawing.Size(52, 13);
            this.fnameLbl.TabIndex = 4;
            this.fnameLbl.Text = "Firstname";
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
            this.idLbl.Size = new System.Drawing.Size(61, 13);
            this.idLbl.TabIndex = 2;
            this.idLbl.Text = "_id Number";
            // 
            // fnameTb
            // 
            this.fnameTb.Location = new System.Drawing.Point(96, 87);
            this.fnameTb.Name = "fnameTb";
            this.fnameTb.Size = new System.Drawing.Size(121, 20);
            this.fnameTb.TabIndex = 1;
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
            this.panel2.Location = new System.Drawing.Point(12, 319);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(383, 59);
            this.panel2.TabIndex = 0;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
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
            // studentDVG
            // 
            this.studentDVG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentDVG.Location = new System.Drawing.Point(318, 31);
            this.studentDVG.Name = "studentDVG";
            this.studentDVG.Size = new System.Drawing.Size(558, 282);
            this.studentDVG.TabIndex = 1;
            this.studentDVG.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.studentDVG_CellClick);
            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 383);
            this.Controls.Add(this.studentDVG);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "StudentForm";
            this.Text = "StudentForm";
            this.Load += new System.EventHandler(this.StudentForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.studentDVG)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox fnameTb;
        private System.Windows.Forms.Label statusLbl;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox yrLevelCb;
        private System.Windows.Forms.Label yrLevelLbl;
        private System.Windows.Forms.Label maxCreditsLbl;
        private System.Windows.Forms.TextBox maxCreditsTb;
        private System.Windows.Forms.Label curCreditsLbl;
        private System.Windows.Forms.TextBox currCreditsTb;
        private System.Windows.Forms.Label ageLbl;
        private System.Windows.Forms.TextBox ageTb;
        private System.Windows.Forms.Label lnameLbl;
        private System.Windows.Forms.TextBox lnameTb;
        private System.Windows.Forms.Label fnameLbl;
        private System.Windows.Forms.Label idValLbl;
        private System.Windows.Forms.Label idLbl;
        private System.Windows.Forms.Button newBtn;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button delBtn;
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.DataGridView studentDVG;
    }
}