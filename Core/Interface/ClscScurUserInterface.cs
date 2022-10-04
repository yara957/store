using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace StorSystem.Core
{
    public partial class ClscScurUserInterface : Form
    {

        protected List<Control> FildsToShow = new List<Control>();
        protected List<Control> RequiredFilds = new List<Control>();
        protected List<Button> buttons = new List<Button>();
        protected SysData.DbCntxt1 db;
        public ClscScurUserInterface()
        {
            InitializeComponent();
            db = new SysData.DbCntxt1();
       
        }

        
        private void BtnClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"هل انت متاكد من الخروج من شاشة {this.Text}", "تاكيد الخروج", MessageBoxButtons.YesNo) == DialogResult.Yes) 
                this.Dispose();
        }

        private void tbl_footer_search_bar_Paint(object sender, PaintEventArgs e)
        {

        }

   
        private void ClscScurUserInterface_Load(object sender, EventArgs e)
        {
            //lbl_form_prog_name.Text = this.Name;
            DtHeaderDate.Value = DateTime.Now;
            Timer01.Start();
            try
            {
                InitData();
                NewRecord();

                foreach (Button _btn in buttons)
                {
                    _btn.Visible = true;
                }
                if (db != null)
                {
                    SearchData();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DtHeaderDate.Value = DateTime.Now;
        }

        private void tbl_main_buttons_bar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LblTotalRecordsCount_DoubleClick(object sender, EventArgs e)
        {
            MessageBox.Show("Interface Title  :- { " + this.Text + " }  , Programming Name :- { " + this.Name + " }");
        }

        #region MainFunctions

        protected virtual bool SaveData() {
            try {
                return true;
            } catch (Exception e) {
                return false;
            }
        }
        protected virtual void NewRecord()
        {
            try
            {
                foreach (Control _ctrl in FildsToShow)
                {
                    try {
                        if (_ctrl is TextBox)
                        {
                            _ctrl.Text = null;
                        }
                        else if (_ctrl is ComboBox)
                        {
                            ((ComboBox)_ctrl).SelectedIndex = -1;
                        }
                        else if (_ctrl is CheckBox)
                        {
                            ((CheckBox)_ctrl).Checked = false;
                        }
                        else if (_ctrl is DataGridView) {
                            ((DataGridView)_ctrl).Rows.Clear();
                        }
                    }
                    catch { }
                }

                BtnSave.Enabled = true;

            }
            catch (Exception e)
            {
            }
        }
        protected virtual bool DeleteRecord()
        {
            try
            {
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
        //-----------------------
        protected virtual bool SearchData()
        {
            try
            {
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
        protected virtual bool InitData()
        {
            try
            {
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
        //-----------------------
        #endregion


        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (SaveData())
            {
                BtnSave.Enabled = false;
                MessageBox.Show("تمت عملية الحفظ بنجاح");
                SearchData();
            }
            else {
                MessageBox.Show("هناكـ خطاء في عملية الحفظ يرجى المحاولة لاحقاً ");
            }
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            NewRecord();
            InitData();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            SearchData();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($" هل تريد بالتاكيد حذف السجل الحالي  ", "تاكيد حذف", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (DeleteRecord() == true)
                {
                    BtnDelete.Enabled = false;
                    MessageBox.Show("تمت عملية الحذف بنجاح");
                    NewRecord();
                    SearchData();
                }
                else {
                    BtnDelete.Enabled = true;
                    MessageBox.Show("لم يتم الحذف حاول مره اخرى");

                }
            }
        }

        public void DgvDataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }
    }
}
