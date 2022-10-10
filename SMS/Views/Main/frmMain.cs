using SMS.Views.Access;
using SMS.Views.Accounts;
using SMS.Views.Students;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMS.Views.Main
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void addStudentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmstudent = new frmStudentForm();
            frmstudent.Show();
        }

        private void addSectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmcategory = new frmCategory("section");
            frmcategory.Show();
        }

        private void addSubjetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmcategory = new frmCategory("subject");
            frmcategory.Show();
        }

        private void addYearLevelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmcategory = new frmCategory("grade");
            frmcategory.Show();
        }

        private void addComponentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmcategory = new frmCategory("component");
            frmcategory.Show();
        }

        private void viewStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmViewStudent = new frmStudentRecord();
            frmViewStudent.Show();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void accessRightsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmAccess = new frmAccessRights();
            frmAccess.Show();
        }

        private void registerUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmuser = new frmUser();
            frmuser.Show();
        }

        private void updatePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmsecurity = new frmSecurity();
            frmsecurity.Show();
        }

        private void viewUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmuser = new frmUser();
            frmuser.Show();
        }
    }
}
