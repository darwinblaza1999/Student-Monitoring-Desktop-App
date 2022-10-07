
namespace SMS.Views.Accounts
{
    partial class frmUser
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
            this.btnSave = new System.Windows.Forms.Button();
            this.btnrefresh = new System.Windows.Forms.Button();
            this.btnedit = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.uxaddress = new System.Windows.Forms.TextBox();
            this.uxfname = new System.Windows.Forms.TextBox();
            this.uxlname = new System.Windows.Forms.TextBox();
            this.uxpassword = new System.Windows.Forms.TextBox();
            this.uxuname = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblfname = new System.Windows.Forms.Label();
            this.dgvRecord = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.rActive = new System.Windows.Forms.RadioButton();
            this.rInActive = new System.Windows.Forms.RadioButton();
            this.cboPos = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.uxemail = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecord)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(907, 36);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(369, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "USER MANAGEMENT";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(192, 378);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(87, 37);
            this.btnSave.TabIndex = 38;
            this.btnSave.Text = "ADD";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnrefresh
            // 
            this.btnrefresh.Location = new System.Drawing.Point(6, 378);
            this.btnrefresh.Name = "btnrefresh";
            this.btnrefresh.Size = new System.Drawing.Size(87, 37);
            this.btnrefresh.TabIndex = 41;
            this.btnrefresh.Text = "REFRESH";
            this.btnrefresh.UseVisualStyleBackColor = true;
            this.btnrefresh.Click += new System.EventHandler(this.btnrefresh_Click);
            // 
            // btnedit
            // 
            this.btnedit.Location = new System.Drawing.Point(99, 378);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(87, 37);
            this.btnedit.TabIndex = 39;
            this.btnedit.Text = "EDIT";
            this.btnedit.UseVisualStyleBackColor = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Location = new System.Drawing.Point(0, 426);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(909, 25);
            this.toolStrip1.TabIndex = 41;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // uxaddress
            // 
            this.uxaddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxaddress.Location = new System.Drawing.Point(118, 93);
            this.uxaddress.Name = "uxaddress";
            this.uxaddress.Size = new System.Drawing.Size(152, 22);
            this.uxaddress.TabIndex = 11;
            // 
            // uxfname
            // 
            this.uxfname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxfname.Location = new System.Drawing.Point(119, 27);
            this.uxfname.Name = "uxfname";
            this.uxfname.Size = new System.Drawing.Size(152, 22);
            this.uxfname.TabIndex = 9;
            // 
            // uxlname
            // 
            this.uxlname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxlname.Location = new System.Drawing.Point(119, 60);
            this.uxlname.Name = "uxlname";
            this.uxlname.Size = new System.Drawing.Size(152, 22);
            this.uxlname.TabIndex = 8;
            // 
            // uxpassword
            // 
            this.uxpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxpassword.Location = new System.Drawing.Point(119, 53);
            this.uxpassword.Name = "uxpassword";
            this.uxpassword.PasswordChar = '*';
            this.uxpassword.Size = new System.Drawing.Size(152, 22);
            this.uxpassword.TabIndex = 7;
            // 
            // uxuname
            // 
            this.uxuname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxuname.Location = new System.Drawing.Point(119, 16);
            this.uxuname.Name = "uxuname";
            this.uxuname.Size = new System.Drawing.Size(152, 22);
            this.uxuname.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(15, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Lastname";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Address";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Position";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Username";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblfname
            // 
            this.lblfname.AutoSize = true;
            this.lblfname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfname.Location = new System.Drawing.Point(17, 30);
            this.lblfname.Name = "lblfname";
            this.lblfname.Size = new System.Drawing.Size(73, 16);
            this.lblfname.TabIndex = 0;
            this.lblfname.Text = "First Name";
            // 
            // dgvRecord
            // 
            this.dgvRecord.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRecord.Location = new System.Drawing.Point(290, 90);
            this.dgvRecord.Name = "dgvRecord";
            this.dgvRecord.ReadOnly = true;
            this.dgvRecord.Size = new System.Drawing.Size(607, 306);
            this.dgvRecord.TabIndex = 44;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.uxemail);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.cboPos);
            this.groupBox1.Controls.Add(this.rInActive);
            this.groupBox1.Controls.Add(this.rActive);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.uxlname);
            this.groupBox1.Controls.Add(this.uxaddress);
            this.groupBox1.Controls.Add(this.lblfname);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.uxfname);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(5, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(279, 207);
            this.groupBox1.TabIndex = 45;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "User Details";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.uxuname);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.uxpassword);
            this.groupBox2.Location = new System.Drawing.Point(7, 256);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(277, 116);
            this.groupBox2.TabIndex = 46;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "User Credentials";
            // 
            // txtsearch
            // 
            this.txtsearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsearch.Location = new System.Drawing.Point(669, 47);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(197, 26);
            this.txtsearch.TabIndex = 47;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(619, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 48;
            this.label7.Text = "Search:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(20, 185);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 16);
            this.label8.TabIndex = 12;
            this.label8.Text = "Status";
            // 
            // rActive
            // 
            this.rActive.AutoSize = true;
            this.rActive.Checked = true;
            this.rActive.Location = new System.Drawing.Point(124, 184);
            this.rActive.Name = "rActive";
            this.rActive.Size = new System.Drawing.Size(55, 17);
            this.rActive.TabIndex = 13;
            this.rActive.TabStop = true;
            this.rActive.Text = "Active";
            this.rActive.UseVisualStyleBackColor = true;
            // 
            // rInActive
            // 
            this.rInActive.AutoSize = true;
            this.rInActive.Location = new System.Drawing.Point(200, 183);
            this.rInActive.Name = "rInActive";
            this.rInActive.Size = new System.Drawing.Size(64, 17);
            this.rInActive.TabIndex = 14;
            this.rInActive.Text = "InActive";
            this.rInActive.UseVisualStyleBackColor = true;
            // 
            // cboPos
            // 
            this.cboPos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPos.FormattingEnabled = true;
            this.cboPos.Location = new System.Drawing.Point(120, 156);
            this.cboPos.Name = "cboPos";
            this.cboPos.Size = new System.Drawing.Size(152, 21);
            this.cboPos.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(17, 125);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 16);
            this.label9.TabIndex = 16;
            this.label9.Text = "Email";
            // 
            // uxemail
            // 
            this.uxemail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxemail.Location = new System.Drawing.Point(119, 125);
            this.uxemail.Name = "uxemail";
            this.uxemail.Size = new System.Drawing.Size(152, 22);
            this.uxemail.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(15, 83);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(116, 16);
            this.label10.TabIndex = 8;
            this.label10.Text = "Confirm Password";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(137, 83);
            this.textBox1.Name = "textBox1";
            this.textBox1.PasswordChar = '*';
            this.textBox1.Size = new System.Drawing.Size(134, 22);
            this.textBox1.TabIndex = 9;
            // 
            // frmUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 451);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtsearch);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnrefresh);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvRecord);
            this.Controls.Add(this.btnedit);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.panel1);
            this.Name = "frmUser";
            this.Text = "frmUser";
            this.Load += new System.EventHandler(this.frmUser_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecord)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnrefresh;
        private System.Windows.Forms.Button btnedit;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblfname;
        private System.Windows.Forms.TextBox uxaddress;
        private System.Windows.Forms.TextBox uxfname;
        private System.Windows.Forms.TextBox uxlname;
        private System.Windows.Forms.TextBox uxpassword;
        private System.Windows.Forms.TextBox uxuname;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvRecord;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton rInActive;
        private System.Windows.Forms.RadioButton rActive;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cboPos;
        private System.Windows.Forms.TextBox uxemail;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label10;
    }
}