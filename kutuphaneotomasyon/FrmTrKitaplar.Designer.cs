namespace kutuphaneotomasyon
{
    partial class FrmTrKitaplar
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
            this.btnMainMenu = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tblTrKitaplarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbKutuphaneDataSet = new kutuphaneotomasyon.DbKutuphaneDataSet();
            this.tbl_TrKitaplarTableAdapter = new kutuphaneotomasyon.DbKutuphaneDataSetTableAdapters.tbl_TrKitaplarTableAdapter();
            this.txtKitapNo = new System.Windows.Forms.TextBox();
            this.txtRafNo = new System.Windows.Forms.TextBox();
            this.txtKitapAdi = new System.Windows.Forms.TextBox();
            this.txtKitapYazar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnYenile = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.atxtKitapYazar = new System.Windows.Forms.TextBox();
            this.atxtKitapAdi = new System.Windows.Forms.TextBox();
            this.atxtKitapRafNo = new System.Windows.Forms.TextBox();
            this.atxtKitapNo = new System.Windows.Forms.TextBox();
            this.dbKutuphaneDataSet2 = new kutuphaneotomasyon.DbKutuphaneDataSet2();
            this.tblTrKitaplarBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_TrKitaplarTableAdapter1 = new kutuphaneotomasyon.DbKutuphaneDataSet2TableAdapters.tbl_TrKitaplarTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kitapNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kitapRafDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KitapAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kitapYazarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblTrKitaplarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbKutuphaneDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dbKutuphaneDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblTrKitaplarBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMainMenu
            // 
            this.btnMainMenu.Location = new System.Drawing.Point(-3, -3);
            this.btnMainMenu.Name = "btnMainMenu";
            this.btnMainMenu.Size = new System.Drawing.Size(119, 31);
            this.btnMainMenu.TabIndex = 0;
            this.btnMainMenu.Text = "Ana Ekran";
            this.btnMainMenu.UseVisualStyleBackColor = true;
            this.btnMainMenu.Click += new System.EventHandler(this.btnMainMenu_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.kitapNoDataGridViewTextBoxColumn,
            this.kitapRafDataGridViewTextBoxColumn,
            this.KitapAdi,
            this.kitapYazarDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblTrKitaplarBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(-3, 258);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1103, 200);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEnter);
            // 
            // tblTrKitaplarBindingSource
            // 
            this.tblTrKitaplarBindingSource.DataMember = "tbl_TrKitaplar";
            this.tblTrKitaplarBindingSource.DataSource = this.dbKutuphaneDataSet;
            // 
            // dbKutuphaneDataSet
            // 
            this.dbKutuphaneDataSet.DataSetName = "DbKutuphaneDataSet";
            this.dbKutuphaneDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_TrKitaplarTableAdapter
            // 
            this.tbl_TrKitaplarTableAdapter.ClearBeforeFill = true;
            // 
            // txtKitapNo
            // 
            this.txtKitapNo.Location = new System.Drawing.Point(144, 49);
            this.txtKitapNo.Name = "txtKitapNo";
            this.txtKitapNo.Size = new System.Drawing.Size(220, 29);
            this.txtKitapNo.TabIndex = 2;
            // 
            // txtRafNo
            // 
            this.txtRafNo.Location = new System.Drawing.Point(144, 84);
            this.txtRafNo.Name = "txtRafNo";
            this.txtRafNo.Size = new System.Drawing.Size(220, 29);
            this.txtRafNo.TabIndex = 3;
            // 
            // txtKitapAdi
            // 
            this.txtKitapAdi.Location = new System.Drawing.Point(144, 119);
            this.txtKitapAdi.Name = "txtKitapAdi";
            this.txtKitapAdi.Size = new System.Drawing.Size(220, 29);
            this.txtKitapAdi.TabIndex = 4;
            // 
            // txtKitapYazar
            // 
            this.txtKitapYazar.Location = new System.Drawing.Point(144, 159);
            this.txtKitapYazar.Name = "txtKitapYazar";
            this.txtKitapYazar.Size = new System.Drawing.Size(220, 29);
            this.txtKitapYazar.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 23);
            this.label1.TabIndex = 6;
            this.label1.Text = "Kitap No";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 23);
            this.label2.TabIndex = 7;
            this.label2.Text = "Kitap Raf NO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 23);
            this.label3.TabIndex = 8;
            this.label3.Text = "Kitap Adı";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 23);
            this.label4.TabIndex = 9;
            this.label4.Text = "Kitap Yazarı";
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(370, 27);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(93, 48);
            this.btnEkle.TabIndex = 10;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(370, 81);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(93, 48);
            this.btnSil.TabIndex = 11;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(370, 135);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(93, 48);
            this.btnGuncelle.TabIndex = 12;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnYenile
            // 
            this.btnYenile.Location = new System.Drawing.Point(370, 189);
            this.btnYenile.Name = "btnYenile";
            this.btnYenile.Size = new System.Drawing.Size(93, 63);
            this.btnYenile.TabIndex = 13;
            this.btnYenile.Text = "Listeyi Yenile";
            this.btnYenile.UseVisualStyleBackColor = true;
            this.btnYenile.Click += new System.EventHandler(this.btnYenile_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(127, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(237, 23);
            this.label5.TabIndex = 14;
            this.label5.Text = "Hiç  Bir değeri Boş Girmeyin";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(144, 14);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(220, 29);
            this.textBox1.TabIndex = 15;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.atxtKitapYazar);
            this.groupBox1.Controls.Add(this.atxtKitapAdi);
            this.groupBox1.Controls.Add(this.atxtKitapRafNo);
            this.groupBox1.Controls.Add(this.atxtKitapNo);
            this.groupBox1.Location = new System.Drawing.Point(575, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(540, 238);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Arama";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 142);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 23);
            this.label6.TabIndex = 17;
            this.label6.Text = "Kitap Yazarı";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(46, 105);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 23);
            this.label7.TabIndex = 16;
            this.label7.Text = "Kitap Adı";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 73);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 23);
            this.label8.TabIndex = 15;
            this.label8.Text = "Kitap Raf NO";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(51, 35);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 23);
            this.label9.TabIndex = 14;
            this.label9.Text = "Kitap No";
            // 
            // atxtKitapYazar
            // 
            this.atxtKitapYazar.Location = new System.Drawing.Point(138, 142);
            this.atxtKitapYazar.Name = "atxtKitapYazar";
            this.atxtKitapYazar.Size = new System.Drawing.Size(220, 29);
            this.atxtKitapYazar.TabIndex = 13;
            this.atxtKitapYazar.TextChanged += new System.EventHandler(this.atxtKitapYazar_TextChanged);
            // 
            // atxtKitapAdi
            // 
            this.atxtKitapAdi.Location = new System.Drawing.Point(138, 102);
            this.atxtKitapAdi.Name = "atxtKitapAdi";
            this.atxtKitapAdi.Size = new System.Drawing.Size(220, 29);
            this.atxtKitapAdi.TabIndex = 12;
            this.atxtKitapAdi.TextChanged += new System.EventHandler(this.atxtKitapAdi_TextChanged);
            // 
            // atxtKitapRafNo
            // 
            this.atxtKitapRafNo.Location = new System.Drawing.Point(138, 67);
            this.atxtKitapRafNo.Name = "atxtKitapRafNo";
            this.atxtKitapRafNo.Size = new System.Drawing.Size(220, 29);
            this.atxtKitapRafNo.TabIndex = 11;
            this.atxtKitapRafNo.TextChanged += new System.EventHandler(this.atxtKitapRafNo_TextChanged);
            // 
            // atxtKitapNo
            // 
            this.atxtKitapNo.Location = new System.Drawing.Point(138, 32);
            this.atxtKitapNo.Name = "atxtKitapNo";
            this.atxtKitapNo.Size = new System.Drawing.Size(220, 29);
            this.atxtKitapNo.TabIndex = 10;
            this.atxtKitapNo.TextChanged += new System.EventHandler(this.atxtKitapNo_TextChanged);
            // 
            // dbKutuphaneDataSet2
            // 
            this.dbKutuphaneDataSet2.DataSetName = "DbKutuphaneDataSet2";
            this.dbKutuphaneDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblTrKitaplarBindingSource1
            // 
            this.tblTrKitaplarBindingSource1.DataMember = "tbl_TrKitaplar";
            this.tblTrKitaplarBindingSource1.DataSource = this.dbKutuphaneDataSet2;
            // 
            // tbl_TrKitaplarTableAdapter1
            // 
            this.tbl_TrKitaplarTableAdapter1.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 55;
            // 
            // kitapNoDataGridViewTextBoxColumn
            // 
            this.kitapNoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.kitapNoDataGridViewTextBoxColumn.DataPropertyName = "KitapNo";
            this.kitapNoDataGridViewTextBoxColumn.HeaderText = "KitapNo";
            this.kitapNoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kitapNoDataGridViewTextBoxColumn.Name = "kitapNoDataGridViewTextBoxColumn";
            this.kitapNoDataGridViewTextBoxColumn.Width = 105;
            // 
            // kitapRafDataGridViewTextBoxColumn
            // 
            this.kitapRafDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.kitapRafDataGridViewTextBoxColumn.DataPropertyName = "KitapRaf";
            this.kitapRafDataGridViewTextBoxColumn.HeaderText = "KitapRaf";
            this.kitapRafDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kitapRafDataGridViewTextBoxColumn.Name = "kitapRafDataGridViewTextBoxColumn";
            this.kitapRafDataGridViewTextBoxColumn.Width = 109;
            // 
            // KitapAdi
            // 
            this.KitapAdi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.KitapAdi.DataPropertyName = "KitapAdi";
            this.KitapAdi.HeaderText = "KitapAdi";
            this.KitapAdi.MinimumWidth = 6;
            this.KitapAdi.Name = "KitapAdi";
            this.KitapAdi.Width = 110;
            // 
            // kitapYazarDataGridViewTextBoxColumn
            // 
            this.kitapYazarDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.kitapYazarDataGridViewTextBoxColumn.DataPropertyName = "KitapYazar";
            this.kitapYazarDataGridViewTextBoxColumn.HeaderText = "KitapYazar";
            this.kitapYazarDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kitapYazarDataGridViewTextBoxColumn.Name = "kitapYazarDataGridViewTextBoxColumn";
            this.kitapYazarDataGridViewTextBoxColumn.Width = 123;
            // 
            // FrmTrKitaplar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1127, 470);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnYenile);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtKitapYazar);
            this.Controls.Add(this.txtKitapAdi);
            this.Controls.Add(this.txtRafNo);
            this.Controls.Add(this.txtKitapNo);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnMainMenu);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmTrKitaplar";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Türkçe Kitaplar";
            this.Load += new System.EventHandler(this.FrmTrKitaplar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblTrKitaplarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbKutuphaneDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dbKutuphaneDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblTrKitaplarBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMainMenu;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DbKutuphaneDataSet dbKutuphaneDataSet;
        private System.Windows.Forms.BindingSource tblTrKitaplarBindingSource;
        private DbKutuphaneDataSetTableAdapters.tbl_TrKitaplarTableAdapter tbl_TrKitaplarTableAdapter;
        private System.Windows.Forms.TextBox txtKitapNo;
        private System.Windows.Forms.TextBox txtRafNo;
        private System.Windows.Forms.TextBox txtKitapAdi;
        private System.Windows.Forms.TextBox txtKitapYazar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnYenile;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox atxtKitapYazar;
        private System.Windows.Forms.TextBox atxtKitapAdi;
        private System.Windows.Forms.TextBox atxtKitapRafNo;
        private System.Windows.Forms.TextBox atxtKitapNo;
        private DbKutuphaneDataSet2 dbKutuphaneDataSet2;
        private System.Windows.Forms.BindingSource tblTrKitaplarBindingSource1;
        private DbKutuphaneDataSet2TableAdapters.tbl_TrKitaplarTableAdapter tbl_TrKitaplarTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitapNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitapRafDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn KitapAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitapYazarDataGridViewTextBoxColumn;
    }
}