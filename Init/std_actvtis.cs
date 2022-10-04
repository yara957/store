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
    public partial class std_actvtis : StorSystem.Core.ClscScurUserInterface
    {
        public std_actvtis()
        {
            InitializeComponent();
        }

        protected override bool InitData()
        {
            base.InitData();
             this.FildsToShow = new List<Control>();
            this.FildsToShow.AddRange(new List<Control>() {
                txt_about,txt_dgre,txt_dgr_nots,txt_dtls,txt_id,txt_nm,txt_std_lst,txt_std_no,txt_suprvisor,chk_status_2,checkBox1,checkBox2, dataGridView1 });
            this.buttons.AddRange(new List<Button>() { BtnNew, BtnSave, BtnSearch, BtnDelete });
            if (this.db != null)
            {
             }
            return true;
        }
        private List<SysData.std_actvties> Alldata;

        protected override bool SearchData()
        {
            Alldata = new List<SysData.std_actvties>();
            Alldata = db.std_actvties.AsNoTracking().ToList();
            if (Alldata != null && Alldata.Count > 0)
            {
                dataGridView1.DataSource = Alldata;
                return true;
            }
            else
            {
                return false;
            }
        }
         protected override bool SaveData()
        {
            SysData.std_actvties obj = null;
            int _id = 0;
            if (int.TryParse(txt_id.Text, out _id))

                obj = db.std_actvties.FirstOrDefault((o) => o.atv_id == _id);
            if (obj == null)
            {
                obj = new SysData.std_actvties();
            }


            obj.actv_about = txt_about.Text;
            obj.actv_nm = txt_nm.Text;
            obj.actv_dgre_note = txt_dgr_nots.Text;
            obj.actv_dtls = txt_dtls.Text;
            obj.actv_end_dt = dt_end.Value;
             obj.actv_std_nm_lst = txt_std_lst.Text;
            obj.actv_strt_dt = dt_strt.Value;
            obj.actv_suprvisor = txt_suprvisor.Text;
            //  obj.str_status = chk_str_status.Checked ? 1 : 0;

            try
            {
                obj.actv_dgre = Int32.Parse(txt_dgre.Text);
                obj.actv_std_no = Int32.Parse(txt_std_no.Text);

            }
            catch (Exception)
            {
                obj.actv_dgre = 0;
                obj.actv_std_no = 0;
            }

            if (obj.atv_id > 0)
            {
                db.std_actvties.Attach(obj);
                db.Entry(obj).State = System.Data.Entity.EntityState.Modified;
            }
            else
            {

                db.std_actvties.Add(obj);
            }

            return db.SaveChanges() > 0 ? true : false;
        }

    }
}
