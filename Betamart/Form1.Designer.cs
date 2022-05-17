namespace Betamart
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
            this.gridData = new System.Windows.Forms.DataGridView();
            this.iDProdukDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namaProdukDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hargaProdukDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jumlahProdukDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tanggalMasukDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tanggalExpiredDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brandProdukDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.betamartBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.betamartDataSet = new Betamart.BetamartDataSet();
            this.panel = new System.Windows.Forms.Panel();
            this.TglKadaluarsa = new System.Windows.Forms.DateTimePicker();
            this.TglMasuk = new System.Windows.Forms.DateTimePicker();
            this.klmBrand = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.klmJumlah = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.klmHarga = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.klmNama = new System.Windows.Forms.TextBox();
            this.tblGambar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.boxGambar = new System.Windows.Forms.PictureBox();
            this.klmCari = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tblSave = new System.Windows.Forms.Button();
            this.tblCancel = new System.Windows.Forms.Button();
            this.tblEdit = new System.Windows.Forms.Button();
            this.tblBaru = new System.Windows.Forms.Button();
            this.BetamartTableAdapter = new Betamart.BetamartDataSetTableAdapters.BetamartTableAdapter();
            this.betamartBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.betamartDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblHapus = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.betamartBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.betamartDataSet)).BeginInit();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.boxGambar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.betamartBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.betamartDataSetBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridData
            // 
            this.gridData.AllowUserToAddRows = false;
            this.gridData.AutoGenerateColumns = false;
            this.gridData.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.gridData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDProdukDataGridViewTextBoxColumn,
            this.namaProdukDataGridViewTextBoxColumn,
            this.hargaProdukDataGridViewTextBoxColumn,
            this.jumlahProdukDataGridViewTextBoxColumn,
            this.tanggalMasukDataGridViewTextBoxColumn,
            this.tanggalExpiredDataGridViewTextBoxColumn,
            this.brandProdukDataGridViewTextBoxColumn});
            this.gridData.DataSource = this.betamartBindingSource;
            this.gridData.Location = new System.Drawing.Point(12, 38);
            this.gridData.Name = "gridData";
            this.gridData.Size = new System.Drawing.Size(672, 424);
            this.gridData.TabIndex = 0;
            // 
            // iDProdukDataGridViewTextBoxColumn
            // 
            this.iDProdukDataGridViewTextBoxColumn.DataPropertyName = "ID_Produk";
            this.iDProdukDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDProdukDataGridViewTextBoxColumn.Name = "iDProdukDataGridViewTextBoxColumn";
            this.iDProdukDataGridViewTextBoxColumn.Width = 30;
            // 
            // namaProdukDataGridViewTextBoxColumn
            // 
            this.namaProdukDataGridViewTextBoxColumn.DataPropertyName = "Nama_Produk";
            this.namaProdukDataGridViewTextBoxColumn.HeaderText = "Nama Produk";
            this.namaProdukDataGridViewTextBoxColumn.Name = "namaProdukDataGridViewTextBoxColumn";
            // 
            // hargaProdukDataGridViewTextBoxColumn
            // 
            this.hargaProdukDataGridViewTextBoxColumn.DataPropertyName = "Harga_Produk";
            this.hargaProdukDataGridViewTextBoxColumn.HeaderText = "Harga Produk";
            this.hargaProdukDataGridViewTextBoxColumn.Name = "hargaProdukDataGridViewTextBoxColumn";
            // 
            // jumlahProdukDataGridViewTextBoxColumn
            // 
            this.jumlahProdukDataGridViewTextBoxColumn.DataPropertyName = "Jumlah_Produk";
            this.jumlahProdukDataGridViewTextBoxColumn.HeaderText = "Jumlah Produk";
            this.jumlahProdukDataGridViewTextBoxColumn.Name = "jumlahProdukDataGridViewTextBoxColumn";
            // 
            // tanggalMasukDataGridViewTextBoxColumn
            // 
            this.tanggalMasukDataGridViewTextBoxColumn.DataPropertyName = "Tanggal_Masuk";
            this.tanggalMasukDataGridViewTextBoxColumn.HeaderText = "Tanggal Masuk";
            this.tanggalMasukDataGridViewTextBoxColumn.Name = "tanggalMasukDataGridViewTextBoxColumn";
            // 
            // tanggalExpiredDataGridViewTextBoxColumn
            // 
            this.tanggalExpiredDataGridViewTextBoxColumn.DataPropertyName = "Tanggal_Expired";
            this.tanggalExpiredDataGridViewTextBoxColumn.HeaderText = "Tanggal Expired";
            this.tanggalExpiredDataGridViewTextBoxColumn.Name = "tanggalExpiredDataGridViewTextBoxColumn";
            // 
            // brandProdukDataGridViewTextBoxColumn
            // 
            this.brandProdukDataGridViewTextBoxColumn.DataPropertyName = "Brand_Produk";
            this.brandProdukDataGridViewTextBoxColumn.HeaderText = "Brand Produk";
            this.brandProdukDataGridViewTextBoxColumn.Name = "brandProdukDataGridViewTextBoxColumn";
            // 
            // betamartBindingSource
            // 
            this.betamartBindingSource.DataMember = "Betamart";
            this.betamartBindingSource.DataSource = this.betamartDataSet;
            // 
            // betamartDataSet
            // 
            this.betamartDataSet.DataSetName = "BetamartDataSet";
            this.betamartDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel
            // 
            this.panel.Controls.Add(this.TglKadaluarsa);
            this.panel.Controls.Add(this.TglMasuk);
            this.panel.Controls.Add(this.klmBrand);
            this.panel.Controls.Add(this.label7);
            this.panel.Controls.Add(this.label6);
            this.panel.Controls.Add(this.label4);
            this.panel.Controls.Add(this.klmJumlah);
            this.panel.Controls.Add(this.label3);
            this.panel.Controls.Add(this.klmHarga);
            this.panel.Controls.Add(this.label2);
            this.panel.Controls.Add(this.klmNama);
            this.panel.Controls.Add(this.tblGambar);
            this.panel.Controls.Add(this.label1);
            this.panel.Controls.Add(this.boxGambar);
            this.panel.Location = new System.Drawing.Point(690, 12);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(309, 450);
            this.panel.TabIndex = 0;
            // 
            // TglKadaluarsa
            // 
            this.TglKadaluarsa.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.betamartBindingSource, "Tanggal_Expired", true));
            this.TglKadaluarsa.Location = new System.Drawing.Point(14, 389);
            this.TglKadaluarsa.Name = "TglKadaluarsa";
            this.TglKadaluarsa.Size = new System.Drawing.Size(280, 20);
            this.TglKadaluarsa.TabIndex = 14;
            this.TglKadaluarsa.Value = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            // 
            // TglMasuk
            // 
            this.TglMasuk.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.betamartBindingSource, "Tanggal_Masuk", true));
            this.TglMasuk.Location = new System.Drawing.Point(14, 348);
            this.TglMasuk.Name = "TglMasuk";
            this.TglMasuk.Size = new System.Drawing.Size(280, 20);
            this.TglMasuk.TabIndex = 13;
            this.TglMasuk.Value = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            // 
            // klmBrand
            // 
            this.klmBrand.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.betamartBindingSource, "Brand_Produk", true));
            this.klmBrand.Location = new System.Drawing.Point(14, 430);
            this.klmBrand.Name = "klmBrand";
            this.klmBrand.Size = new System.Drawing.Size(280, 20);
            this.klmBrand.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(11, 412);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 15);
            this.label7.TabIndex = 12;
            this.label7.Text = "Brand Produk :";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(11, 371);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "Tanggal Kadaluarsa :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 330);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Tanggal Dimasukan :";
            // 
            // klmJumlah
            // 
            this.klmJumlah.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.betamartBindingSource, "Jumlah_Produk", true));
            this.klmJumlah.Location = new System.Drawing.Point(14, 307);
            this.klmJumlah.Name = "klmJumlah";
            this.klmJumlah.Size = new System.Drawing.Size(280, 20);
            this.klmJumlah.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 289);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Jumlah Produk :";
            // 
            // klmHarga
            // 
            this.klmHarga.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.betamartBindingSource, "Harga_Produk", true));
            this.klmHarga.Location = new System.Drawing.Point(14, 266);
            this.klmHarga.Name = "klmHarga";
            this.klmHarga.Size = new System.Drawing.Size(280, 20);
            this.klmHarga.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 248);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Harga Produk :";
            // 
            // klmNama
            // 
            this.klmNama.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.betamartBindingSource, "Nama_Produk", true));
            this.klmNama.Location = new System.Drawing.Point(14, 225);
            this.klmNama.Name = "klmNama";
            this.klmNama.Size = new System.Drawing.Size(280, 20);
            this.klmNama.TabIndex = 0;
            // 
            // tblGambar
            // 
            this.tblGambar.BackColor = System.Drawing.Color.SlateBlue;
            this.tblGambar.FlatAppearance.BorderSize = 0;
            this.tblGambar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tblGambar.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tblGambar.ForeColor = System.Drawing.Color.White;
            this.tblGambar.Location = new System.Drawing.Point(190, 175);
            this.tblGambar.Name = "tblGambar";
            this.tblGambar.Size = new System.Drawing.Size(104, 26);
            this.tblGambar.TabIndex = 2;
            this.tblGambar.Text = "Tambah Gambar";
            this.tblGambar.UseVisualStyleBackColor = false;
            this.tblGambar.Click += new System.EventHandler(this.tblGambar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 204);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nama Produk :";
            // 
            // boxGambar
            // 
            this.boxGambar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.boxGambar.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.betamartBindingSource, "Gambar_Produk", true));
            this.boxGambar.Location = new System.Drawing.Point(14, 0);
            this.boxGambar.Name = "boxGambar";
            this.boxGambar.Size = new System.Drawing.Size(145, 201);
            this.boxGambar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.boxGambar.TabIndex = 0;
            this.boxGambar.TabStop = false;
            // 
            // klmCari
            // 
            this.klmCari.Location = new System.Drawing.Point(108, 12);
            this.klmCari.Name = "klmCari";
            this.klmCari.Size = new System.Drawing.Size(576, 20);
            this.klmCari.TabIndex = 1;
            this.klmCari.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.klmCari_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Cari Produk :";
            // 
            // tblSave
            // 
            this.tblSave.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tblSave.FlatAppearance.BorderSize = 0;
            this.tblSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tblSave.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tblSave.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tblSave.Location = new System.Drawing.Point(494, 12);
            this.tblSave.Name = "tblSave";
            this.tblSave.Size = new System.Drawing.Size(75, 23);
            this.tblSave.TabIndex = 5;
            this.tblSave.Text = "Save";
            this.tblSave.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tblSave.UseVisualStyleBackColor = false;
            this.tblSave.Click += new System.EventHandler(this.tblSave_Click);
            // 
            // tblCancel
            // 
            this.tblCancel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tblCancel.FlatAppearance.BorderSize = 0;
            this.tblCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tblCancel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tblCancel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tblCancel.Location = new System.Drawing.Point(799, 12);
            this.tblCancel.Name = "tblCancel";
            this.tblCancel.Size = new System.Drawing.Size(75, 23);
            this.tblCancel.TabIndex = 4;
            this.tblCancel.Text = "Cancel";
            this.tblCancel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tblCancel.UseVisualStyleBackColor = false;
            this.tblCancel.Click += new System.EventHandler(this.tblCancel_Click);
            // 
            // tblEdit
            // 
            this.tblEdit.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tblEdit.FlatAppearance.BorderSize = 0;
            this.tblEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tblEdit.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tblEdit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tblEdit.Location = new System.Drawing.Point(689, 12);
            this.tblEdit.Name = "tblEdit";
            this.tblEdit.Size = new System.Drawing.Size(87, 23);
            this.tblEdit.TabIndex = 3;
            this.tblEdit.Text = "Edit Produk";
            this.tblEdit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tblEdit.UseVisualStyleBackColor = false;
            this.tblEdit.Click += new System.EventHandler(this.tblEdit_Click);
            // 
            // tblBaru
            // 
            this.tblBaru.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tblBaru.FlatAppearance.BorderSize = 0;
            this.tblBaru.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tblBaru.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tblBaru.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tblBaru.Location = new System.Drawing.Point(894, 12);
            this.tblBaru.Name = "tblBaru";
            this.tblBaru.Size = new System.Drawing.Size(89, 23);
            this.tblBaru.TabIndex = 2;
            this.tblBaru.Text = "Tambah Baru";
            this.tblBaru.UseVisualStyleBackColor = false;
            this.tblBaru.Click += new System.EventHandler(this.tblBaru_Click);
            // 
            // BetamartTableAdapter
            // 
            this.BetamartTableAdapter.ClearBeforeFill = true;
            // 
            // betamartBindingSource1
            // 
            this.betamartBindingSource1.DataMember = "Betamart";
            this.betamartBindingSource1.DataSource = this.betamartDataSet;
            // 
            // betamartDataSetBindingSource
            // 
            this.betamartDataSetBindingSource.DataSource = this.betamartDataSet;
            this.betamartDataSetBindingSource.Position = 0;
            // 
            // tblHapus
            // 
            this.tblHapus.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tblHapus.FlatAppearance.BorderSize = 0;
            this.tblHapus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tblHapus.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tblHapus.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tblHapus.Location = new System.Drawing.Point(593, 12);
            this.tblHapus.Name = "tblHapus";
            this.tblHapus.Size = new System.Drawing.Size(75, 23);
            this.tblHapus.TabIndex = 11;
            this.tblHapus.Text = "Hapus";
            this.tblHapus.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tblHapus.UseVisualStyleBackColor = false;
            this.tblHapus.Click += new System.EventHandler(this.tblHapus_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SlateBlue;
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.tblHapus);
            this.panel1.Controls.Add(this.tblBaru);
            this.panel1.Controls.Add(this.tblSave);
            this.panel1.Controls.Add(this.tblEdit);
            this.panel1.Controls.Add(this.tblCancel);
            this.panel1.Location = new System.Drawing.Point(1, 468);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(998, 48);
            this.panel1.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(11, 8);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(167, 30);
            this.label8.TabIndex = 0;
            this.label8.Text = "B E T A M A R T";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 515);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.klmCari);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.gridData);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "B E T A M A R T";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.betamartBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.betamartDataSet)).EndInit();
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.boxGambar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.betamartBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.betamartDataSetBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridData;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox klmJumlah;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox klmHarga;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox klmNama;
        private System.Windows.Forms.Button tblGambar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox boxGambar;
        private System.Windows.Forms.TextBox klmCari;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button tblSave;
        private System.Windows.Forms.Button tblCancel;
        private System.Windows.Forms.Button tblEdit;
        private System.Windows.Forms.Button tblBaru;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox klmBrand;
        private System.Windows.Forms.Label label7;
        private BetamartDataSet betamartDataSet;
        private System.Windows.Forms.BindingSource betamartBindingSource;
        private BetamartDataSetTableAdapters.BetamartTableAdapter BetamartTableAdapter;
        private System.Windows.Forms.BindingSource betamartBindingSource1;
        private System.Windows.Forms.BindingSource betamartDataSetBindingSource;
        private System.Windows.Forms.Button tblHapus;
        private System.Windows.Forms.DateTimePicker TglKadaluarsa;
        private System.Windows.Forms.DateTimePicker TglMasuk;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDProdukDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaProdukDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hargaProdukDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jumlahProdukDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tanggalMasukDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tanggalExpiredDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn brandProdukDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
    }
}

