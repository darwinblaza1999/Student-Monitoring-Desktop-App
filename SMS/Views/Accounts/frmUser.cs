using Dapper;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using SMS.Class;
using SMS.Models;
using SMS.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMS.Views.Accounts
{
    public partial class frmUser : Form
    {
        private IUser user;
        private ILogger logs;
        public frmUser()
        {
            InitializeComponent();
            //this.adapter = adapter;
            //this.logs = logger;
            user = new User();
        }
        //private User user = new User();
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var model = new UserModel();
                model.fname = uxfname.Text.Trim();
                model.lastname = uxlname.Text.Trim();
                model.address = uxaddress.Text.Trim();
                model.email = uxemail.Text.Trim();
                model.ConNo = uxconNo.Text.Trim();
                model.position = cboPos.GetItemText(cboPos.SelectedValue);
                model.status = rActive.Checked == true ? 1 : 2;

                if(uxfname.Text != "" || uxlname.Text != "" || uxaddress.Text != "" || uxemail.Text != "")
                {
                    if(cboPos.SelectedIndex != 0)
                    {
                        var data = await user.InsertUser(model);
                        if (data.ResponseCode == 200)
                        {
                            MessageBox.Show("Successfully Saved!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Clear();
                            frmUser_Load(sender, e);
                        }
                        else
                        {
                            MessageBox.Show("Failed to insert, " + data.ResponseMessage, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please select position!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Please input the required fields!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Exception error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Clear()
        {
            uxfname.Text = "";
            uxlname.Text = "";
            uxaddress.Text = "";
            uxemail.Text = "";
            txtsearch.Text = "";
            uxconNo.Text = "";
        }

        private async void frmUser_Load(object sender, EventArgs e)
        {
            try
            {
                #region Get User records
                var data = await user.GetUser();
                if (data.ResponseCode == 200)
                {
                    DataHolder.dtuser = new DataTable();
                    DataHolder.dtuser = JsonConvert.DeserializeObject<DataTable>(data.Data);
                    dgvRecord.DataSource = null;
                    dgvRecord.DataSource = DataHolder.dtuser;
                }
                else
                {
                    MessageBox.Show("No user found, " + data.ResponseMessage, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                #endregion
                #region Get Position
                var posdata = await user.GetPosition();
                if (posdata.ResponseCode == 200)
                {
                    var dtpos = JsonConvert.DeserializeObject<DataTable>(posdata.Data);

                    DataRow row = dtpos.NewRow();
                    row["Pos"] = "--Please select--";
                    dtpos.Rows.InsertAt(row, 0);

                    cboPos.DataSource = dtpos;
                    cboPos.DisplayMember = "Pos";
                    cboPos.ValueMember = "pid";
                    cboPos.SelectedIndex = 0;
                }
                #endregion
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnrefresh_Click(object sender, EventArgs e)
        {
            frmUser_Load(sender, e);
            Clear();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtsearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                try
                {

                    if (DataHolder.dtuser.Columns.Count > 0)
                    {
                        DataView dv = new DataView();
                        dv = DataHolder.dtuser.DefaultView;
                        if (txtsearch.Text == "")
                        {
                            dgvRecord.DataSource = dv;
                        }
                        else
                        {
                            dv.RowFilter = "ID LIKE '" + txtsearch.Text.Trim() + "'";
                            dgvRecord.DataSource = dv;
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
}
