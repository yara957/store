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
    public partial class Init_ctgry_003 : StorSystem.Core.ClscScurUserInterface
    {
        //private SysData.ProductCategory obj;
        // private List<SysData.ProductCategory> Alldata;

        public Init_ctgry_003()
        {
          InitializeComponent();
        }

        protected override bool InitData()
        {
            //base.InitData();
            //obj = new SysData.ProductCategory();
            //this.FildsToShow = new List<Control>();
            //this.FildsToShow.AddRange(new List<Control>() { txt_type_desc, txt_type_id, txt_type_name, chk_type_status, DgvProds });
            //this.buttons.AddRange(new List<Button>() { BtnNew, BtnSave, BtnSearch, BtnDelete });
            return true;
        }

        protected override bool SearchData()
        {
            //Alldata = new List<SysData.ProductCategory>();
            //Alldata = db.ProductCategories.AsParallel().ToList();
            //if (Alldata != null && Alldata.Count > 0)
            //{

            //    DgvProds.DataSource = Alldata;
            //    return true;
            //}
            //else
            //{
                return false;
           // }
        }
        #region OverrideFuns
        protected override bool SaveData()
        {
            return false;

            //obj = db.ProductCategories.FirstOrDefault((obj) => obj.catgry_id == obj.catgry_id);
            //if (obj == null)
            //{
            //    obj = new SysData.ProductCategory();
            //}

            //int _id = 0;
            //if (int.TryParse(txt_type_id.Text, out _id))
            //    obj.catgry_id = _id;

            //obj.catgry_name = txt_type_name.Text;
            //obj.catgry_desc = txt_type_desc.Text;
            //obj.catgry_status = chk_type_status.Checked ? 1 : 0;
            //if (obj.catgry_id > 0)
            //{
            //    db.ProductCategories.Attach(obj);
            //    db.Entry(obj).State = System.Data.Entity.EntityState.Modified;
            //}
            //else
            //{

            //    db.ProductCategories.Add(obj);
            //}

            //return db.SaveChanges() > 0 ? true : false;
        }

        protected override bool DeleteRecord()
        {
            try
            {
                int _id = int.Parse(txt_type_id.Text);

                //obj = db.ProductCategories.FirstOrDefault((p) => p.catgry_id == _id);
                //if (obj != null)
                //{
                //    db.ProductCategories.Remove(obj);
                //    db.Entry(obj).State = System.Data.Entity.EntityState.Deleted;
                //    return db.SaveChanges() > 0 ? true : false;
                //}
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }


        #endregion
   
  
    }
}
