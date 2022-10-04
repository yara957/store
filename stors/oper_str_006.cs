using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace StorSystem.stors
{
    public partial class oper_str_006 : StorSystem.Core.ClscScurUserInterface
    {
        private SysData.storOrder ordr;
        private List<SysData.StorOrderDetail> ordrDtls;

        private List<SysData.storOrder> Alldata;

        public oper_str_006()
        {
            InitializeComponent();
        }

        protected override bool InitData()
        {
            base.InitData();
            ordr = new SysData.storOrder();
            this.FildsToShow = new List<Control>();
            this.FildsToShow.AddRange(new List<Control>() { txt_ordr_dsc,txt_ordr_id,cmb_ordr_usr,cmb_str_id,rdo_ordr_typ_out_2,rdo_ordr_typ_in_1,dgv_ordr_dtls, DgvProds });
            this.buttons.AddRange(new List<Button>() { BtnNew, BtnSave, BtnSearch, BtnDelete });
            if (this.db != null)
            {
                cmb_ordr_usr.DisplayMember = "cmpny_name";
                cmb_ordr_usr.ValueMember = "id";
                cmb_ordr_usr.DataSource = db.Companies.AsParallel().ToList();

                ordr_usr.DisplayMember = "user_name";
                ordr_usr.ValueMember = "user_id";
                ordr_usr.DataSource = db.Users.AsParallel().ToList();
                 

                //---
                cmb_str_id.DisplayMember = "str_name";
                cmb_str_id.ValueMember = "str_id";
                cmb_str_id.DataSource = db.Stors.AsParallel().ToList();

                str_id.DisplayMember = "str_name";
                str_id.ValueMember = "str_id";
                str_id.DataSource = db.Stors.AsParallel().ToList();

                c_prod_id.DisplayMember = "prod_aname";
                c_prod_id.ValueMember = "prod_id";
                c_prod_id.DataSource = db.Products.AsParallel().ToList();

                ordr_type.DisplayMember = "flg_desc";
                ordr_type.ValueMember = "flg_value";
                ordr_type.DataSource = db.SysFlags.Where((flg)=>flg.flg_code.ToUpper().Equals("ORDR_TYPE".ToUpper())) .AsParallel().ToList();

                ordr_status.DisplayMember = "flg_desc";
                ordr_status.ValueMember = "flg_value";
                ordr_status.DataSource = db.SysFlags.Where((flg) => flg.flg_code.ToUpper().Equals("ORDR_STATUS".ToUpper())).AsParallel().ToList();

                cmb_ordr_status.DisplayMember = "flg_desc";
                cmb_ordr_status.ValueMember = "flg_value";
                cmb_ordr_status.DataSource = db.SysFlags.Where((flg) => flg.flg_code.ToUpper().Equals("ORDR_STATUS".ToUpper())).AsParallel().ToList();


            }
            return true;
        }

        protected override bool SearchData()
        {
            Alldata = new List<SysData.storOrder>();
            Alldata = db.storOrders.AsParallel().ToList();
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
            try
            {

 
            if (cmb_str_id.SelectedIndex < 0 || cmb_ordr_usr.SelectedIndex < 0 || txt_ordr_dsc.Text.Length <= 0) {
                MessageBox.Show("يرجى ادخال كافة البيانات وبشكل صحيح ");
                return false;
            }
            
            cmb_ordr_status.SelectedIndex = cmb_ordr_status.SelectedIndex >= 0 ? cmb_ordr_status.SelectedIndex : 0;

            int _id = 0;
            ordr = null;
            if (int.TryParse(txt_ordr_id.Text, out _id))
                ordr = db.storOrders.FirstOrDefault((obj) => obj.ordr_id == _id);
            if (ordr == null)
            {
                ordr = new SysData.storOrder();
            }

           //ordr.ordr_id = _id;
           ordr.str_id = int.Parse(cmb_str_id.SelectedValue.ToString());
           ordr.ordr_dsc = txt_ordr_dsc.Text;
           ordr.ordr_dt = dt_ordr_dt.Value;
           ordr.ordr_type = rdo_ordr_typ_in_1.Checked ? 1 : 2;
           ordr.ordr_usr =  (int) (cmb_ordr_usr.SelectedIndex>=0 ? cmb_ordr_usr.SelectedValue:0);
           ordr.ordr_status = (int)(cmb_ordr_status.SelectedIndex>=0? int.Parse( cmb_ordr_status.SelectedValue.ToString()):0);


            if (ordr.ordr_id > 0)
            {
                db.storOrders.Attach(ordr);
                db.Entry(ordr).State = System.Data.Entity.EntityState.Modified;
            }
            else
            {
                //_id = db.storOrders.Max((p) => p.ordr_id) + 1;
                //ordr.ordr_id = _id;
                db.storOrders.Add(ordr);
            }
                //MessageBox.Show("" + ordr.ordr_id);
                //db.SaveChanges();
                //db = new SysData.DbCntxt();
                ordrDtls = new List<SysData.StorOrderDetail>();
            for (int i = 0; i < dgv_ordr_dtls.Rows.Count; i++)
            {
                try
                {
                    if (dgv_ordr_dtls.Rows[i].IsNewRow)
                        continue;

                    if (dgv_ordr_dtls.Rows[i].Cells[c_prod_id.Name].Value == null || dgv_ordr_dtls.Rows[i].Cells[c_prod_qt.Name].Value == null)
                    {
                        MessageBox.Show("خطاء في البيانات المدخلة ");
                        return false;
                    }

                    int _recSer = 0;
                    _recSer = (int)(dgv_ordr_dtls.Rows[i].Cells[c_rec_ser.Name].Value != null ? dgv_ordr_dtls.Rows[i].Cells[c_rec_ser.Name].Value : 0);
                    SysData.StorOrderDetail _dtl = ordr.StorOrderDetails.FirstOrDefault((x) => x.rec_ser == _recSer);
                    if (_dtl == null)
                        _dtl = new SysData.StorOrderDetail();

                     _dtl.ordr_id = ordr.ordr_id;
                    _dtl.rec_ser = (int)(dgv_ordr_dtls.Rows[i].Cells[c_rec_ser.Name].Value != null ? dgv_ordr_dtls.Rows[i].Cells[c_rec_ser.Name].Value : 0);
                    _dtl.prod_id = (int)dgv_ordr_dtls.Rows[i].Cells[c_prod_id.Name].Value;
                     _dtl.prod_qt = int.Parse(dgv_ordr_dtls.Rows[i].Cells[c_prod_qt.Name].Value.ToString());
               

                    if (_dtl.rec_ser <= 0)
                    {
                            //db.StorOrderDetails.Add(_dtl);
                            ordrDtls.Add(_dtl);
                    }
                    else
                    {
                        db.Entry(_dtl).State = EntityState.Modified;
                        db.StorOrderDetails.Attach(_dtl);
                    }
                 }
                catch (Exception exx)
                {
                    MessageBox.Show($"Error {exx.Message}");
                    return false;
                }
            }

                //var z =    db.SaveChanges();
                //   return false;

                foreach (var item in ordrDtls)
                {
                    db.StorOrderDetails.Add(item);
                }
            return db.SaveChanges() > 0 ? true : false;

            }
            catch (Exception xp)
            {
                MessageBox.Show(" Error "+ xp.Message);
                return false;
            }
        }
        protected override bool DeleteRecord()
        {
            try
            {
                int _id = int.Parse(txt_ordr_id.Text);

                if (int.Parse( cmb_ordr_status.SelectedValue.ToString()) != 0 ) {
                    MessageBox.Show("لايمكن حذف طلب معتمد ");
                    return true;
                }

                ordr = db.storOrders.FirstOrDefault((p) => p.ordr_id == _id);
                if (ordr != null)
                {
                    ordrDtls = db.StorOrderDetails.Where((ordr) => ordr.ordr_id == ordr.ordr_id).AsParallel().ToList();
                    dgv_ordr_dtls.DataSource = ordrDtls;
                    for (int i = 0; i < ordrDtls.Count-1; i++)
                    {
                    db.Entry(ordrDtls.ElementAt(i)).State = System.Data.Entity.EntityState.Deleted;
                    db.StorOrderDetails.Remove(ordrDtls.ElementAt(i));
                    }
                    db.storOrders.Remove(ordr);
                    db.Entry(ordr).State = System.Data.Entity.EntityState.Deleted;
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
        private void ShowObj(int OrdrId)
        {
            try
            {
                
                dgv_ordr_dtls.Rows.Clear();
                //db.Dispose();
                //db = new SysData.DbCntxt();
                db.StorOrderDetails.Local.Clear();
                foreach (var item in db.ChangeTracker.Entries<SysData.StorOrderDetail>())
                {
                    item.State = EntityState.Detached;
                }
                SysData.storOrder   obj = db.storOrders.AsNoTracking().FirstOrDefault((ordr) => ordr.ordr_id == OrdrId);
                txt_ordr_id.Text = obj.ordr_id.ToString();
                txt_ordr_dsc.Text = obj.ordr_dsc;
                cmb_str_id.SelectedValue = obj.str_id;
                cmb_ordr_status.SelectedValue = obj.ordr_status;
                cmb_ordr_usr.SelectedValue = obj.ordr_usr.Value;
                dt_ordr_dt.Value = obj.ordr_dt.Value;
                rdo_ordr_typ_out_2.Checked = obj.ordr_type == 2 ? true : false;
                rdo_ordr_typ_in_1.Checked = obj.ordr_type == 1 ? true : false;
                db.StorOrderDetails.Where((ordr) => ordr.ordr_id == OrdrId).Load();
                dgv_ordr_dtls.DataSource = db.StorOrderDetails.Local.ToBindingList();
                //dgv_ordr_dtls.DataSource = obj.StorOrderDetails.ToList();
                BtnDelete.Enabled = true;
                BtnSave.Enabled = true;
             
            }
            catch(Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
        private void DgvProds_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {

                int _id = -1;
            
                    if (int.TryParse(DgvProds.Rows[e.RowIndex].Cells[ordr_id.Name].Value.ToString(), out _id))
                         {
                             ShowObj(_id);
                        }
 

            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgv_ordr_dtls_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }

        private void rdo_ordr_typ_in_1_CheckedChanged(object sender, EventArgs e)
        {
            if (rdo_ordr_typ_in_1.Checked) {
                cmb_ordr_usr.Enabled = false;
                cmb_ordr_usr.SelectedIndex = -1;
            }
        }
    }
}
