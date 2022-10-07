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

namespace SMS.Views.Accounts
{
    public partial class frmSecurity : Form
    {
        private readonly IUser user;
        public frmSecurity()
        {
            InitializeComponent();
            user = new User();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private async void frmSecurity_Load(object sender, EventArgs e)
        {
            try
            {
                var res = await user.GetUserId();
                if(res.ResponseCode == 200)
                {
                    var dtres = JsonConvert.DeserializeObject<DataTable>(res.Data);
                    cbouserId.DataSource = dtres;
                    cbouserId.DisplayMember = "UserId";
                    cbouserId.ValueMember = "UserId";
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Exception error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void cbouserId_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var userid = cbouserId.GetItemText(cbouserId.SelectedValue);
                var res = await user.GetUserByUserId(userid);
                if(res.ResponseCode == 200)
                {
                    var dtres = JsonConvert.DeserializeObject<DataTable>(res.Data);
                    if(dtres.Rows.Count > 0)
                    {
                        foreach (DataRow item in dtres.Rows)
                        {
                            cbotype.Text = item["Type"].ToString();
                            uxuname.Text = item["username"].ToString();
                            uxoldpass.Text = item["Password"].ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Clear()
        {
            uxpassword.Text = "";
            uxcpass.Text = "";
        }

        private async void btnreset_Click(object sender, EventArgs e)
        {
            try
            {
                var usermodel = new UserDetail();
                usermodel.UserId = cbouserId.GetItemText(cbouserId.SelectedValue);
                usermodel.username = uxuname.Text;
                usermodel.password = uxpassword.Text;
                usermodel.type = "RESET";
                usermodel.UDT = DateTime.Now;

                if (Validate() == true)
                {
                    var result = await user.UpdatePassword(usermodel);
                    if (result.ResponseCode == 200)
                    {
                        MessageBox.Show("Successfully updated password!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        frmSecurity_Load(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Failed to updated password, " + result.ResponseMessage, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Exception error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnsubmit_Click(object sender, EventArgs e)
        {
            try
            {
                var usermodel = new UserDetail();
                usermodel.UserId = cbouserId.GetItemText(cbouserId.SelectedValue);
                usermodel.username = uxuname.Text;
                usermodel.password = uxpassword.Text;
                usermodel.type = "UPDATE";
                usermodel.UDT = DateTime.Now;

                if (Validate() == true)
                {
                    var result = await user.UpdatePassword(usermodel);
                    if (result.ResponseCode == 200)
                    {
                        MessageBox.Show("Successfully updated password!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        frmSecurity_Load(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Failed to updated password, " + result.ResponseMessage, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Exception error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool Validate()
        {
            bool ret = false;
            if(uxoldpass.Text.Trim() == uxpassword.Text.Trim())
            {
                MessageBox.Show("Invalid password, password already used!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                 ret = false;
            }
            else if(uxpassword.Text.Trim() != uxcpass.Text.Trim())
            {
                MessageBox.Show("Invalid password, passwword cannot match!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                 ret = false;
            }
            else
            {
                ret = true;
            }
            return ret;
        }
    }
}
