using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kutuphaneotomasyon
{
    public partial class FrmOduncKitaplar : Form
    {
        public FrmOduncKitaplar()
        {
            InitializeComponent();
        }

        #region BağlantıCümlesi
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-GI4K7F4;Initial Catalog=dbKutuphane;Integrated Security=True;");
        #endregion
        #region VeriGoster
        private void VeriGoster()
        {
            try
            {
                if (baglanti.State == ConnectionState.Closed)
                    baglanti.Open();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select * from tblOduncİslemler", baglanti);
                DataTable dTable = new DataTable();
                sqlDataAdapter.Fill(dTable);
                dataGridView1.DataSource = dTable;
                baglanti.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion
        #region TextlereAktar
        private void TextlereAktar()
        {
            try
            {
                textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                txtAliciAdSoyad.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                TxtKitabinAdi.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                txtKitapNo.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                TxtSinif.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                cmbAciklama.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                dateTimePicker1.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                dateTimePicker2.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion
        #region sil
        private void Sil()
        {
            if (DialogResult.OK == MessageBox.Show("Seçili Kayıt Silinecektir!", "Kayıt Siliniyor", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning))
            {
                try
                {
                    if (baglanti.State == ConnectionState.Closed)
                        baglanti.Open();
                    string SorguSil = "delete from tblOduncİslemler where id=" + dataGridView1.CurrentRow.Cells[0].Value.ToString();
                    SqlCommand komut = new SqlCommand(SorguSil, baglanti);
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                    VeriGoster();
                    MessageBox.Show("Kayıt Başarıyla Silinmiştir");

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        #endregion
        #region TextleriTemizle
        private void TextleriTemizle()
        {
            try
            {
                foreach (Control item in this.Controls)
                    if (item is TextBox)
                        item.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion
        #region Kaydet
        private void Kaydet()
        {
            try
            {
                if (baglanti.State == ConnectionState.Closed)
                    baglanti.Open();
                string sorgu = "insert into tblOduncİslemler(AdSoyad,KitabinAdi,KitapNo,Sinif,Aciklamar,AlindigiTarih,İadeTarih) values (@adsoyad,@kitabinadi,@kitapno,@sinif,@aciklamalar,@alindigitarih,@iadetarih)";
                SqlCommand komut = new SqlCommand(sorgu, baglanti);
         //       komut.Parameters.AddWithValue("@id",textBox1.Text);
                komut.Parameters.AddWithValue("@adsoyad", txtAliciAdSoyad.Text);
                komut.Parameters.AddWithValue("@kitabinadi", TxtKitabinAdi.Text);
                komut.Parameters.AddWithValue("@kitapno", txtKitapNo.Text);
                komut.Parameters.AddWithValue("@sinif", TxtSinif.Text);
                komut.Parameters.AddWithValue("@aciklamalar", cmbAciklama.Text);
                komut.Parameters.AddWithValue("@alindigitarih", dateTimePicker1.Text);
                komut.Parameters.AddWithValue("@iadetarih", dateTimePicker2.Text);              
                komut.ExecuteNonQuery();
                baglanti.Close();
                VeriGoster();
                TextleriTemizle();  
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        #endregion
        #region Güncelle
        private void Guncelle()
        {
            try
            {
                if (baglanti.State == ConnectionState.Closed)
                    baglanti.Open();
                string sorgu = "update  tblOduncİslemler set AdSoyad=@adsoyad,KitabinAdi=@kitabinadi,KitapNo=@kitapno," +
                    "Sinif=@sinif,Aciklamar=@aciklamalar,AlindigiTarih=@alindigitarih,İadeTarih=@iadetarih where id=" + dataGridView1.CurrentRow.Cells[0].Value.ToString(); ;
                SqlCommand komut = new SqlCommand(sorgu, baglanti);
                komut.Parameters.AddWithValue("@adsoyad", txtAliciAdSoyad.Text);
                komut.Parameters.AddWithValue("@kitabinadi",TxtKitabinAdi.Text);
                komut.Parameters.AddWithValue("@kitapno",txtKitapNo.Text);
                komut.Parameters.AddWithValue("@sinif", TxtSinif.Text);
                komut.Parameters.AddWithValue("@aciklamalar", cmbAciklama.Text);
                komut.Parameters.AddWithValue("@alindigitarih", dateTimePicker1.Text);
                komut.Parameters.AddWithValue("@iadetarih", dateTimePicker2.Text);
                komut.ExecuteNonQuery();
                baglanti.Close();
                VeriGoster();
                TextleriTemizle();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion
        #region bul
        private void bul(string sorgu)
        {
            try
            {
                if (baglanti.State == ConnectionState.Closed)
                    baglanti.Open();
                SqlDataAdapter dAdapter = new SqlDataAdapter(sorgu, baglanti);
                DataTable dTable = new DataTable();
                dAdapter.Fill(dTable);
                dataGridView1.DataSource=dTable;
                baglanti.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion
        private void btnMainMenu_Click(object sender, EventArgs e)
            {
                Frm_Giris f = new Frm_Giris();
                f.Show();
            }

            private void FrmOduncKitaplar_Load(object sender, EventArgs e)
            {
                CenterToScreen();
                VeriGoster();
                cmbAciklama.Items.Add("Teslim Edildi");
                cmbAciklama.Items.Add("Teslim Alındı");
                textBox1.Enabled = false;
            
            }

            private void groupBox1_Enter(object sender, EventArgs e)
            {

            }

            private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
            {
                TextlereAktar();
            }

            private void button1_Click(object sender, EventArgs e)
            {
               TextleriTemizle();
            }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Kaydet();
            btnGuncelle.Enabled = false;
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Guncelle();
            btnEkle.Enabled = true;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            Sil();
        }

        private void btnListeYenile_Click(object sender, EventArgs e)
        {
            VeriGoster();
        }

        private void btnYeni_Click(object sender, EventArgs e)
        {
            txtAliciAdSoyad.Focus();
            btnGuncelle.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtAraAdSoyad_TextChanged(object sender, EventArgs e)
        {
            bul("select * from tblOduncİslemler where AdSoyad like '%" + txtAraAdSoyad.Text+"%'");
        }

        private void txtAraKitapNo_TextChanged(object sender, EventArgs e)
        {
            bul("select * from tblOduncİslemler where KitapNo like '%" + txtAraKitapNo.Text + "%'");
        }

        private void TxtAraKitapAdi_TextChanged(object sender, EventArgs e)
        {
            bul("select * from tblOduncİslemler where KitabinAdi like '%" + TxtAraKitapAdi.Text + "%'");
        }

        private void txtaraSinif_TextChanged(object sender, EventArgs e)
        {
            bul("select * from tblOduncİslemler where Sinif like '%" + txtaraSinif.Text + "%'");
        }
    }
    }
