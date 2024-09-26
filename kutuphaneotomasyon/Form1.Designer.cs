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
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTrKitap
            // 
            this.btnTrKitap.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnTrKitap.Location = new System.Drawing.Point(12, 44);
            this.btnTrKitap.Name = "btnTrKitap";
            this.btnTrKitap.Size = new System.Drawing.Size(123, 41);
            this.btnTrKitap.TabIndex = 0;
            this.btnTrKitap.Text = "Türkçe Kitaplar";
            this.btnTrKitap.UseVisualStyleBackColor = true;
            // 
            // btnYabancıKitaplar
            // 
            this.btnYabancıKitaplar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnYabancıKitaplar.Location = new System.Drawing.Point(270, 44);
            this.btnYabancıKitaplar.Name = "btnYabancıKitaplar";
            this.btnYabancıKitaplar.Size = new System.Drawing.Size(123, 41);
            this.btnYabancıKitaplar.TabIndex = 1;
            this.btnYabancıKitaplar.Text = "Yabancı Kitaplar";
            this.btnYabancıKitaplar.UseVisualStyleBackColor = true;
            // 
            // btnOdunc
            // 
            this.btnOdunc.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnOdunc.Location = new System.Drawing.Point(521, 44);
            this.btnOdunc.Name = "btnOdunc";
            this.btnOdunc.Size = new System.Drawing.Size(132, 41);
            this.btnOdunc.TabIndex = 2;
            this.btnOdunc.Text = "Ödünç Kitaplar";
            this.btnOdunc.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(340, 265);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(315, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Berk Bağ ve Arda Yalnız tarafından geliştirilmiştir.";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, 164);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(215, 129);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Frm_Giris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(665, 291);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOdunc);
            this.Controls.Add(this.btnYabancıKitaplar);
            this.Controls.Add(this.btnTrKitap);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Frm_Giris";
            this.ShowIcon = false;
            this.Text = "Giriş";
            this.Load += new System.EventHandler(this.Frm_Giris_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTrKitap;
        private System.Windows.Forms.Button btnYabancıKitaplar;
        private System.Windows.Forms.Button btnOdunc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

