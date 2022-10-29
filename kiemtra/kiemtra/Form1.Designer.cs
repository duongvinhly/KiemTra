namespace kiemtra
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.nhomBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLDBDataSet = new kiemtra.QLDBDataSet();
            this.nguoiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nguoiTableAdapter = new kiemtra.QLDBDataSetTableAdapters.NguoiTableAdapter();
            this.nhomTableAdapter = new kiemtra.QLDBDataSetTableAdapters.NhomTableAdapter();
            this.nguoiBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.nguoiBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.TenNhom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nhomDataTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.TenGoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nguoiDataTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtTen = new System.Windows.Forms.Label();
            this.txtDia = new System.Windows.Forms.Label();
            this.txtE = new System.Windows.Forms.Label();
            this.txtS = new System.Windows.Forms.Label();
            this.nguoiRowBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtTenGoi = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.Label();
            this.txtSDT = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nhomBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nguoiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nguoiBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nguoiBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhomDataTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nguoiDataTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nguoiRowBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripLabel1,
            this.toolStripButton2,
            this.toolStripLabel2,
            this.toolStripButton3,
            this.toolStripLabel3,
            this.toolStripButton4,
            this.toolStripLabel4});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(75, 22);
            this.toolStripLabel1.Text = " Thêm nhóm";
            this.toolStripLabel1.Click += new System.EventHandler(this.ThemClick);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "toolStripButton2";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(65, 22);
            this.toolStripLabel2.Text = " Xóa nhóm";
            this.toolStripLabel2.Click += new System.EventHandler(this.XoaClick);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton3.Text = "toolStripButton3";
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(80, 22);
            this.toolStripLabel3.Text = " Thêm liên lạc";
            this.toolStripLabel3.Click += new System.EventHandler(this.ThemLienLacClick);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton4.Text = "toolStripButton4";
            // 
            // toolStripLabel4
            // 
            this.toolStripLabel4.Name = "toolStripLabel4";
            this.toolStripLabel4.Size = new System.Drawing.Size(67, 22);
            this.toolStripLabel4.Text = "Xóa liên lạc";
            this.toolStripLabel4.Click += new System.EventHandler(this.XoaLienlacClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(541, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = " Nhập từ cần tìm:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(636, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(152, 20);
            this.textBox1.TabIndex = 2;
            // 
            // nhomBindingSource
            // 
            this.nhomBindingSource.DataMember = "Nhom";
            this.nhomBindingSource.DataSource = this.qLDBDataSetBindingSource;
            // 
            // qLDBDataSetBindingSource
            // 
            this.qLDBDataSetBindingSource.DataSource = this.qLDBDataSet;
            this.qLDBDataSetBindingSource.Position = 0;
            // 
            // qLDBDataSet
            // 
            this.qLDBDataSet.DataSetName = "QLDBDataSet";
            this.qLDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nguoiBindingSource
            // 
            this.nguoiBindingSource.DataMember = "Nguoi";
            this.nguoiBindingSource.DataSource = this.qLDBDataSetBindingSource;
            // 
            // nguoiTableAdapter
            // 
            this.nguoiTableAdapter.ClearBeforeFill = true;
            // 
            // nhomTableAdapter
            // 
            this.nhomTableAdapter.ClearBeforeFill = true;
            // 
            // nguoiBindingSource1
            // 
            this.nguoiBindingSource1.DataMember = "Nguoi";
            this.nguoiBindingSource1.DataSource = this.qLDBDataSetBindingSource;
            // 
            // nguoiBindingSource2
            // 
            this.nguoiBindingSource2.DataMember = "Nguoi";
            this.nguoiBindingSource2.DataSource = this.qLDBDataSetBindingSource;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TenNhom});
            this.dataGridView1.DataSource = this.nhomDataTableBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 424);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Cellclick_nhom);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // TenNhom
            // 
            this.TenNhom.DataPropertyName = "TenNhom";
            this.TenNhom.HeaderText = "TenNhom";
            this.TenNhom.Name = "TenNhom";
            this.TenNhom.Width = 230;
            // 
            // nhomDataTableBindingSource
            // 
            this.nhomDataTableBindingSource.DataSource = typeof(kiemtra.QLDBDataSet.NhomDataTable);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TenGoi,
            this.Email,
            this.SDT});
            this.dataGridView2.DataSource = this.nguoiDataTableBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(246, 28);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(554, 219);
            this.dataGridView2.TabIndex = 4;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CellclickNguoi);
            // 
            // TenGoi
            // 
            this.TenGoi.DataPropertyName = "TenGoi";
            this.TenGoi.HeaderText = "TenGoi";
            this.TenGoi.Name = "TenGoi";
            this.TenGoi.Width = 160;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.Width = 220;
            // 
            // SDT
            // 
            this.SDT.DataPropertyName = "SDT";
            this.SDT.HeaderText = "SDT";
            this.SDT.Name = "SDT";
            this.SDT.Width = 140;
            // 
            // nguoiDataTableBindingSource
            // 
            this.nguoiDataTableBindingSource.DataSource = typeof(kiemtra.QLDBDataSet.NguoiDataTable);
            // 
            // txtTen
            // 
            this.txtTen.AutoSize = true;
            this.txtTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTen.Location = new System.Drawing.Point(274, 269);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(90, 25);
            this.txtTen.TabIndex = 5;
            this.txtTen.Text = "[Tên gọi]";
            // 
            // txtDia
            // 
            this.txtDia.AutoSize = true;
            this.txtDia.Location = new System.Drawing.Point(276, 312);
            this.txtDia.Name = "txtDia";
            this.txtDia.Size = new System.Drawing.Size(46, 13);
            this.txtDia.TabIndex = 6;
            this.txtDia.Text = "Địa chỉ :";
            this.txtDia.Click += new System.EventHandler(this.txtDiaChi_Click);
            // 
            // txtE
            // 
            this.txtE.AutoSize = true;
            this.txtE.Location = new System.Drawing.Point(276, 344);
            this.txtE.Name = "txtE";
            this.txtE.Size = new System.Drawing.Size(38, 13);
            this.txtE.TabIndex = 7;
            this.txtE.Text = "Email :";
            this.txtE.Click += new System.EventHandler(this.XoaLienlacClick);
            // 
            // txtS
            // 
            this.txtS.AutoSize = true;
            this.txtS.Location = new System.Drawing.Point(276, 382);
            this.txtS.Name = "txtS";
            this.txtS.Size = new System.Drawing.Size(35, 13);
            this.txtS.TabIndex = 8;
            this.txtS.Text = "SDT :";
            // 
            // nguoiRowBindingSource
            // 
            this.nguoiRowBindingSource.DataSource = typeof(kiemtra.QLDBDataSet.NguoiRow);
            // 
            // txtTenGoi
            // 
            this.txtTenGoi.AutoSize = true;
            this.txtTenGoi.Location = new System.Drawing.Point(393, 278);
            this.txtTenGoi.Name = "txtTenGoi";
            this.txtTenGoi.Size = new System.Drawing.Size(0, 13);
            this.txtTenGoi.TabIndex = 9;
            this.txtTenGoi.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.AutoSize = true;
            this.txtDiaChi.Location = new System.Drawing.Point(341, 312);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(0, 13);
            this.txtDiaChi.TabIndex = 9;
            this.txtDiaChi.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.AutoSize = true;
            this.txtEmail.Location = new System.Drawing.Point(341, 344);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(0, 13);
            this.txtEmail.TabIndex = 9;
            this.txtEmail.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtSDT
            // 
            this.txtSDT.AutoSize = true;
            this.txtSDT.Location = new System.Drawing.Point(341, 382);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(0, 13);
            this.txtSDT.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 425);
            this.Controls.Add(this.txtSDT);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.txtTenGoi);
            this.Controls.Add(this.txtS);
            this.Controls.Add(this.txtE);
            this.Controls.Add(this.txtDia);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nhomBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nguoiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nguoiBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nguoiBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhomDataTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nguoiDataTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nguoiRowBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.BindingSource qLDBDataSetBindingSource;
        private QLDBDataSet qLDBDataSet;
        private System.Windows.Forms.BindingSource nguoiBindingSource;
        private QLDBDataSetTableAdapters.NguoiTableAdapter nguoiTableAdapter;
        private System.Windows.Forms.BindingSource nhomBindingSource;
        private QLDBDataSetTableAdapters.NhomTableAdapter nhomTableAdapter;
        private System.Windows.Forms.BindingSource nguoiBindingSource1;
        private System.Windows.Forms.BindingSource nguoiBindingSource2;
        private System.Windows.Forms.BindingSource nguoiRowBindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource nhomDataTableBindingSource;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource nguoiDataTableBindingSource;
        private System.Windows.Forms.Label txtTen;
        private System.Windows.Forms.Label txtDia;
        private System.Windows.Forms.Label txtE;
        private System.Windows.Forms.Label txtS;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNhom;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenGoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDT;
        private System.Windows.Forms.Label txtTenGoi;
        private System.Windows.Forms.Label txtDiaChi;
        private System.Windows.Forms.Label txtEmail;
        private System.Windows.Forms.Label txtSDT;
    }
}

