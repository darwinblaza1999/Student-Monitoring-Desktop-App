
namespace SMS.Views.Students
{
    partial class frmCategory
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
            this.lblcat = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.uxpercent = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnadd = new System.Windows.Forms.Button();
            this.uxcategory = new System.Windows.Forms.TextBox();
            this.lblcategoryname = new System.Windows.Forms.Label();
            this.dgvCategory = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategory)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblcat);
            this.panel1.Location = new System.Drawing.Point(3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(286, 36);
            this.panel1.TabIndex = 0;
            // 
            // lblcat
            // 
            this.lblcat.AutoSize = true;
            this.lblcat.BackColor = System.Drawing.SystemColors.Control;
            this.lblcat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcat.Location = new System.Drawing.Point(89, 7);
            this.lblcat.Name = "lblcat";
            this.lblcat.Size = new System.Drawing.Size(107, 20);
            this.lblcat.TabIndex = 4;
            this.lblcat.Text = "CATEGORY";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.uxpercent);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.btnadd);
            this.panel2.Controls.Add(this.uxcategory);
            this.panel2.Controls.Add(this.lblcategoryname);
            this.panel2.Controls.Add(this.dgvCategory);
            this.panel2.Location = new System.Drawing.Point(3, 44);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(286, 261);
            this.panel2.TabIndex = 1;
            // 
            // uxpercent
            // 
            this.uxpercent.Enabled = false;
            this.uxpercent.Location = new System.Drawing.Point(109, 40);
            this.uxpercent.Name = "uxpercent";
            this.uxpercent.Size = new System.Drawing.Size(156, 20);
            this.uxpercent.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Percentage";
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(201, 66);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(64, 23);
            this.btnadd.TabIndex = 3;
            this.btnadd.Text = "Add";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // uxcategory
            // 
            this.uxcategory.Location = new System.Drawing.Point(109, 14);
            this.uxcategory.Name = "uxcategory";
            this.uxcategory.Size = new System.Drawing.Size(156, 20);
            this.uxcategory.TabIndex = 2;
            // 
            // lblcategoryname
            // 
            this.lblcategoryname.AutoSize = true;
            this.lblcategoryname.Location = new System.Drawing.Point(9, 17);
            this.lblcategoryname.Name = "lblcategoryname";
            this.lblcategoryname.Size = new System.Drawing.Size(74, 13);
            this.lblcategoryname.TabIndex = 1;
            this.lblcategoryname.Text = "Section Name";
            // 
            // dgvCategory
            // 
            this.dgvCategory.AllowUserToAddRows = false;
            this.dgvCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCategory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategory.Location = new System.Drawing.Point(9, 95);
            this.dgvCategory.Name = "dgvCategory";
            this.dgvCategory.ReadOnly = true;
            this.dgvCategory.RowHeadersVisible = false;
            this.dgvCategory.Size = new System.Drawing.Size(265, 151);
            this.dgvCategory.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Location = new System.Drawing.Point(0, 308);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(289, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // frmCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 333);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmCategory";
            this.Text = "frmCategory";
            this.Load += new System.EventHandler(this.frmCategory_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblcat;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.TextBox uxcategory;
        private System.Windows.Forms.Label lblcategoryname;
        private System.Windows.Forms.DataGridView dgvCategory;
        private System.Windows.Forms.TextBox uxpercent;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStrip toolStrip1;
    }
}