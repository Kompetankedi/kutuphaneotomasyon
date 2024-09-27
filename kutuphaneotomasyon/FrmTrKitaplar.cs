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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace kutuphaneotomasyon
{
    public partial class FrmTrKitaplar : Form
    {
        public FrmTrKitaplar()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=.\\SQLExpress;Initial Catalog=DbKutuphane;Integrated Security=True;Encrypt=False");
        private void list() {
            if (con.State == ConnectionState.Closed)
            { con.Open(); }
            SqlDataAdapter da = new SqlDataAdapter("select * from tbl_TrKitaplar", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }
        
        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            Frm_Giris frm_Giris = new Frm_Giris();
            frm_Giris.Show();
        }
        private void bul(string sorgu)
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                { con.Open(); }
                SqlDataAdapter da = new SqlDataAdapter(sorgu,con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();    


            }
            catch (Exception hata){ MessageBox.Show(hata.Message); }
        }
        private void FrmTrKitaplar_Load(object sender, EventArgs e)
        {
            list();
            CenterToScreen();

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into tbl_TrKitaplar (KitapNo,KitapRaf,KitapAdi,KitapYazar) values (@p1,@p2,@p3,@p4)", con);
            cmd.Parameters.AddWithValue("@p1", txtKitapNo.Text);
            cmd.Parameters.AddWithValue("@p2", txtRafNo.Text);
            cmd.Parameters.AddWithValue("@p3", txtKitapAdi.Text);
            cmd.Parameters.AddWithValue("@p4", txtKitapYazar.Text);
            cmd.ExecuteNonQuery();
            con.Close();



            list();
        }

        private void btnYenile_Click(object sender, EventArgs e)
        {
            list();
        }
        int secilenid = 0;
        private void btnSil_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                secilenid = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                con.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM tbl_TrKitaplar WHERE id=" + secilenid + "", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Kayıt Silindi");
                con.Close();
                list();
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand komutguncelle = new SqlCommand("Update tbl_TrKitaplar set KitapNo=@a1,KitapRaf=@a2,KitapAdi=@a3,KitapYazar=@a4 where id=@a5", con);
            komutguncelle.Parameters.AddWithValue("@a1", txtKitapNo.Text);
            komutguncelle.Parameters.AddWithValue("@a2", txtRafNo.Text);
            komutguncelle.Parameters.AddWithValue("@a3", txtKitapAdi.Text);
            komutguncelle.Parameters.AddWithValue("@a4", txtKitapYazar.Text);
            komutguncelle.Parameters.AddWithValue("@a5", textBox1.Text);
            komutguncelle.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Kayıt Güncellendi.");
            list();
        }

        

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtKitapNo.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtRafNo.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtKitapAdi.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtKitapYazar.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
        }

        private void atxtKitapNo_TextChanged(object sender, EventArgs e)
        {
            bul("select * from tbl_TrKitaplar where KitapNo like '%" +atxtKitapNo.Text+"%'");
        }

        private void atxtKitapRafNo_TextChanged(object sender, EventArgs e)
        {
            bul("select * from tbl_TrKitaplar where KitapRaf like '%" + atxtKitapRafNo.Text + "%'");
        }

        private void atxtKitapAdi_TextChanged(object sender, EventArgs e)
        {
            bul("select * from tbl_TrKitaplar where KitapAdi like '%" + atxtKitapAdi.Text + "%'");
        }

        private void atxtKitapYazar_TextChanged(object sender, EventArgs e)
        {
            bul("select * from tbl_TrKitaplar where KitapYazar like '%" + atxtKitapYazar.Text + "%'");
        }
    }
}
