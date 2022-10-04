using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace StorSystem.Qry
{
    public partial class Qry_ordrs_001 : StorSystem.Core.ClscScurUserInterface
    {

        private List<SysData.VStorOrdrsOnly> _ordrs;
        private List<SysData.VOrdrProduct> _prods;

        public Qry_ordrs_001()
        {
            InitializeComponent();
        }
        protected override bool InitData()
        {
            base.InitData();
            _ordrs = new List<SysData.VStorOrdrsOnly>();
            _prods = new List<SysData.VOrdrProduct>();
            this.FildsToShow = new List<Control>();
            this.FildsToShow.AddRange(new List<Control>() { });
            this.buttons.AddRange(new List<Button>() {  BtnSearch });
            
            return true;
        }

        protected override bool SearchData()
        {

            _ordrs = new List<SysData.VStorOrdrsOnly>();
            _prods = new List<SysData.VOrdrProduct>();

            _ordrs = db.VStorOrdrsOnlies.AsNoTracking().ToList();
            _prods = db.VOrdrProducts.AsNoTracking().ToList();

            if (_ordrs != null && _ordrs.Count > 0)
            {
                DgvProds.DataSource = _ordrs;
                return true;
            }
            else
            {
                return false;
            }
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Qry_ordrs_001_Load(object sender, EventArgs e)
        {

        }

        private void DgvProds_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int _id = int.Parse(DgvProds.Rows[e.RowIndex].Cells[ordr_id.Name].Value.ToString());
                _prods = db.VOrdrProducts.AsNoTracking().Where((c) => c.ordr_id == _id).ToList();
                dgv_ordr_dtls.DataSource = _prods;
            }
            catch (Exception)
            {

                
            }
        }

         
    }
}
