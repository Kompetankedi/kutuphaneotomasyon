namespace kutuphaneotomasyon
{
    partial class Frm_Giris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Giris));
            this.btnTrKitap = new System.Windows.Forms.Button();
            this.btnYabancıKitaplar = new System.Windows.Forms.Button();
            this.btnOdunc = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTrKitap
            // 
            this.btnTrKitap.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnTrKitap.Location = new System.Drawing.Point(11, 44);
            this.btnTrKitap.Name = "btnTrKitap";
            this.btnTrKitap.Size = new System.Drawing.Size(123, 56);
            this.btnTrKitap.TabIndex = 0;
            this.btnTrKitap.Text = "Türkçe Kitaplar";
            this.btnTrKitap.UseVisualStyleBackColor = true;
            this.btnTrKitap.Click += new System.EventHandler(this.btnTrKitap_Click);
            // 
            // btnYabancıKitaplar
            // 
            this.btnYabancıKitaplar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnYabancıKitaplar.Location = new System.Drawing.Point(269, 44);
            this.btnYabancıKitaplar.Name = "btnYabancıKitaplar";
            this.btnYabancıKitaplar.Size = new System.Drawing.Size(123, 56);
            this.btnYabancıKitaplar.TabIndex = 1;
            this.btnYabancıKitaplar.Text = "Yabancı Kitaplar";
            this.btnYabancıKitaplar.UseVisualStyleBackColor = true;
            this.btnYabancıKitaplar.Click += new System.EventHandler(this.btnYabancıKitaplar_Click);
            // 
            // btnOdunc
            // 
            this.btnOdunc.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnOdunc.Location = new System.Drawing.Point(520, 44);
            this.btnOdunc.Name = "btnOdunc";
            this.btnOdunc.Size = new System.Drawing.Size(132, 56);
            this.btnOdunc.TabIndex = 2;
            this.btnOdunc.Text = "Ödünç Kitaplar";
            this.btnOdunc.UseVisualStyleBackColor = true;
            this.btnOdunc.Click += new System.EventHandler(this.btnOdunc_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, 142);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(208, 151);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Frm_Giris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(662, 291);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnOdunc);
            this.Controls.Add(this.btnYabancıKitaplar);
            this.Controls.Add(this.btnTrKitap);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Frm_Giris";
            this.ShowIcon = false;
            this.Text = "Giriş";
            this.Load += new System.EventHandler(this.Frm_Giris_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTrKitap;
        private System.Windows.Forms.Button btnYabancıKitaplar;
        private System.Windows.Forms.Button btnOdunc;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

