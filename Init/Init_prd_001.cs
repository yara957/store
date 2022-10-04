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
    public partial class Init_prd_001 : StorSystem.Core.ClscScurUserInterface
    {

        private SysData.Product product;
    
        private List<SysData.Product> Allproducts;
        public Init_prd_001()
        {
            InitializeComponent();
        }

        protected override bool InitData()
        {
             
            product = new SysData.Product();
            this.FildsToShow = new List<Control>();
            this.FildsToShow.AddRange(new List<Control>() {txt_prod_aname,txt_prod_desc,txt_prod_ename,txt_prod_id,txt_prod_othrs,cmb_prod_type,chk_prod_status,DgvProds });
            this.buttons.AddRange(new List<Button>() { BtnNew, BtnSave, BtnSearch ,BtnDelete });
            if (this.db != null) {
                prod_type.DisplayMember = "type_name";
                prod_type.ValueMember = "type_id";
                cmb_prod_type.DisplayMember = "type_name";
                cmb_prod_type.ValueMember = "type_id";
                prod_catgry.DisplayMember = "catgry_name";
               // cmb_prod_catgry.DisplayMember = "catgry_name";
                prod_catgry.ValueMember = "catgry_id";
               // cmb_prod_catgry.ValueMember = "catgry_id";
                cmb_prod_type.DataSource = db.ProductTypes.AsParallel().ToList();
                prod_type.DataSource = db.ProductTypes.AsParallel().ToList();
              //  prod_catgry.DataSource = db.ProductCategories.AsParallel().ToList();
                //cmb_prod_catgry.DataSource = db.ProductCategories.AsParallel().ToList();
            }
            return base.InitData();
        }
        protected override bool SearchData() { 
            Allproducts = new List<SysData.Product>();
            Allproducts = db.Products.AsParallel().ToList();
            if (Allproducts != null && Allproducts.Count > 0)
            {
                DgvProds.DataSource = null;
                DgvProds.DataSource = Allproducts;
                return true;
            }
            else {
                MessageBox.Show("No Prods");
                return false;
            }
        }

        #region OverrideFuns

        protected override bool SaveData()
        {
   
            int _id = 0;
            if (int.TryParse(txt_prod_id.Text, out _id))

            product = db.Products.FirstOrDefault((prod) => prod.prod_id == _id);
            if (product == null) {
                product = new SysData.Product();
            }

            product.prod_id = _id;


            product.prod_aname = txt_prod_aname.Text;
            product.prod_ename = txt_prod_ename.Text;
            product.prod_desc = txt_prod_desc.Text;
            //product.prod_dflt_price =decimal.Parse( txt_prod_dflt_price.Text);
            //product.prod_catgry = cmb_prod_catgry.SelectedIndex>=0 ? (int)cmb_prod_catgry.SelectedValue:0;
            product.prod_type = (int)(cmb_prod_type.SelectedIndex>=0 ? cmb_prod_type.SelectedValue :0);
            product.prod_othrs = txt_prod_othrs.Text;
            product.prod_status = chk_prod_status.Checked ? 1 : 0;
            if (product.prod_id > 0)
            {
                db.Products.Attach(product);
                db.Entry(product).State = System.Data.Entity.EntityState.Modified;

            }
            else { 
            
            db.Products.Add(product);
            }

            return db.SaveChanges() > 0? true:false;
        }
        #endregion

        protected override bool DeleteRecord()
        {
            try {
                int _id = int.Parse(txt_prod_id.Text);

                product = db.Products.FirstOrDefault((p)=> p.prod_id == _id);
                if (product !=  null ) {
                    db.Products.Remove(product);
                    db.Entry(product).State = System.Data.Entity.EntityState.Deleted;
                    return db.SaveChanges() > 0 ? true : false;
                     

                }
                return false;
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        private void ShowProduct(SysData.Product prod) {
            try {

                txt_prod_id.Text = prod.prod_id.ToString();
                txt_prod_aname.Text = prod.prod_aname;
                txt_prod_ename.Text = prod.prod_ename;
                //txt_prod_dflt_price.Text = prod.prod_dflt_price.ToString();
                //cmb_prod_catgry.SelectedValue = prod.prod_catgry;
                cmb_prod_type.SelectedValue = prod.prod_type;
                txt_prod_desc.Text = prod.prod_desc;
                txt_prod_othrs.Text = prod.prod_othrs;
                chk_prod_status.Checked = prod.prod_status == 1 ? true : false;
                BtnDelete.Enabled = true;
                BtnSave.Enabled = true;
            }
            catch { }
        }
        private void DgvProds_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try {
                int _id = 0;

                int.TryParse(DgvProds.Rows[e.RowIndex].Cells[prod_id.Name].Value.ToString(), out _id);
                if (_id > 0) {
                    product = db.Products.AsNoTracking().FirstOrDefault(x => x.prod_id == _id);
                         ShowProduct(product);
                }

                
            
            } catch (Exception ex) { }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {

        }

        private void DgvProds_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }
    }
    }
