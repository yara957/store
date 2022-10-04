using StorSystem.SysData;
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
    public partial class Init_Stor_004 : StorSystem.Core.ClscScurUserInterface
    {
        
        private SysData.Stor obj;
        private List<SysData.Stor> Alldata;

        public Init_Stor_004()
        {
            InitializeComponent();
        }
        protected override bool InitData()
        {
            base.InitData();
            obj = new SysData.Stor();
            this.FildsToShow = new List<Control>();
            this.FildsToShow.AddRange(new List<Control>() { txt_str_desc,txt_str_id,txt_str_location,txt_str_name,chk_str_status,cmb_str_usr_id, DgvProds });
            this.buttons.AddRange(new List<Button>() { BtnNew, BtnSave, BtnSearch, BtnDelete });
            if (this.db != null)
            {
                usr_i.DisplayMember = "user_name";
                usr_i.ValueMember = "user_id";
                usr_i.DataSource = db.Users.AsParallel().ToList();
            }
            return true;
        }

        protected override bool SearchData()
        {
            Alldata = new List<SysData.Stor>();
            Alldata = db.Stors.AsNoTracking().ToList();
            if (Alldata != null && Alldata.Count > 0)
            {
                DgvProds.DataSource = Alldata;
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

            int _id = 0;
            if (int.TryParse(txt_str_id.Text, out _id))

            obj = db.Stors.FirstOrDefault((obj) => obj.str_id == _id);
            if (obj == null)
            {
                obj = new SysData.Stor();
            }

             
            obj.str_name = txt_str_name.Text;
            obj.str_desc = txt_str_desc.Text;
            obj.str_location = txt_str_location.Text;
             obj.str_usr_id = cmb_str_usr_id.SelectedIndex>-1? (int) cmb_str_usr_id.SelectedValue:0;
            obj.str_status = chk_str_status.Checked ? 1 : 0;
 
            if (obj.str_id > 0)
            {
                db.Stors.Attach(obj);
                db.Entry(obj).State = System.Data.Entity.EntityState.Modified;
            }
            else
            {

                db.Stors.Add(obj);
            }

            return db.SaveChanges() > 0 ? true : false;
        }
        protected override bool DeleteRecord()
        {
            try
            {
                int _id = int.Parse(txt_str_id.Text);

                obj = db.Stors.FirstOrDefault((p) => p.str_id == _id);
                if (obj != null)
                {
                    db.Stors.Remove(obj);
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
        private void ShowObj(SysData.Stor obj)
        {
            try
            {

                txt_str_id.Text = obj.str_id.ToString();
                txt_str_name.Text = obj.str_name;
                txt_str_desc.Text = obj.str_desc;
                txt_str_location.Text = obj.str_location;
                 cmb_str_usr_id.SelectedValue = obj.str_usr_id;
                chk_str_status.Checked = obj.str_status == 1 ? true : false;
                BtnDelete.Enabled = true;
                BtnSave.Enabled = true;
            }
            catch { }
        }
        private void DgvProds_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                int _id = -1;
                for (int i = 0; i < DgvProds.Rows.Count; i++)
                {
                    if (int.TryParse(DgvProds.Rows[e.RowIndex].Cells[prod_id.Name].Value.ToString(), out _id))
                       if (Alldata.ElementAt(i).str_id == _id)
                       {
                           obj = Alldata.ElementAt(i);
                           ShowObj(obj);
                       }
                }

            }
            catch (Exception ex) { }
        }

        private void DgvProds_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }
    }
}