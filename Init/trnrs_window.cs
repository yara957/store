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
    public partial class trnrs_window : StorSystem.Core.ClscScurUserInterface
    {
        public trnrs_window()
        {
            InitializeComponent();
        }

        protected override bool InitData()
        {
            base.InitData();
             this.FildsToShow = new List<Control>();
            this.FildsToShow.AddRange(new List<Control>() { txt_about,txt_exp,txt_id,txt_mjr,txt_nm,txt_phn, DgvProds });
            this.buttons.AddRange(new List<Button>() { BtnNew, BtnSave, BtnSearch, BtnDelete });
           
            return true;
        }
        private List<SysData.trnr> Alldata;

        protected override bool SearchData()
        {
            Alldata = new List<SysData.trnr>();
            Alldata = db.trnrs.AsNoTracking().ToList();
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
         protected override bool SaveData()
        {
            SysData.trnr obj = null;

            int _id = 0;
            if (int.TryParse(txt_id.Text, out _id))

                obj = db.trnrs.FirstOrDefault((b) => b.trnr_id == _id);
            if (obj == null)
            {
                obj = new SysData.trnr();
            }


            obj.trnr_exp = txt_exp.Text;
            obj.trnr_about = txt_about.Text;
            obj.trnr_nm = txt_nm.Text;
            obj.trnr_phn = txt_phn.Text;
                obj.trnr_status = chk_stat.Checked ? 1 : 0;
            obj.trnr_major = txt_mjr.Text;

            if (obj.trnr_id > 0)
            {
                db.trnrs.Attach(obj);
                db.Entry(obj).State = System.Data.Entity.EntityState.Modified;
            }
            else
            {

                db.trnrs.Add(obj);
            }

            return db.SaveChanges() > 0 ? true : false;
        }

    }
}
