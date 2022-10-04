using StorSystem.Init;
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
    public partial class StorMain : Form
    {
        public StorMain()
        {
            InitializeComponent();
        }
        Form _frm;
        private void btn_frm_opr_str_6_Click(object sender, EventArgs e)
        {
            if (!Core.Permessions.canRead())
            {
                MessageBox.Show(" لا تمتلكـ صلاحية فتح الشاشة وقراءة البيانات  ");
                return;
            }

            _frm = new trnrs_window();
            _frm.Show();
        }

        private void btn_init_str_Click(object sender, EventArgs e)
        {
            if (!Core.Permessions.canRead())
            {
                MessageBox.Show(" لا تمتلكـ صلاحية فتح الشاشة وقراءة البيانات  ");
                return;
            }
            _frm = new Init.Init_Stor_004();
            _frm.Show();
             
        }

        private void btn_init_prod_Click(object sender, EventArgs e)
        {
            if (!Core.Permessions.canRead())
            {
                MessageBox.Show(" لا تمتلكـ صلاحية فتح الشاشة وقراءة البيانات  ");
                return;
            }
            _frm = new Init.Init_prd_001();
            _frm.Show();
        }

        private void btn_init_typs_Click(object sender, EventArgs e)
        {
            if (!Core.Permessions.canRead())
            {
                MessageBox.Show(" لا تمتلكـ صلاحية فتح الشاشة وقراءة البيانات  ");
                return;
            }
            _frm = new Init.Init_typs_002();
            _frm.Show();
        }

        private void btn_init_ctgry_Click(object sender, EventArgs e)
        {
            if (!Core.Permessions.canRead())
            {
                MessageBox.Show(" لا تمتلكـ صلاحية فتح الشاشة وقراءة البيانات  ");
                return;
            }
            _frm = new Init.Init_ctgry_003();
            _frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!Core.Permessions.canRead())
            {
                MessageBox.Show(" لا تمتلكـ صلاحية فتح الشاشة وقراءة البيانات  ");
                return;
            }
            _frm = new Qry.Qry_ordrs_001();
            _frm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!Core.Permessions.canRead())
            {
                MessageBox.Show(" لا تمتلكـ صلاحية فتح الشاشة وقراءة البيانات  ");
                return;
            }

            _frm = new Init.Init_cmpny_001();
            _frm.Show();
        }

        private void StorMain_Load(object sender, EventArgs e)
        {
            _frm = new LogInUsr();
            if (_frm.ShowDialog() == DialogResult.OK) {
                _frm.Hide();
            } else {
                this.Dispose();
                
            }
        }

        private void btn_sec_usrs_Click(object sender, EventArgs e)
        {
            if (!Core.Permessions.isAdmin())
            {
                MessageBox.Show("لايمكن الدخول هنا لغير الادمن ");
                return;
            }
            _frm = new Init.Init_usrs_prm_001();
            _frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
         if (!Core.Permessions.canRead())
            {
                MessageBox.Show(" لا تمتلكـ صلاحية فتح الشاشة وقراءة البيانات  ");
                return;
            }
            _frm = new Init.std_actvtis();
            _frm.Show();
        }
    }
}
