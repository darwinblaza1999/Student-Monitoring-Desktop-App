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

namespace SMS.Views.Access
{
    public partial class frmAccessRights : Form
    {
        private readonly IAccess access;
        private readonly IUser user;
        public frmAccessRights()
        {
            InitializeComponent();
            access = new AccessRights();
            user = new User();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private async void btnsystem_Click(object sender, EventArgs e)
        {
            try
            {
                var sysname = cbosystem.Text;
                var res = await access.InsertSystemName(0, sysname, "sys");
                if(res.ResponseCode == 200)
                {
                    MessageBox.Show("Successfully added!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmAccessRights_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Failed!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Exception error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnmodule_Click(object sender, EventArgs e)
        {
            try
            {
                var sysname = cbomodule.Text;
                var res = await access.InsertSystemName(1, sysname, "mod");
                if (res.ResponseCode == 200)
                {
                    MessageBox.Show("Successfully added!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmAccessRights_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Failed!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Exception error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void frmAccessRights_Load(object sender, EventArgs e)
        {
            try
            {
                //Get Position Name
                var position = await user.GetPosition();
                if (position.ResponseCode == 200)
                {
                    var dtpos = JsonConvert.DeserializeObject<DataTable>(position.Data);
                    if (dtpos.Rows.Count > 0)
                    {
                        cboposition.DataSource = dtpos;
                        cboposition.DisplayMember = "Pos";
                        cboposition.ValueMember = "pid";
                    }
                }


                //Get System Name
                var system = await access.ViewAccessRights(0,"sys");
                if(system.ResponseCode == 200)
                {
                    var dtresult = JsonConvert.DeserializeObject<DataTable>(system.Data);
                    if(dtresult.Rows.Count > 0)
                    {
                        cbomodule.DataSource = dtresult;
                        cbomodule.ValueMember = "System ID";
                        cbomodule.DisplayMember = "System Name";

                        dgvSystem.DataSource = null;
                        dgvSystem.Columns.Clear();
                        dgvSystem.DataSource = dtresult;

                        DataGridViewCheckBoxColumn chck = new DataGridViewCheckBoxColumn();
                        chck.ValueType = typeof(bool);
                        chck.Name = "check";
                        chck.HeaderText = "IsAllowed";
                        dgvSystem.Columns.Insert(0, chck);
                    }
                }
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Exception error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void cbomodule_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //Get module
                var getsysID = cbomodule.GetItemText(cbomodule.SelectedValue);
                if (getsysID != "System.Data.DataRowView")
                {
                    var sysID = getsysID == "" ? "0" : getsysID;
                    var module = await access.ViewAccessRights(Convert.ToInt32(sysID), "mod");
                    if (module.ResponseCode == 200)
                    {
                        var dtresult = JsonConvert.DeserializeObject<DataTable>(module.Data);
                        if (dtresult.Rows.Count > 0)
                        {
                            dgvModule.DataSource = null;
                            dgvModule.Columns.Clear();
                            dgvModule.DataSource = dtresult;

                            DataGridViewCheckBoxColumn chck = new DataGridViewCheckBoxColumn();
                            chck.ValueType = typeof(bool);
                            chck.Name = "check";
                            chck.HeaderText = "IsAllowed";
                            dgvModule.Columns.Insert(0, chck);
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Exception error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                if(dgvSystem.Rows.Count > 0)
                {
                    foreach (DataGridViewRow row in dgvSystem.Rows)
                    {
                        var syscheck = row.Cells[0] as DataGridViewCheckBoxCell;
                        if(Convert.ToBoolean(syscheck.Value) == true)
                        {

                        }
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Exception error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void dgvSystem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)dgvModule.Rows[e.RowIndex].Cells[0];
                var val = chk.Value;
                if (chk.Value == chk.TrueValue)
                {
                    dgvModule.Rows[e.RowIndex].Cells[0].Value = chk.FalseValue;
                }
                else
                {
                    dgvModule.Rows[e.RowIndex].Cells[0].Value = chk.TrueValue;
                }
            }
        }

        private void dgvModule_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex == 0)
            {
                DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)dgvModule.Rows[e.RowIndex].Cells[0];
                var val = chk.Value;
                if (chk.Value == chk.TrueValue)
                {
                    dgvModule.Rows[e.RowIndex].Cells[6].Value = chk.FalseValue;
                }
                else
                {
                    dgvModule.Rows[e.RowIndex].Cells[6].Value = chk.TrueValue;
                }
            }
        }
    }
}
