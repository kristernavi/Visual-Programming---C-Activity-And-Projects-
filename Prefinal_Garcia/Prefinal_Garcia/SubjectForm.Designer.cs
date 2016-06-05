namespace Prefinal_Garcia
{
    partial class SubjectForm
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
            this.handleCb = new System.Windows.Forms.ComboBox();
            this.handleLbl = new System.Windows.Forms.Label();
            this.saveBtn = new System.Windows.Forms.Button();
            this.descLbl = new System.Windows.Forms.Label();
            this.descTb = new System.Windows.Forms.TextBox();
            this.unitLbl = new System.Windows.Forms.Label();
            this.unitTb = new System.Windows.Forms.TextBox();
            this.subNameLbl = new System.Windows.Forms.Label();
            this.nameTb = new System.Windows.Forms.TextBox();
            this.subCodeLbl = new System.Windows.Forms.Label();
            this.idValLbl = new System.Windows.Forms.Label();
            this.idLbl = new System.Windows.Forms.Label();
            this.codeTb = new System.Windows.Forms.TextBox();
            this.statusLbl = new System.Windows.Forms.Label();
            this.newBtn = new System.Windows.Forms.Button();
            this.editBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.delBtn = new System.Windows.Forms.Button();
            this.subjectDVG = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.subjectDVG)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.handleCb);
            this.panel1.Controls.Add(this.handleLbl);
            this.panel1.Controls.Add(this.saveBtn);
            this.panel1.Controls.Add(this.descLbl);
            this.panel1.Controls.Add(this.descTb);
            this.panel1.Controls.Add(this.unitLbl);
            this.panel1.Controls.Add(this.unitTb);
            this.panel1.Controls.Add(this.subNameLbl);
            this.panel1.Controls.Add(this.nameTb);
            this.panel1.Controls.Add(this.subCodeLbl);
            this.panel1.Controls.Add(this.idValLbl);
            this.panel1.Controls.Add(this.idLbl);
            this.panel1.Controls.Add(this.codeTb);
            this.panel1.Controls.Add(this.statusLbl);
            this.panel1.Location = new System.Drawing.Point(24, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(274, 282);
            this.panel1.TabIndex = 6;
            // 
            // handleCb
            // 
            this.handleCb.FormattingEnabled = true;
            this.handleCb.Location = new System.Drawing.Point(96, 139);
            this.handleCb.Name = "handleCb";
            this.handleCb.Size = new System.Drawing.Size(121, 21);
            this.handleCb.TabIndex = 17;
            this.handleCb.SelectedIndexChanged += new System.EventHandler(this.handleCb_SelectedIndexChanged);
            // 
            // handleLbl
            // 
            this.handleLbl.AutoSize = true;
            this.handleLbl.Location = new System.Drawing.Point(46, 142);
            this.handleLbl.Name = "handleLbl";
            this.handleLbl.Size = new System.Drawing.Size(41, 13);
            this.handleLbl.TabIndex = 16;
            this.handleLbl.Text = "Handle";
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
            // descLbl
            // 
            this.descLbl.AutoSize = true;
            this.descLbl.Location = new System.Drawing.Point(27, 195);
            this.descLbl.Name = "descLbl";
            this.descLbl.Size = new System.Drawing.Size(60, 13);
            this.descLbl.TabIndex = 10;
            this.descLbl.Text = "Description";
            // 
            // descTb
            // 
            this.descTb.Location = new System.Drawing.Point(96, 195);
            this.descTb.Name = "descTb";
            this.descTb.Size = new System.Drawing.Size(121, 20);
            this.descTb.TabIndex = 9;
            // 
            // unitLbl
            // 
            this.unitLbl.AutoSize = true;
            this.unitLbl.Location = new System.Drawing.Point(56, 169);
            this.unitLbl.Name = "unitLbl";
            this.unitLbl.Size = new System.Drawing.Size(31, 13);
            this.unitLbl.TabIndex = 8;
            this.unitLbl.Text = "Units";
            // 
            // unitTb
            // 
            this.unitTb.Location = new System.Drawing.Point(96, 169);
            this.unitTb.Name = "unitTb";
            this.unitTb.Size = new System.Drawing.Size(121, 20);
            this.unitTb.TabIndex = 7;
            // 
            // subNameLbl
            // 
            this.subNameLbl.AutoSize = true;
            this.subNameLbl.Location = new System.Drawing.Point(16, 116);
            this.subNameLbl.Name = "subNameLbl";
            this.subNameLbl.Size = new System.Drawing.Size(74, 13);
            this.subNameLbl.TabIndex = 6;
            this.subNameLbl.Text = "Subject Name";
            // 
            // nameTb
            // 
            this.nameTb.Location = new System.Drawing.Point(96, 113);
            this.nameTb.Name = "nameTb";
            this.nameTb.Size = new System.Drawing.Size(121, 20);
            this.nameTb.TabIndex = 5;
            // 
            // subCodeLbl
            // 
            this.subCodeLbl.AutoSize = true;
            this.subCodeLbl.Location = new System.Drawing.Point(16, 90);
            this.subCodeLbl.Name = "subCodeLbl";
            this.subCodeLbl.Size = new System.Drawing.Size(71, 13);
            this.subCodeLbl.TabIndex = 4;
            this.subCodeLbl.Text = "Subject Code";
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
            // codeTb
            // 
            this.codeTb.Location = new System.Drawing.Point(96, 87);
            this.codeTb.Name = "codeTb";
            this.codeTb.Size = new System.Drawing.Size(121, 20);
            this.codeTb.TabIndex = 1;
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
            // panel2
            // 
            this.panel2.Controls.Add(this.cancelBtn);
            this.panel2.Controls.Add(this.delBtn);
            this.panel2.Controls.Add(this.editBtn);
            this.panel2.Controls.Add(this.newBtn);
            this.panel2.Location = new System.Drawing.Point(24, 300);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(383, 59);
            this.panel2.TabIndex = 5;
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
            // subjectDVG
            // 
            this.subjectDVG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.subjectDVG.Location = new System.Drawing.Point(330, 12);
            this.subjectDVG.Name = "subjectDVG";
            this.subjectDVG.Size = new System.Drawing.Size(588, 282);
            this.subjectDVG.TabIndex = 7;
            this.subjectDVG.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.subjectDVG_CellClick);
            // 
            // SubjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 377);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.subjectDVG);
            this.Name = "SubjectForm";
            this.Text = "SubjectForm";
            this.Load += new System.EventHandler(this.SubjectForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.subjectDVG)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Label descLbl;
        private System.Windows.Forms.TextBox descTb;
        private System.Windows.Forms.Label unitLbl;
        private System.Windows.Forms.TextBox unitTb;
        private System.Windows.Forms.Label subNameLbl;
        private System.Windows.Forms.TextBox nameTb;
        private System.Windows.Forms.Label subCodeLbl;
        private System.Windows.Forms.Label idValLbl;
        private System.Windows.Forms.Label idLbl;
        private System.Windows.Forms.TextBox codeTb;
        private System.Windows.Forms.Label statusLbl;
        private System.Windows.Forms.Button newBtn;
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button delBtn;
        private System.Windows.Forms.DataGridView subjectDVG;
        private System.Windows.Forms.ComboBox handleCb;
        private System.Windows.Forms.Label handleLbl;
    }
}