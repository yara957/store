namespace StorSystem.Qry
{
    partial class Qry_ordrs_001
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.DgvProds = new System.Windows.Forms.DataGridView();
            this.ordr_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.str_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ordr_dt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ordr_usr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ordr_dsc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ordr_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ordr_status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.add_by = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.add_at = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.updt_by = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.updt_at = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_ordr_dtls = new System.Windows.Forms.DataGridView();
            this.c_rec_ser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_ordr_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_prod_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_prod_qt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_prod_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_prod_im_dt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_prod_exp_dt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prod_desc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.catgry_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ErPrMainErrorProvidor)).BeginInit();
            this.PnlMainContent.SuspendLayout();
            this.pnl_home_body.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvProds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ordr_dtls)).BeginInit();
            this.SuspendLayout();
            // 
            // PnlMainContent
            // 
            this.PnlMainContent.Controls.Add(this.DgvProds);
            this.PnlMainContent.Size = new System.Drawing.Size(866, 174);
            // 
            // btnSearchHdrLov
            // 
            this.btnSearchHdrLov.FlatAppearance.BorderSize = 0;
            // 
            // MainPanel
            // 
            this.MainPanel.Size = new System.Drawing.Size(878, 279);
            // 
            // pnl_home_body
            // 
            this.pnl_home_body.Controls.Add(this.dgv_ordr_dtls);
            this.pnl_home_body.Controls.SetChildIndex(this.MainPanel, 0);
            this.pnl_home_body.Controls.SetChildIndex(this.dgv_ordr_dtls, 0);
            // 
            // DgvProds
            // 
            this.DgvProds.AllowUserToAddRows = false;
            this.DgvProds.AllowUserToDeleteRows = false;
            this.DgvProds.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvProds.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvProds.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ordr_id,
            this.str_id,
            this.ordr_dt,
            this.ordr_usr,
            this.ordr_dsc,
            this.ordr_type,
            this.ordr_status,
            this.add_by,
            this.add_at,
            this.updt_by,
            this.updt_at});
            this.DgvProds.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvProds.Location = new System.Drawing.Point(0, 0);
            this.DgvProds.Name = "DgvProds";
            this.DgvProds.ReadOnly = true;
            this.DgvProds.Size = new System.Drawing.Size(864, 172);
            this.DgvProds.TabIndex = 7;
            this.DgvProds.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvProds_RowEnter);
            // 
            // ordr_id
            // 
            this.ordr_id.DataPropertyName = "ordr_id";
            this.ordr_id.HeaderText = "رقم الطلب";
            this.ordr_id.Name = "ordr_id";
            this.ordr_id.ReadOnly = true;
            // 
            // str_id
            // 
            this.str_id.DataPropertyName = "str_name";
            this.str_id.HeaderText = "المخزن";
            this.str_id.Name = "str_id";
            this.str_id.ReadOnly = true;
            this.str_id.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.str_id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ordr_dt
            // 
            this.ordr_dt.DataPropertyName = "ordr_dt";
            this.ordr_dt.HeaderText = "تاريخ الطلب";
            this.ordr_dt.Name = "ordr_dt";
            this.ordr_dt.ReadOnly = true;
            this.ordr_dt.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ordr_dt.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ordr_usr
            // 
            this.ordr_usr.DataPropertyName = "ordr_usr";
            this.ordr_usr.HeaderText = "مقدم الطلب";
            this.ordr_usr.Name = "ordr_usr";
            this.ordr_usr.ReadOnly = true;
            this.ordr_usr.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ordr_usr.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ordr_dsc
            // 
            this.ordr_dsc.DataPropertyName = "ordr_dsc";
            this.ordr_dsc.HeaderText = "البيان";
            this.ordr_dsc.Name = "ordr_dsc";
            this.ordr_dsc.ReadOnly = true;
            // 
            // ordr_type
            // 
            this.ordr_type.DataPropertyName = "ordr_typ_name";
            this.ordr_type.HeaderText = "امر صرف";
            this.ordr_type.Name = "ordr_type";
            this.ordr_type.ReadOnly = true;
            this.ordr_type.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ordr_type.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ordr_status
            // 
            this.ordr_status.DataPropertyName = "ordr_status_name";
            this.ordr_status.HeaderText = "حالة الطلب";
            this.ordr_status.Name = "ordr_status";
            this.ordr_status.ReadOnly = true;
            this.ordr_status.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ordr_status.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // add_by
            // 
            this.add_by.DataPropertyName = "add_by";
            this.add_by.HeaderText = "الاضافة بواسطه";
            this.add_by.Name = "add_by";
            this.add_by.ReadOnly = true;
            this.add_by.Visible = false;
            // 
            // add_at
            // 
            this.add_at.DataPropertyName = "add_at";
            this.add_at.HeaderText = "تاريخ الاضافه";
            this.add_at.Name = "add_at";
            this.add_at.ReadOnly = true;
            this.add_at.Visible = false;
            // 
            // updt_by
            // 
            this.updt_by.DataPropertyName = "updt_by";
            this.updt_by.HeaderText = "تعديل بواسطه";
            this.updt_by.Name = "updt_by";
            this.updt_by.ReadOnly = true;
            this.updt_by.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.updt_by.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.updt_by.Visible = false;
            // 
            // updt_at
            // 
            this.updt_at.DataPropertyName = "updt_at";
            this.updt_at.HeaderText = "تعديل بتاريخ";
            this.updt_at.Name = "updt_at";
            this.updt_at.ReadOnly = true;
            this.updt_at.Visible = false;
            // 
            // dgv_ordr_dtls
            // 
            this.dgv_ordr_dtls.AllowUserToOrderColumns = true;
            this.dgv_ordr_dtls.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_ordr_dtls.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgv_ordr_dtls.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ordr_dtls.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.c_rec_ser,
            this.c_ordr_id,
            this.c_prod_id,
            this.c_prod_qt,
            this.c_prod_price,
            this.c_prod_im_dt,
            this.c_prod_exp_dt,
            this.prod_desc,
            this.catgry_name,
            this.type_name});
            this.dgv_ordr_dtls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_ordr_dtls.Location = new System.Drawing.Point(0, 279);
            this.dgv_ordr_dtls.Name = "dgv_ordr_dtls";
            this.dgv_ordr_dtls.Size = new System.Drawing.Size(878, 194);
            this.dgv_ordr_dtls.TabIndex = 5;
            this.dgv_ordr_dtls.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.DgvDataError);
            // 
            // c_rec_ser
            // 
            this.c_rec_ser.DataPropertyName = "rec_ser";
            this.c_rec_ser.HeaderText = "متسلسل";
            this.c_rec_ser.Name = "c_rec_ser";
            this.c_rec_ser.ReadOnly = true;
            // 
            // c_ordr_id
            // 
            this.c_ordr_id.DataPropertyName = "ordr_id";
            this.c_ordr_id.HeaderText = "ordr_id";
            this.c_ordr_id.Name = "c_ordr_id";
            this.c_ordr_id.ReadOnly = true;
            this.c_ordr_id.Visible = false;
            // 
            // c_prod_id
            // 
            this.c_prod_id.DataPropertyName = "prod_aname";
            this.c_prod_id.HeaderText = "المنتج";
            this.c_prod_id.Name = "c_prod_id";
            this.c_prod_id.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.c_prod_id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // c_prod_qt
            // 
            this.c_prod_qt.DataPropertyName = "prod_qt";
            this.c_prod_qt.HeaderText = "الكمية";
            this.c_prod_qt.Name = "c_prod_qt";
            // 
            // c_prod_price
            // 
            this.c_prod_price.DataPropertyName = "prod_price";
            this.c_prod_price.HeaderText = "السعر للوحده";
            this.c_prod_price.Name = "c_prod_price";
            // 
            // c_prod_im_dt
            // 
            this.c_prod_im_dt.DataPropertyName = "prod_im_dt";
            this.c_prod_im_dt.HeaderText = "تاريخ الانتاج";
            this.c_prod_im_dt.Name = "c_prod_im_dt";
            // 
            // c_prod_exp_dt
            // 
            this.c_prod_exp_dt.DataPropertyName = "prod_exp_dt";
            this.c_prod_exp_dt.HeaderText = "تاريخ الانتهاء";
            this.c_prod_exp_dt.Name = "c_prod_exp_dt";
            // 
            // prod_desc
            // 
            this.prod_desc.DataPropertyName = "prod_desc";
            this.prod_desc.HeaderText = "وصف المنتج";
            this.prod_desc.Name = "prod_desc";
            // 
            // catgry_name
            // 
            this.catgry_name.DataPropertyName = "catgry_name";
            this.catgry_name.HeaderText = "الفئة";
            this.catgry_name.Name = "catgry_name";
            // 
            // type_name
            // 
            this.type_name.DataPropertyName = "type_name";
            this.type_name.HeaderText = "النوع";
            this.type_name.Name = "type_name";
            // 
            // Qry_ordrs_001
            // 
            this.ClientSize = new System.Drawing.Size(878, 473);
            this.Name = "Qry_ordrs_001";
            this.Load += new System.EventHandler(this.Qry_ordrs_001_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ErPrMainErrorProvidor)).EndInit();
            this.PnlMainContent.ResumeLayout(false);
            this.pnl_home_body.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvProds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ordr_dtls)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvProds;
        private System.Windows.Forms.DataGridView dgv_ordr_dtls;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_rec_ser;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_ordr_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_prod_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_prod_qt;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_prod_price;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_prod_im_dt;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_prod_exp_dt;
        private System.Windows.Forms.DataGridViewTextBoxColumn prod_desc;
        private System.Windows.Forms.DataGridViewTextBoxColumn catgry_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn type_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn ordr_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn str_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn ordr_dt;
        private System.Windows.Forms.DataGridViewTextBoxColumn ordr_usr;
        private System.Windows.Forms.DataGridViewTextBoxColumn ordr_dsc;
        private System.Windows.Forms.DataGridViewTextBoxColumn ordr_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn ordr_status;
        private System.Windows.Forms.DataGridViewTextBoxColumn add_by;
        private System.Windows.Forms.DataGridViewTextBoxColumn add_at;
        private System.Windows.Forms.DataGridViewTextBoxColumn updt_by;
        private System.Windows.Forms.DataGridViewTextBoxColumn updt_at;
    }
}
