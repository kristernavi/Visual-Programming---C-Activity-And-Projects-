namespace Prefinal_Garcia
{
    partial class ProfessorForm
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
            this.fieldbl = new System.Windows.Forms.Label();
            this.fieldTb = new System.Windows.Forms.TextBox();
            this.contactLbl = new System.Windows.Forms.Label();
            this.contactTb = new System.Windows.Forms.TextBox();
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
            this.professorDVG = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.professorDVG)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.saveBtn);
            this.panel1.Controls.Add(this.fieldbl);
            this.panel1.Controls.Add(this.fieldTb);
            this.panel1.Controls.Add(this.contactLbl);
            this.panel1.Controls.Add(this.contactTb);
            this.panel1.Controls.Add(this.lnameLbl);
            this.panel1.Controls.Add(this.lnameTb);
            this.panel1.Controls.Add(this.fnameLbl);
            this.panel1.Controls.Add(this.idValLbl);
            this.panel1.Controls.Add(this.idLbl);
            this.panel1.Controls.Add(this.fnameTb);
            this.panel1.Controls.Add(this.statusLbl);
            this.panel1.Location = new System.Drawing.Point(12, 51);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(274, 282);
            this.panel1.TabIndex = 3;
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
            // fieldbl
            // 
            this.fieldbl.AutoSize = true;
            this.fieldbl.Location = new System.Drawing.Point(58, 171);
            this.fieldbl.Name = "fieldbl";
            this.fieldbl.Size = new System.Drawing.Size(29, 13);
            this.fieldbl.TabIndex = 10;
            this.fieldbl.Text = "Field";
            this.fieldbl.Click += new System.EventHandler(this.curCreditsLbl_Click);
            // 
            // fieldTb
            // 
            this.fieldTb.Location = new System.Drawing.Point(96, 168);
            this.fieldTb.Name = "fieldTb";
            this.fieldTb.Size = new System.Drawing.Size(121, 20);
            this.fieldTb.TabIndex = 9;
            // 
            // contactLbl
            // 
            this.contactLbl.AutoSize = true;
            this.contactLbl.Location = new System.Drawing.Point(43, 142);
            this.contactLbl.Name = "contactLbl";
            this.contactLbl.Size = new System.Drawing.Size(44, 13);
            this.contactLbl.TabIndex = 8;
            this.contactLbl.Text = "Contact";
            // 
            // contactTb
            // 
            this.contactTb.Location = new System.Drawing.Point(96, 142);
            this.contactTb.Name = "contactTb";
            this.contactTb.Size = new System.Drawing.Size(121, 20);
            this.contactTb.TabIndex = 7;
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
            this.idLbl.Size = new System.Drawing.Size(58, 13);
            this.idLbl.TabIndex = 2;
            this.idLbl.Text = "ID Number";
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
            this.panel2.Location = new System.Drawing.Point(12, 339);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(383, 59);
            this.panel2.TabIndex = 2;
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
            // professorDVG
            // 
            this.professorDVG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.professorDVG.Location = new System.Drawing.Point(318, 51);
            this.professorDVG.Name = "professorDVG";
            this.professorDVG.Size = new System.Drawing.Size(546, 282);
            this.professorDVG.TabIndex = 4;
            this.professorDVG.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.professorDVG_CellClick);
            // 
            // ProfessorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 421);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.professorDVG);
            this.Name = "ProfessorForm";
            this.Text = "ProfessorForm";
            this.Load += new System.EventHandler(this.ProfessorForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.professorDVG)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Label fieldbl;
        private System.Windows.Forms.TextBox fieldTb;
        private System.Windows.Forms.Label contactLbl;
        private System.Windows.Forms.TextBox contactTb;
        private System.Windows.Forms.Label lnameLbl;
        private System.Windows.Forms.TextBox lnameTb;
        private System.Windows.Forms.Label fnameLbl;
        private System.Windows.Forms.Label idValLbl;
        private System.Windows.Forms.Label idLbl;
        private System.Windows.Forms.TextBox fnameTb;
        private System.Windows.Forms.Label statusLbl;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button delBtn;
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.Button newBtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView professorDVG;
    }
}