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
    public partial class Init_typs_002 : StorSystem.Core.ClscScurUserInterface
    {
        private SysData.ProductType obj;
         private List<SysData.ProductType> Alldata;
        public Init_typs_002()
        {
             InitializeComponent();
         }

        protected override bool InitData()
        {
            base.InitData();
            obj = new SysData.ProductType();
            this.FildsToShow = new List<Control>();
            this.FildsToShow.AddRange(new List<Control>() { txt_type_desc,txt_type_id,txt_type_name,chk_type_status, DgvProds });
            this.buttons.AddRange(new List<Button>() { BtnNew, BtnSave, BtnSearch, BtnDelete });
            return true;
        }


        protected override bool SearchData()
        {
            Alldata = new List<SysData.ProductType>();
            Alldata = db.ProductTypes.AsParallel().ToList();
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
            if (int.TryParse(txt_type_id.Text, out _id))

                obj = db.ProductTypes.FirstOrDefault((obj) => obj.type_id == _id);
            if (obj == null)
            {
                obj = new SysData.ProductType();
            }



            obj.type_id = _id;
            obj.type_name = txt_type_name.Text;
            obj.type_desc = txt_type_desc.Text;
            obj.type_status = chk_type_status.Checked ? 1 : 0;
            if (obj.type_id  > 0)
            {
                db.ProductTypes.Attach(obj);
                db.Entry(obj).State = System.Data.Entity.EntityState.Modified;
            }
            else
            {

                db.ProductTypes.Add(obj);
            }

            return db.SaveChanges() > 0 ? true : false;
        }

        protected override bool DeleteRecord()
        {
            try
            {
                int _id = int.Parse(txt_type_id.Text);
                
                obj = db.ProductTypes.FirstOrDefault((p) => p.type_id == _id);
                if (obj != null)
                {
                    db.ProductTypes.Remove(obj);
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

        private void ShowProduct(SysData.ProductType prod)
        {
            try
            {

                txt_type_id.Text = prod.type_id.ToString();
                txt_type_name.Text = prod.type_name; 
                txt_type_desc.Text = prod.type_desc;
                chk_type_status.Checked = prod.type_status == 1 ? true : false;
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
                        if (Alldata.ElementAt(i).type_id == _id)
                        {
                            obj = Alldata.ElementAt(i);
                            ShowProduct(obj);
                        }
                }

            }
            catch (Exception ex) { }
        }

    }
}
