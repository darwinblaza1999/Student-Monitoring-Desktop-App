
namespace SMS.Views.Students
{
    partial class frmStudentForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnclose = new System.Windows.Forms.Button();
            this.btnrefresh = new System.Windows.Forms.Button();
            this.btnedit = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.groupInfo = new System.Windows.Forms.GroupBox();
            this.rfemale = new System.Windows.Forms.RadioButton();
            this.rmale = new System.Windows.Forms.RadioButton();
            this.label11 = new System.Windows.Forms.Label();
            this.cbostudentId = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnsubmit = new System.Windows.Forms.Button();
            this.cbotype = new System.Windows.Forms.ComboBox();
            this.uxaddress = new System.Windows.Forms.TextBox();
            this.cbostatus = new System.Windows.Forms.ComboBox();
            this.cbograde = new System.Windows.Forms.ComboBox();
            this.uxconNo = new System.Windows.Forms.TextBox();
            this.uxlastname = new System.Windows.Forms.TextBox();
            this.uxmiddle = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.uxfirstname = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(701, 36);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(134, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "STUDENT FORM";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.groupInfo);
            this.panel2.Location = new System.Drawing.Point(2, 44);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(418, 376);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnclose);
            this.panel3.Controls.Add(this.btnrefresh);
            this.panel3.Controls.Add(this.btnedit);
            this.panel3.Controls.Add(this.btnadd);
            this.panel3.Location = new System.Drawing.Point(317, 191);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(84, 180);
            this.panel3.TabIndex = 15;
            // 
            // btnclose
            // 
            this.btnclose.Location = new System.Drawing.Point(9, 130);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(66, 34);
            this.btnclose.TabIndex = 3;
            this.btnclose.Text = "CLOSE";
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // btnrefresh
            // 
            this.btnrefresh.Location = new System.Drawing.Point(9, 86);
            this.btnrefresh.Name = "btnrefresh";
            this.btnrefresh.Size = new System.Drawing.Size(66, 38);
            this.btnrefresh.TabIndex = 2;
            this.btnrefresh.Text = "REFRESH";
            this.btnrefresh.UseVisualStyleBackColor = true;
            this.btnrefresh.Click += new System.EventHandler(this.btnrefresh_Click);
            // 
            // btnedit
            // 
            this.btnedit.Location = new System.Drawing.Point(9, 48);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(66, 32);
            this.btnedit.TabIndex = 1;
            this.btnedit.Text = "EDIT";
            this.btnedit.UseVisualStyleBackColor = true;
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(9, 9);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(66, 33);
            this.btnadd.TabIndex = 0;
            this.btnadd.Text = "ADD";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // groupInfo
            // 
            this.groupInfo.Controls.Add(this.rfemale);
            this.groupInfo.Controls.Add(this.rmale);
            this.groupInfo.Controls.Add(this.label11);
            this.groupInfo.Controls.Add(this.cbostudentId);
            this.groupInfo.Controls.Add(this.label10);
            this.groupInfo.Controls.Add(this.btnsubmit);
            this.groupInfo.Controls.Add(this.cbotype);
            this.groupInfo.Controls.Add(this.uxaddress);
            this.groupInfo.Controls.Add(this.cbostatus);
            this.groupInfo.Controls.Add(this.cbograde);
            this.groupInfo.Controls.Add(this.uxconNo);
            this.groupInfo.Controls.Add(this.uxlastname);
            this.groupInfo.Controls.Add(this.uxmiddle);
            this.groupInfo.Controls.Add(this.label9);
            this.groupInfo.Controls.Add(this.label7);
            this.groupInfo.Controls.Add(this.label8);
            this.groupInfo.Controls.Add(this.label2);
            this.groupInfo.Controls.Add(this.label3);
            this.groupInfo.Controls.Add(this.uxfirstname);
            this.groupInfo.Controls.Add(this.label6);
            this.groupInfo.Controls.Add(this.label4);
            this.groupInfo.Controls.Add(this.label5);
            this.groupInfo.Enabled = false;
            this.groupInfo.Location = new System.Drawing.Point(3, 2);
            this.groupInfo.Name = "groupInfo";
            this.groupInfo.Size = new System.Drawing.Size(308, 369);
            this.groupInfo.TabIndex = 14;
            this.groupInfo.TabStop = false;
            this.groupInfo.Text = "Student  Information";
            // 
            // rfemale
            // 
            this.rfemale.AutoSize = true;
            this.rfemale.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rfemale.Location = new System.Drawing.Point(157, 224);
            this.rfemale.Name = "rfemale";
            this.rfemale.Size = new System.Drawing.Size(67, 19);
            this.rfemale.TabIndex = 22;
            this.rfemale.TabStop = true;
            this.rfemale.Text = "Female";
            this.rfemale.UseVisualStyleBackColor = true;
            // 
            // rmale
            // 
            this.rmale.AutoSize = true;
            this.rmale.Checked = true;
            this.rmale.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rmale.Location = new System.Drawing.Point(86, 225);
            this.rmale.Name = "rmale";
            this.rmale.Size = new System.Drawing.Size(53, 19);
            this.rmale.TabIndex = 21;
            this.rmale.TabStop = true;
            this.rmale.Text = "Male";
            this.rmale.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(8, 219);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 15);
            this.label11.TabIndex = 20;
            this.label11.Text = "Gender";
            // 
            // cbostudentId
            // 
            this.cbostudentId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbostudentId.FormattingEnabled = true;
            this.cbostudentId.Location = new System.Drawing.Point(86, 25);
            this.cbostudentId.Name = "cbostudentId";
            this.cbostudentId.Size = new System.Drawing.Size(206, 23);
            this.cbostudentId.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(9, 25);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 15);
            this.label10.TabIndex = 18;
            this.label10.Text = "Student ID";
            // 
            // btnsubmit
            // 
            this.btnsubmit.Location = new System.Drawing.Point(222, 331);
            this.btnsubmit.Name = "btnsubmit";
            this.btnsubmit.Size = new System.Drawing.Size(62, 32);
            this.btnsubmit.TabIndex = 17;
            this.btnsubmit.Text = "Save";
            this.btnsubmit.UseVisualStyleBackColor = true;
            this.btnsubmit.Click += new System.EventHandler(this.btnsubmit_Click);
            // 
            // cbotype
            // 
            this.cbotype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbotype.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbotype.FormattingEnabled = true;
            this.cbotype.Location = new System.Drawing.Point(86, 287);
            this.cbotype.Name = "cbotype";
            this.cbotype.Size = new System.Drawing.Size(206, 23);
            this.cbotype.TabIndex = 16;
            // 
            // uxaddress
            // 
            this.uxaddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxaddress.Location = new System.Drawing.Point(86, 121);
            this.uxaddress.Name = "uxaddress";
            this.uxaddress.Size = new System.Drawing.Size(206, 21);
            this.uxaddress.TabIndex = 2;
            // 
            // cbostatus
            // 
            this.cbostatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbostatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbostatus.FormattingEnabled = true;
            this.cbostatus.Location = new System.Drawing.Point(86, 254);
            this.cbostatus.Name = "cbostatus";
            this.cbostatus.Size = new System.Drawing.Size(206, 23);
            this.cbostatus.TabIndex = 15;
            // 
            // cbograde
            // 
            this.cbograde.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbograde.FormattingEnabled = true;
            this.cbograde.Location = new System.Drawing.Point(90, 189);
            this.cbograde.Name = "cbograde";
            this.cbograde.Size = new System.Drawing.Size(202, 23);
            this.cbograde.TabIndex = 14;
            // 
            // uxconNo
            // 
            this.uxconNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxconNo.Location = new System.Drawing.Point(104, 154);
            this.uxconNo.Name = "uxconNo";
            this.uxconNo.Size = new System.Drawing.Size(188, 21);
            this.uxconNo.TabIndex = 3;
            // 
            // uxlastname
            // 
            this.uxlastname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxlastname.Location = new System.Drawing.Point(86, 90);
            this.uxlastname.Name = "uxlastname";
            this.uxlastname.Size = new System.Drawing.Size(206, 21);
            this.uxlastname.TabIndex = 5;
            // 
            // uxmiddle
            // 
            this.uxmiddle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxmiddle.Location = new System.Drawing.Point(255, 60);
            this.uxmiddle.Name = "uxmiddle";
            this.uxmiddle.Size = new System.Drawing.Size(37, 21);
            this.uxmiddle.TabIndex = 6;
            this.uxmiddle.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 254);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 15);
            this.label9.TabIndex = 13;
            this.label9.Text = "Status";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(219, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 15);
            this.label7.TabIndex = 11;
            this.label7.Text = "M. I.";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 287);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 15);
            this.label8.TabIndex = 12;
            this.label8.Text = "Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "First Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Grade Level";
            // 
            // uxfirstname
            // 
            this.uxfirstname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxfirstname.Location = new System.Drawing.Point(86, 57);
            this.uxfirstname.Name = "uxfirstname";
            this.uxfirstname.Size = new System.Drawing.Size(126, 21);
            this.uxfirstname.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(10, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "Lastname";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Address";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(7, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Phone Number";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Location = new System.Drawing.Point(0, 418);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(446, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // frmStudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 443);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmStudentForm";
            this.Text = "frmAddStudent";
            this.Load += new System.EventHandler(this.frmStudentForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.groupInfo.ResumeLayout(false);
            this.groupInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox uxmiddle;
        private System.Windows.Forms.TextBox uxlastname;
        private System.Windows.Forms.TextBox uxconNo;
        private System.Windows.Forms.TextBox uxfirstname;
        private System.Windows.Forms.GroupBox groupInfo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox cbotype;
        private System.Windows.Forms.TextBox uxaddress;
        private System.Windows.Forms.ComboBox cbostatus;
        private System.Windows.Forms.ComboBox cbograde;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Button btnrefresh;
        private System.Windows.Forms.Button btnedit;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.ComboBox cbostudentId;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnsubmit;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.RadioButton rfemale;
        private System.Windows.Forms.RadioButton rmale;
        private System.Windows.Forms.Label label11;
    }
}