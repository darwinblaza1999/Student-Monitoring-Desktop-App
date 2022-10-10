using Newtonsoft.Json;
using SMS.Class;
using SMS.Models;
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
    public partial class frmStudentForm : Form
    {
        public readonly IStudent student;
        public frmStudentForm()
        {
            InitializeComponent();
            student = new Student();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private async void frmStudentForm_Load(object sender, EventArgs e)
        {
            try
            {
                groupInfo.Enabled = false;
                cbostudentId.Enabled = false;
                cbostudentId.DataSource = null;
                DataHolder.button = "";

                var gettype = await student.ViewCategory("type");
                if(gettype.ResponseCode == 200)
                {
                    var getdata = JsonConvert.DeserializeObject<DataTable>(gettype.Data);
                    if(getdata.Rows.Count > 0)
                    {
                        cbotype.DataSource = getdata;
                        cbotype.ValueMember = "Type ID";
                        cbotype.DisplayMember = "TName";
                        cbotype.SelectedIndex = 0;
                    }
                }

                var getstatus = await student.ViewCategory("status");
                if(getstatus.ResponseCode == 200)
                {
                    var getdata = JsonConvert.DeserializeObject<DataTable>(getstatus.Data);
                    if (getdata.Rows.Count > 0)
                    {
                        cbostatus.DataSource = getdata;
                        cbostatus.ValueMember = "ID";
                        cbostatus.DisplayMember = "StatusName";
                        cbostatus.SelectedIndex = 0;
                    }
                }

                var getgrade = await student.ViewCategory("grade");
                if (getgrade.ResponseCode == 200)
                {
                    var getdata = JsonConvert.DeserializeObject<DataTable>(getgrade.Data);
                    if (getdata.Rows.Count > 0)
                    {
                        cbograde.DataSource = getdata;
                        cbograde.ValueMember = "Grade ID";
                        cbograde.DisplayMember = "Grade Level";
                        cbograde.SelectedIndex = 0;
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Exception error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            groupInfo.Enabled = true;
            cbostudentId.Enabled = false;
            DataHolder.button = "ADD";
        }

        private async void btnedit_Click(object sender, EventArgs e)
        {
            try
            {
                groupInfo.Enabled = true;
                cbostudentId.Enabled = true;
                DataHolder.button = "UPDATE";

                var getid = await student.ViewCategory("student");
                if(getid.ResponseCode == 200)
                {
                    var getdata = JsonConvert.DeserializeObject<DataTable>(getid.Data);
                    if(getdata.Rows.Count > 0)
                    {
                        cbostudentId.DataSource = getdata;
                        cbostudentId.DisplayMember = "Name";
                        cbostudentId.ValueMember = "ID";
                    }
                }
                else
                {
                    MessageBox.Show(getid.ResponseMessage, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Exception error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnrefresh_Click(object sender, EventArgs e)
        {
            frmStudentForm_Load(sender, e);
            Clear();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Clear()
        {
            uxfirstname.Text = "";
            uxmiddle.Text = "";
            uxlastname.Text = "";
            uxconNo.Text = "";
            uxaddress.Text = "";
            cbograde.SelectedIndex = 0;
            cbostatus.SelectedIndex = 0;
            cbotype.SelectedIndex = 0;
        }

        private async void btnsubmit_Click(object sender, EventArgs e)
        {
            try
            {
                var grade = cbograde.GetItemText(cbograde.SelectedValue);
                var status = cbostatus.GetItemText(cbostatus.SelectedValue);
                var type = cbotype.GetItemText(cbotype.SelectedValue);
                var stat = cbostatus.GetItemText(cbostatus.SelectedValue);
                var studentid = cbostudentId.GetItemText(cbostudentId.SelectedValue);
                if(DataHolder.button == "ADD")
                {
                    var model = new StudentModel();
                    model.firstname = uxfirstname.Text;
                    model.middlename = uxmiddle.Text;
                    model.lastname = uxlastname.Text;
                    model.gender = rmale.Checked == true ? "Male" : "Female";
                    model.address = uxaddress.Text;
                    model.conNo = uxconNo.Text;
                    model.gradelevel = Convert.ToInt32(grade);
                    model.type = Convert.ToInt32(type);

                    var result = await student.InsertStudent(model);
                    if(result.ResponseCode == 200)
                    {
                        MessageBox.Show("Successfully saved", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        frmStudentForm_Load(sender, e);
                        Clear();
                    }
                    else
                    {
                        MessageBox.Show(result.ResponseMessage, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else if(DataHolder.button == "UPDATE")
                {
                    var smodel = new PartialModel();
                    smodel.studentId = studentid;
                    smodel.firstname = uxfirstname.Text;
                    smodel.middlename = uxmiddle.Text;
                    smodel.lastname = uxlastname.Text;
                    smodel.gender = rmale.Checked == true ? "Male" : "Female";
                    smodel.address = uxaddress.Text;
                    smodel.conNo = uxconNo.Text;
                    smodel.gradelevel = Convert.ToInt32(grade);
                    smodel.type = Convert.ToInt32(type);
                    smodel.status = Convert.ToInt32(stat);

                    var result = await student.UpdateStudent(smodel);
                    if (result.ResponseCode == 200)
                    {
                        MessageBox.Show("Successfully updated", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        frmStudentForm_Load(sender, e);
                        Clear();
                    }
                    else
                    {
                        MessageBox.Show(result.ResponseMessage, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Please select button first!");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Exception error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
