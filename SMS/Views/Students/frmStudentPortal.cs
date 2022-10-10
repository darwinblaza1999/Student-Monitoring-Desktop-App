using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMS.Views.Students
{
    public partial class frmStudentPortal : Form
    {
        public frmStudentPortal()
        {
            InitializeComponent();
        }

        private void btngrade_Click(object sender, EventArgs e)
        {
            var frmcategory = new frmCategory("grade");
            frmcategory.ShowDialog();
        }

        private void btnsection_Click(object sender, EventArgs e)
        {
            var frmcategory = new frmCategory("section");
            frmcategory.ShowDialog();
        }

        private void btnsubject_Click(object sender, EventArgs e)
        {
            var frmcategory = new frmCategory("subject");
            frmcategory.ShowDialog();
        }

        private void btnscore_Click(object sender, EventArgs e)
        {

        }

        private void btncomponent_Click(object sender, EventArgs e)
        {
            var frmcategory = new frmCategory("component");
            frmcategory.ShowDialog();
        }

        private void btnstudent_Click(object sender, EventArgs e)
        {
            var frmstudent = new frmStudentForm();
            frmstudent.ShowDialog();
        }
    }
}
