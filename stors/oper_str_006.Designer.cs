namespace StorSystem.stors
{
    partial class oper_str_006
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_ordr_id = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_str_id = new System.Windows.Forms.ComboBox();
            this.dt_ordr_dt = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmb_ordr_usr = new System.Windows.Forms.ComboBox();
            this.txt_ordr_dsc = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmb_ordr_status = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dgv_ordr_dtls = new System.Windows.Forms.DataGridView();
            this.c_rec_ser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_ordr_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_prod_id = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.c_prod_qt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rdo_ordr_typ_out_2 = new System.Windows.Forms.RadioButton();
            this.rdo_ordr_typ_in_1 = new System.Windows.Forms.RadioButton();
            this.DgvProds = new System.Windows.Forms.DataGridView();
            this.ordr_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.str_id = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ordr_dt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ordr_usr = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ordr_dsc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ordr_type = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ordr_status = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.add_by = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.add_at = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.updt_by = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.updt_at = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ErPrMainErrorProvidor)).BeginInit();
            this.PnlMainContent.SuspendLayout();
            this.pnl_home_body.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ordr_dtls)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvProds)).BeginInit();
            this.SuspendLayout();
            // 
            // hm_Lbl_1
            // 
            this.hm_Lbl_1.Text = "امر مخــزني";
            // 
            // PnlMainContent
            // 
            this.PnlMainContent.Controls.Add(this.tableLayoutPanel1);
            this.PnlMainContent.Size = new System.Drawing.Size(866, 235);
            // 
            // btnSearchHdrLov
            // 
            this.btnSearchHdrLov.FlatAppearance.BorderSize = 0;
            // 
            // MainPanel
            // 
            this.MainPanel.Size = new System.Drawing.Size(878, 340);
            // 
            // pnl_home_body
            // 
            this.pnl_home_body.Controls.Add(this.DgvProds);
            this.pnl_home_body.Size = new System.Drawing.Size(878, 481);
            this.pnl_home_body.Controls.SetChildIndex(this.MainPanel, 0);
            this.pnl_home_body.Controls.SetChildIndex(this.DgvProds, 0);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 7;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.15311F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 98F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 61.02662F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.88213F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txt_ordr_id, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.cmb_str_id, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.dt_ordr_dt, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.label3, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.cmb_ordr_usr, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.txt_ordr_dsc, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.label5, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.cmb_ordr_status, 6, 1);
            this.tableLayoutPanel1.Controls.Add(this.label6, 5, 1);
            this.tableLayoutPanel1.Controls.Add(this.dgv_ordr_dtls, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.rdo_ordr_typ_out_2, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.rdo_ordr_typ_in_1, 4, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.58974F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 81.41026F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(864, 233);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(764, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "الرقـم";
            // 
            // txt_ordr_id
            // 
            this.txt_ordr_id.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_ordr_id.Location = new System.Drawing.Point(666, 26);
            this.txt_ordr_id.Name = "txt_ordr_id";
            this.txt_ordr_id.ReadOnly = true;
            this.txt_ordr_id.Size = new System.Drawing.Size(92, 20);
            this.txt_ordr_id.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(611, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 27);
            this.label2.TabIndex = 0;
            this.label2.Text = "المستودع";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmb_str_id
            // 
            this.cmb_str_id.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmb_str_id.FormattingEnabled = true;
            this.cmb_str_id.Location = new System.Drawing.Point(269, 26);
            this.cmb_str_id.Name = "cmb_str_id";
            this.cmb_str_id.Size = new System.Drawing.Size(336, 21);
            this.cmb_str_id.TabIndex = 2;
            // 
            // dt_ordr_dt
            // 
            this.dt_ordr_dt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dt_ordr_dt.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_ordr_dt.Location = new System.Drawing.Point(666, 53);
            this.dt_ordr_dt.Name = "dt_ordr_dt";
            this.dt_ordr_dt.Size = new System.Drawing.Size(92, 20);
            this.dt_ordr_dt.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(764, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 27);
            this.label3.TabIndex = 0;
            this.label3.Text = "تاريخ تقديم الطلب";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(611, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 27);
            this.label4.TabIndex = 0;
            this.label4.Text = "القـاعة";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmb_ordr_usr
            // 
            this.cmb_ordr_usr.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmb_ordr_usr.FormattingEnabled = true;
            this.cmb_ordr_usr.Location = new System.Drawing.Point(269, 53);
            this.cmb_ordr_usr.Name = "cmb_ordr_usr";
            this.cmb_ordr_usr.Size = new System.Drawing.Size(336, 21);
            this.cmb_ordr_usr.TabIndex = 2;
            // 
            // txt_ordr_dsc
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.txt_ordr_dsc, 5);
            this.txt_ordr_dsc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_ordr_dsc.Location = new System.Drawing.Point(3, 80);
            this.txt_ordr_dsc.Multiline = true;
            this.txt_ordr_dsc.Name = "txt_ordr_dsc";
            this.txt_ordr_dsc.Size = new System.Drawing.Size(755, 22);
            this.txt_ordr_dsc.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(764, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 28);
            this.label5.TabIndex = 0;
            this.label5.Text = "البيان";
            // 
            // cmb_ordr_status
            // 
            this.cmb_ordr_status.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmb_ordr_status.Enabled = false;
            this.cmb_ordr_status.FormattingEnabled = true;
            this.cmb_ordr_status.Location = new System.Drawing.Point(3, 26);
            this.cmb_ordr_status.Name = "cmb_ordr_status";
            this.cmb_ordr_status.Size = new System.Drawing.Size(201, 21);
            this.cmb_ordr_status.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Location = new System.Drawing.Point(210, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 27);
            this.label6.TabIndex = 0;
            this.label6.Text = "حالة الطلب";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.c_prod_qt});
            this.tableLayoutPanel1.SetColumnSpan(this.dgv_ordr_dtls, 7);
            this.dgv_ordr_dtls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_ordr_dtls.Location = new System.Drawing.Point(3, 108);
            this.dgv_ordr_dtls.Name = "dgv_ordr_dtls";
            this.dgv_ordr_dtls.Size = new System.Drawing.Size(858, 122);
            this.dgv_ordr_dtls.TabIndex = 4;
            this.dgv_ordr_dtls.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgv_ordr_dtls_DataError);
            // 
            // c_rec_ser
            // 
            this.c_rec_ser.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.c_rec_ser.DataPropertyName = "rec_ser";
            this.c_rec_ser.HeaderText = "متسلسل";
            this.c_rec_ser.Name = "c_rec_ser";
            this.c_rec_ser.ReadOnly = true;
            this.c_rec_ser.Width = 60;
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
            this.c_prod_id.DataPropertyName = "prod_id";
            this.c_prod_id.HeaderText = "المنتج";
            this.c_prod_id.Name = "c_prod_id";
            // 
            // c_prod_qt
            // 
            this.c_prod_qt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.c_prod_qt.DataPropertyName = "prod_qt";
            this.c_prod_qt.HeaderText = "الكمية";
            this.c_prod_qt.Name = "c_prod_qt";
            // 
            // rdo_ordr_typ_out_2
            // 
            this.rdo_ordr_typ_out_2.AutoSize = true;
            this.rdo_ordr_typ_out_2.Checked = true;
            this.rdo_ordr_typ_out_2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rdo_ordr_typ_out_2.Location = new System.Drawing.Point(666, 3);
            this.rdo_ordr_typ_out_2.Name = "rdo_ordr_typ_out_2";
            this.rdo_ordr_typ_out_2.Size = new System.Drawing.Size(92, 17);
            this.rdo_ordr_typ_out_2.TabIndex = 5;
            this.rdo_ordr_typ_out_2.TabStop = true;
            this.rdo_ordr_typ_out_2.Text = "أمـر صــرف مخزني";
            this.rdo_ordr_typ_out_2.UseVisualStyleBackColor = true;
            // 
            // rdo_ordr_typ_in_1
            // 
            this.rdo_ordr_typ_in_1.AutoSize = true;
            this.rdo_ordr_typ_in_1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rdo_ordr_typ_in_1.Location = new System.Drawing.Point(269, 3);
            this.rdo_ordr_typ_in_1.Name = "rdo_ordr_typ_in_1";
            this.rdo_ordr_typ_in_1.Size = new System.Drawing.Size(336, 17);
            this.rdo_ordr_typ_in_1.TabIndex = 5;
            this.rdo_ordr_typ_in_1.Text = "أمـــر توريد مخزني";
            this.rdo_ordr_typ_in_1.UseVisualStyleBackColor = true;
            this.rdo_ordr_typ_in_1.CheckedChanged += new System.EventHandler(this.rdo_ordr_typ_in_1_CheckedChanged);
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
            this.DgvProds.Location = new System.Drawing.Point(0, 340);
            this.DgvProds.Name = "DgvProds";
            this.DgvProds.ReadOnly = true;
            this.DgvProds.Size = new System.Drawing.Size(878, 141);
            this.DgvProds.TabIndex = 6;
            this.DgvProds.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgv_ordr_dtls_DataError);
            this.DgvProds.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgvProds_RowHeaderMouseDoubleClick);
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
            this.str_id.DataPropertyName = "str_id";
            this.str_id.HeaderText = "المخزن";
            this.str_id.Name = "str_id";
            this.str_id.ReadOnly = true;
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
            this.ordr_type.DataPropertyName = "ordr_type";
            this.ordr_type.HeaderText = "نوع الطلب";
            this.ordr_type.Name = "ordr_type";
            this.ordr_type.ReadOnly = true;
            // 
            // ordr_status
            // 
            this.ordr_status.DataPropertyName = "ordr_status";
            this.ordr_status.HeaderText = "حالة الطلب";
            this.ordr_status.Name = "ordr_status";
            this.ordr_status.ReadOnly = true;
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
            // oper_str_006
            // 
            this.ClientSize = new System.Drawing.Size(878, 481);
            this.Name = "oper_str_006";
            this.RightToLeftLayout = false;
            this.Text = "امر مخــزني";
            ((System.ComponentModel.ISupportInitialize)(this.ErPrMainErrorProvidor)).EndInit();
            this.PnlMainContent.ResumeLayout(false);
            this.pnl_home_body.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ordr_dtls)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvProds)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_ordr_id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmb_str_id;
        private System.Windows.Forms.DateTimePicker dt_ordr_dt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmb_ordr_usr;
        private System.Windows.Forms.TextBox txt_ordr_dsc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmb_ordr_status;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgv_ordr_dtls;
        private System.Windows.Forms.RadioButton rdo_ordr_typ_out_2;
        private System.Windows.Forms.RadioButton rdo_ordr_typ_in_1;
        private System.Windows.Forms.DataGridView DgvProds;
        private System.Windows.Forms.DataGridViewTextBoxColumn ordr_id;
        private System.Windows.Forms.DataGridViewComboBoxColumn str_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn ordr_dt;
        private System.Windows.Forms.DataGridViewComboBoxColumn ordr_usr;
        private System.Windows.Forms.DataGridViewTextBoxColumn ordr_dsc;
        private System.Windows.Forms.DataGridViewComboBoxColumn ordr_type;
        private System.Windows.Forms.DataGridViewComboBoxColumn ordr_status;
        private System.Windows.Forms.DataGridViewTextBoxColumn add_by;
        private System.Windows.Forms.DataGridViewTextBoxColumn add_at;
        private System.Windows.Forms.DataGridViewComboBoxColumn updt_by;
        private System.Windows.Forms.DataGridViewTextBoxColumn updt_at;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_rec_ser;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_ordr_id;
        private System.Windows.Forms.DataGridViewComboBoxColumn c_prod_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_prod_qt;
    }
}
