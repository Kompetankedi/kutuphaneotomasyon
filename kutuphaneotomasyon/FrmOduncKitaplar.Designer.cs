namespace kutuphaneotomasyon
{
    partial class FrmOduncKitaplar
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtaraSinif = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.TxtAraKitapAdi = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAraKitapNo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtAraAdSoyad = new System.Windows.Forms.TextBox();
            this.txtAliciAdSoyad = new System.Windows.Forms.TextBox();
            this.TxtSinif = new System.Windows.Forms.TextBox();
            this.txtKitapNo = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnListeYenile = new System.Windows.Forms.Button();
            this.TxtKitabinAdi = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbAciklama = new System.Windows.Forms.ComboBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnYeni = new System.Windows.Forms.Button();
            this.lblİd = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnMainMenu
            // 
            this.btnMainMenu.Location = new System.Drawing.Point(-1, -2);
            this.btnMainMenu.Name = "btnMainMenu";
            this.btnMainMenu.Size = new System.Drawing.Size(102, 30);
            this.btnMainMenu.TabIndex = 2;
            this.btnMainMenu.Text = "Ana Ekran";
            this.btnMainMenu.UseVisualStyleBackColor = true;
            this.btnMainMenu.Click += new System.EventHandler(this.btnMainMenu_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 492);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(1078, 150);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtaraSinif);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.TxtAraKitapAdi);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtAraKitapNo);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtAraAdSoyad);
            this.groupBox1.Location = new System.Drawing.Point(638, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(407, 220);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Arama";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtaraSinif
            // 
            this.txtaraSinif.Location = new System.Drawing.Point(157, 153);
            this.txtaraSinif.Name = "txtaraSinif";
            this.txtaraSinif.Size = new System.Drawing.Size(220, 25);
            this.txtaraSinif.TabIndex = 21;
            this.txtaraSinif.TextChanged += new System.EventHandler(this.txtaraSinif_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(87, 160);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(36, 17);
            this.label11.TabIndex = 20;
            this.label11.Text = "Sınıf";
            // 
            // TxtAraKitapAdi
            // 
            this.TxtAraKitapAdi.Location = new System.Drawing.Point(157, 113);
            this.TxtAraKitapAdi.Name = "TxtAraKitapAdi";
            this.TxtAraKitapAdi.Size = new System.Drawing.Size(220, 25);
            this.TxtAraKitapAdi.TabIndex = 19;
            this.TxtAraKitapAdi.TextChanged += new System.EventHandler(this.TxtAraKitapAdi_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(50, 119);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 17);
            this.label10.TabIndex = 18;
            this.label10.Text = "Kitabın Adı";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 17);
            this.label4.TabIndex = 17;
            this.label4.Text = "Kitap Numarası";
            // 
            // txtAraKitapNo
            // 
            this.txtAraKitapNo.Location = new System.Drawing.Point(157, 69);
            this.txtAraKitapNo.Name = "txtAraKitapNo";
            this.txtAraKitapNo.Size = new System.Drawing.Size(220, 25);
            this.txtAraKitapNo.TabIndex = 16;
            this.txtAraKitapNo.TextChanged += new System.EventHandler(this.txtAraKitapNo_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(64, 34);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 17);
            this.label9.TabIndex = 14;
            this.label9.Text = "Ad Soyad";
            // 
            // txtAraAdSoyad
            // 
            this.txtAraAdSoyad.Location = new System.Drawing.Point(157, 31);
            this.txtAraAdSoyad.Name = "txtAraAdSoyad";
            this.txtAraAdSoyad.Size = new System.Drawing.Size(220, 25);
            this.txtAraAdSoyad.TabIndex = 10;
            this.txtAraAdSoyad.TextChanged += new System.EventHandler(this.txtAraAdSoyad_TextChanged);
            // 
            // txtAliciAdSoyad
            // 
            this.txtAliciAdSoyad.Location = new System.Drawing.Point(196, 131);
            this.txtAliciAdSoyad.Name = "txtAliciAdSoyad";
            this.txtAliciAdSoyad.Size = new System.Drawing.Size(121, 25);
            this.txtAliciAdSoyad.TabIndex = 4;
            // 
            // TxtSinif
            // 
            this.TxtSinif.Location = new System.Drawing.Point(196, 287);
            this.TxtSinif.Name = "TxtSinif";
            this.TxtSinif.Size = new System.Drawing.Size(121, 25);
            this.TxtSinif.TabIndex = 5;
            // 
            // txtKitapNo
            // 
            this.txtKitapNo.Location = new System.Drawing.Point(196, 234);
            this.txtKitapNo.Name = "txtKitapNo";
            this.txtKitapNo.Size = new System.Drawing.Size(121, 25);
            this.txtKitapNo.TabIndex = 6;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(194, 383);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(311, 25);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(359, 105);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(146, 39);
            this.btnEkle.TabIndex = 9;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(359, 217);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(146, 36);
            this.btnSil.TabIndex = 10;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(359, 161);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(146, 39);
            this.btnGuncelle.TabIndex = 11;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "Alıcı Ad Soyad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(130, 293);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "Sınıf";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 240);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "Kitap Numarası";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(58, 389);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 17);
            this.label5.TabIndex = 18;
            this.label5.Text = "Alındığı Tarih";
            // 
            // btnListeYenile
            // 
            this.btnListeYenile.Location = new System.Drawing.Point(359, 274);
            this.btnListeYenile.Name = "btnListeYenile";
            this.btnListeYenile.Size = new System.Drawing.Size(146, 36);
            this.btnListeYenile.TabIndex = 19;
            this.btnListeYenile.Text = "Listeyi Yenile";
            this.btnListeYenile.UseVisualStyleBackColor = true;
            this.btnListeYenile.Click += new System.EventHandler(this.btnListeYenile_Click);
            // 
            // TxtKitabinAdi
            // 
            this.TxtKitabinAdi.Location = new System.Drawing.Point(196, 186);
            this.TxtKitabinAdi.Name = "TxtKitabinAdi";
            this.TxtKitabinAdi.Size = new System.Drawing.Size(121, 25);
            this.TxtKitabinAdi.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(81, 193);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 17);
            this.label6.TabIndex = 22;
            this.label6.Text = "Kitabın Adı";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(194, 432);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(311, 25);
            this.dateTimePicker2.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(39, 438);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 17);
            this.label7.TabIndex = 24;
            this.label7.Text = "İade Ettiği Tarih";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(72, 336);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 17);
            this.label8.TabIndex = 26;
            this.label8.Text = "Açıklamalar";
            // 
            // cmbAciklama
            // 
            this.cmbAciklama.FormattingEnabled = true;
            this.cmbAciklama.Location = new System.Drawing.Point(196, 336);
            this.cmbAciklama.Name = "cmbAciklama";
            this.cmbAciklama.Size = new System.Drawing.Size(121, 25);
            this.cmbAciklama.TabIndex = 27;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(359, 323);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 36);
            this.button1.TabIndex = 30;
            this.button1.Text = "Textleri Temizle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(194, 82);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(123, 25);
            this.textBox1.TabIndex = 28;
            // 
            // btnYeni
            // 
            this.btnYeni.Location = new System.Drawing.Point(359, 54);
            this.btnYeni.Name = "btnYeni";
            this.btnYeni.Size = new System.Drawing.Size(146, 39);
            this.btnYeni.TabIndex = 31;
            this.btnYeni.Text = "Yeni";
            this.btnYeni.UseVisualStyleBackColor = true;
            this.btnYeni.Click += new System.EventHandler(this.btnYeni_Click);
            // 
            // lblİd
            // 
            this.lblİd.AutoSize = true;
            this.lblİd.Location = new System.Drawing.Point(149, 88);
            this.lblİd.Name = "lblİd";
            this.lblİd.Size = new System.Drawing.Size(22, 17);
            this.lblİd.TabIndex = 32;
            this.lblİd.Text = "İD";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(917, 406);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(146, 36);
            this.button2.TabIndex = 33;
            this.button2.Text = "Programı Kapat";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FrmOduncKitaplar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Crimson;
            this.ClientSize = new System.Drawing.Size(1102, 654);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lblİd);
            this.Controls.Add(this.btnYeni);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.cmbAciklama);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TxtKitabinAdi);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnListeYenile);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txtKitapNo);
            this.Controls.Add(this.TxtSinif);
            this.Controls.Add(this.txtAliciAdSoyad);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnMainMenu);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmOduncKitaplar";
            this.ShowIcon = false;
            this.Text = "Ödünç Kitaplar";
            this.Load += new System.EventHandler(this.FrmOduncKitaplar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMainMenu;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtAraAdSoyad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAraKitapNo;
        private System.Windows.Forms.TextBox TxtAraKitapAdi;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtAliciAdSoyad;
        private System.Windows.Forms.TextBox TxtSinif;
        private System.Windows.Forms.TextBox txtKitapNo;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnListeYenile;
        private System.Windows.Forms.TextBox TxtKitabinAdi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbAciklama;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnYeni;
        private System.Windows.Forms.Label lblİd;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtaraSinif;
        private System.Windows.Forms.Label label11;
    }
}