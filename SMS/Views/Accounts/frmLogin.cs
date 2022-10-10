using Newtonsoft.Json;
using SMS.Class;
using SMS.Repository;
using SMS.Views.Main;
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
    public partial class frmLogin : Form
    {
        private  readonly IAccount account;
        public frmLogin()
        {
            InitializeComponent();
            account = new Account();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private async void btnlogin_Click(object sender, EventArgs e)
        {
            try
            {
                var uname = uxuname.Text.Trim();
                var upass = uxpassword.Text.Trim();
                if(uname != "" && upass != "")
                {
                    var getdata = await account.Login(uname, upass);
                    if(getdata.ResponseCode == 200)
                    {
                        var resdata = JsonConvert.DeserializeObject<DataTable>(getdata.Data);

                        MessageBox.Show("Successfully login!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //this.Close();

                        var frmlog = new frmMain();
                        frmlog.Show();
                        

                    }
                    else
                    {
                        MessageBox.Show("Login " + getdata.ResponseMessage, "Warning", MessageBoxButtons.OK ,MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
