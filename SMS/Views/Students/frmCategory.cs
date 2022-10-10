using Newtonsoft.Json;
using SMS.Class;
using SMS.Models;
using SMS.Repository;
using System;
using System.Data;
using System.Windows.Forms;

namespace SMS.Views.Students
{
    public partial class frmCategory : Form
    {
        private readonly IStudent student;
        private readonly string type;
        public frmCategory(string type)
        {
            InitializeComponent();
            student = new Student();
            this.type = type;
        }

        private async void frmCategory_Load(object sender, EventArgs e)
        {
            try
            {
                var res = new ServiceResponse<string>();
                if(type == "section")
                {
                     res = await student.ViewCategory("section");
                    lblcat.Text = "SECTION";
                    lblcategoryname.Text = "Section Name";
                }
                else if(type == "subject")
                {
                    res = await student.ViewCategory("subject");
                    lblcat.Text = "SUBJECT";
                    lblcategoryname.Text = "Subject Name";
                }
                else if(type == "grade")
                {
                    res = await student.ViewCategory("grade");
                    lblcat.Text = "GRADE";
                    lblcategoryname.Text = "Grade Name";
                }
                else if(type == "component")
                {
                    res = await student.ViewCategory("component");
                    lblcat.Text = "COMPONENT";
                    lblcategoryname.Text = "Component Name";
                    uxpercent.Enabled =  true;
                }

                if(res.ResponseCode == 200)
                {
                    var resdata = JsonConvert.DeserializeObject<DataTable>(res.Data);
                    if(resdata.Rows.Count > 0)
                    {
                        dgvCategory.DataSource = null;
                        dgvCategory.DataSource = resdata;
                    }
                }
                else
                {
                    MessageBox.Show(res.ResponseMessage, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Exception error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnadd_Click(object sender, EventArgs e)
        {
            try
            {
                var result = new ServiceResponse<object>();
                var name = uxcategory.Text;
                var percent = uxpercent.Text;

                if(type == "section")
                {
                     result = await student.InsertCategory(name, "", "section");
                }
                else if(type == "subject")
                {
                    result = await student.InsertCategory(name, "", "subject");
                }
                else if(type == "component")
                {
                    result = await student.InsertCategory(name, percent, "component");
                }
                else if(type == "grade")
                {
                    result = await student.InsertCategory(name, "", "grade");
                }

                if(result.ResponseCode == 200)
                {
                    MessageBox.Show("Successfully saved", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmCategory_Load(sender, e);
                    uxcategory.Text = "";
                    uxpercent.Text = "";
                }
                else
                {
                    MessageBox.Show("Failed to add new record!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Exception error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
