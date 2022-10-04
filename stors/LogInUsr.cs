using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StorSystem.stors
{
    public partial class LogInUsr : Form
    {

        SysData.User _usr;
        SysData.DbCntxt1 db;
        public LogInUsr()
        {
            InitializeComponent();
           db = new SysData.DbCntxt1();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (UsrId.Text.Length > 3 && UsrPass.Text.Length > 3) {
                _usr = db.Users.FirstOrDefault((usr) => usr.user_login.ToUpper() == UsrId.Text.ToUpper() && usr.user_pass.ToUpper() == UsrPass.Text.ToUpper());
                if (_usr != null)
                {
                    this.DialogResult = DialogResult.OK;
                    Program.CurrentUser = _usr;
                    
                }
                else {
                    this.DialogResult = DialogResult.Cancel;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
