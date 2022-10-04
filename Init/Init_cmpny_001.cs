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
    public partial class Init_cmpny_001 : StorSystem.Core.ClscScurUserInterface
    {
        private SysData.Company cmpny;
        private List<SysData.Company> allData;

        public Init_cmpny_001()
        {
            InitializeComponent();
        }


        protected override bool InitData()
        {

            cmpny = new SysData.Company();
            this.FildsToShow = new List<Control>();
            this.FildsToShow.AddRange(new List<Control>() { txt_cmpny_name,txt_id  });
            this.buttons.AddRange(new List<Button>() { BtnNew, BtnSave, BtnSearch, BtnDelete });
            if (this.db != null)
            { 
            }
            return base.InitData();
        }
        protected override bool SearchData()
        {
            allData = new List<SysData.Company>();
            allData = db.Companies.AsNoTracking().ToList();
            if (allData != null && allData.Count > 0)
            {
                dgv_all.DataSource = null;
                dgv_all.DataSource = allData;
                return true;
            }
            else
            {
                MessageBox.Show("No Prods");
                return false;
            }
        }

        #region OverrideFuns

        protected override bool SaveData()
        {

            int _id = 0;
            if (int.TryParse(txt_id.Text, out _id))

                cmpny = db.Companies.FirstOrDefault((prod) => prod.id == _id);
            if (cmpny == null)
            {
                cmpny = new SysData.Company();
            }

            cmpny.id = _id;


            cmpny.cmpny_addrss = txt_cmpny_addrs.Text;
            //cmpny.cmpny_email = txt_cmpny_email.Text;
            cmpny.cmpny_name = txt_cmpny_name.Text;
            cmpny.cmpny_notes = txt_cmpny_notes.Text;
             //cmpny.cmpny_ctgry = cmb_cmpny_ctgry.SelectedIndex >= 0 ? (int)cmb_cmpny_ctgry.SelectedValue : 0;

            if (cmpny.id > 0)
            {
                db.Companies.Attach(cmpny);
                db.Entry(cmpny).State = System.Data.Entity.EntityState.Modified;
            }
            else
            {
                db.Companies.Add(cmpny);
            }

            return db.SaveChanges() > 0 ? true : false;
        }
        #endregion

        protected override bool DeleteRecord()
        {
            try
            {
                int _id = int.Parse(txt_id.Text);

                cmpny = db.Companies.FirstOrDefault((p) => p.id == _id);
                if (cmpny != null)
                {
                    db.Companies.Remove(cmpny);
                    db.Entry(cmpny).State = System.Data.Entity.EntityState.Deleted;
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


    }
}
