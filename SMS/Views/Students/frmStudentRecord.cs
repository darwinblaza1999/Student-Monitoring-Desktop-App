using Newtonsoft.Json;
using SMS.Class;
using SMS.Repository;
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
    public partial class frmStudentRecord : Form
    {
        public readonly IStudent student;
        public frmStudentRecord()
        {
            InitializeComponent();
            student = new Student();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private async void frmStudentRecord_Load(object sender, EventArgs e)
        {
            try
            {
                //Get grade
                var grade = await student.ViewCategory("grade");
                if(grade.ResponseCode == 200)
                {
                    var dtresult = JsonConvert.DeserializeObject<DataTable>(grade.Data);
                    if(dtresult.Rows.Count > 0)
                    {
                        cbograde.DataSource = dtresult;
                        cbograde.DisplayMember = "Grade Level";
                        cbograde.ValueMember = "Grade ID";
                    }
                }

                //Get section
                var section = await student.ViewCategory("section");
                if (section.ResponseCode == 200)
                {
                    var dtresult = JsonConvert.DeserializeObject<DataTable>(section.Data);
                    if (dtresult.Rows.Count > 0)
                    {
                        cbosection.DataSource = dtresult;
                        cbosection.DisplayMember = "Section";
                        cbosection.ValueMember = "Section ID";
                    }
                }

                //Get subject
                var subject = await student.ViewCategory("subject");
                if (subject.ResponseCode == 200)
                {
                    var dtresult = JsonConvert.DeserializeObject<DataTable>(subject.Data);
                    if (dtresult.Rows.Count > 0)
                    {
                        cbosubject.DataSource = dtresult;
                        cbosubject.DisplayMember = "Subject";
                        cbosubject.ValueMember = "Subject ID";
                    }
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Exception error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
