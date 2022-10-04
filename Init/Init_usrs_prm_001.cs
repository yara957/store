using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace StorSystem.Init
{
    public partial class Init_usrs_prm_001 : StorSystem.Core.ClscScurUserInterface
    {

        private SysData.User obj;
        private List<SysData.User> Alldata;

        public Init_usrs_prm_001()
        {
            InitializeComponent();
        }

        protected override bool InitData()
        {
            base.InitData();
            this.FildsToShow = new List<Control>();
            this.FildsToShow.AddRange(new List<Control>() { txt_user_id, txt_user_login, txt_user_name,
                chk_prm_add, chk_prm_admn, chk_prm_read, dgv_all,chk_prm_rmov,chk_prm_updt,chk_user_stat });
            this.buttons.AddRange(new List<Button>() { BtnNew, BtnSave, BtnSearch, BtnDelete });
            if (this.db != null)
            {
            }
            return true;
        }

        protected override bool SearchData()
        {
            Alldata = new List<SysData.User>();
            Alldata = db.Users.AsNoTracking().ToList();
            if (Alldata != null && Alldata.Count > 0)
            {
                dgv_all.DataSource = Alldata;
                return true;
            }
            else
            {
                return false;
            }
        }
        #region OverrideFuns
        protected override bool SaveData()
        {

            int UsrId = 0;

            int.TryParse(txt_user_id.Text, out UsrId);

            obj = db.Users.FirstOrDefault((obj) => obj.user_id == UsrId);
            if (obj == null)
            {
                obj = new SysData.User();
                obj.user_pass = Core.Permessions._DFLT_USR_PASS;
            }


            obj.user_login = txt_user_login.Text;
            obj.user_name = txt_user_name.Text;
            obj.user_status = chk_user_stat.Checked?1:0;
            obj.user_role = readUsrPerm();

            if (obj.user_id > 0)
            {
                db.Users.Attach(obj);
                db.Entry(obj).State = System.Data.Entity.EntityState.Modified;
            }
            else
            {

                db.Users.Add(obj);
            }

            return db.SaveChanges() > 0 ? true : false;
        }

        private string readUsrPerm() {
            string _prmsns = "";
            if (chk_prm_add.Checked ==true)
                _prmsns = $"{_prmsns} , {Core.Permessions._ADD_PERMESSION} ";

            if (chk_prm_admn.Checked == true)
                _prmsns = $"{_prmsns} , {Core.Permessions._ADMIN_PERMESSION} ";

            if (chk_prm_read.Checked == true)
                _prmsns = $"{_prmsns} , {Core.Permessions._READ_PERMESSION} ";

            if (chk_prm_updt.Checked == true)
                _prmsns = $"{_prmsns} , {Core.Permessions._UPDATE_PERMESSION} ";
            
            if (chk_prm_rmov.Checked == true)
                _prmsns = $"{_prmsns} , {Core.Permessions._REMOVE_PERMESSION} ";


            return _prmsns;
        }

        private void writeUsrPrmsns()
        {
            chk_prm_rmov.Checked = false;
            chk_prm_read.Checked = false;
            chk_prm_add.Checked = false;
            chk_prm_admn.Checked = false;
            chk_prm_updt.Checked = false;

            if (obj == null)
                return;
            if (string.IsNullOrEmpty(obj.user_role))
                return;

            if (obj.user_role.Contains(Core.Permessions._REMOVE_PERMESSION))
                chk_prm_rmov.Checked = true;
            if (obj.user_role.Contains(Core.Permessions._READ_PERMESSION))
                chk_prm_read.Checked = true;
            if (obj.user_role.Contains(Core.Permessions._ADD_PERMESSION))
                chk_prm_add.Checked = true;
            if (obj.user_role.Contains(Core.Permessions._ADMIN_PERMESSION))
                chk_prm_admn.Checked = true;
            if (obj.user_role.Contains(Core.Permessions._UPDATE_PERMESSION))
                chk_prm_updt.Checked = true; 

        }
        protected override bool DeleteRecord()
        {
            try
            {
                int _id = int.Parse(txt_user_id.Text);

                obj = db.Users.FirstOrDefault((p) => p.user_id == _id);
                if (obj != null)
                {
                    db.Users.Remove(obj);
                    db.Entry(obj).State = System.Data.Entity.EntityState.Deleted;
                    return db.SaveChanges() > 0 ? true : false;
                }
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        #endregion
        private void ShowObj(SysData.User obj)
        {
            try
            {

                txt_user_id.Text = obj.user_id.ToString();
                txt_user_login.Text = obj.user_login;
                txt_user_name.Text = obj.user_name;
                chk_user_stat.Checked =obj.user_status==1?true:false;
                writeUsrPrmsns();
                BtnDelete.Enabled = true;
                BtnSave.Enabled = true;
            }
            catch { }
        }
        private void DgvProds_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                int UsrId = -1;
                int.TryParse(dgv_all.Rows[e.RowIndex].Cells[user_id.Name].Value.ToString(), out UsrId);
                obj = db.Users.FirstOrDefault((obj) => obj.user_id == UsrId);
                ShowObj(obj);
            }
            catch (Exception ex) {
            }
        }

        private void DgvProds_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }

        private void dgv_all_RowEnter(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
