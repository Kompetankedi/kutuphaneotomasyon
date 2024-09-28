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
    public partial class Ogrenci : Form
    {
        public Ogrenci()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=.\\SQLExpress;Initial Catalog=DbKutuphane;Integrated Security=True;Encrypt=False");
        private void list()
        {
            if (con.State == ConnectionState.Closed)
            { con.Open(); }
            SqlDataAdapter da = new SqlDataAdapter("select * from OduncKitaplar", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void Ogrenci_Load(object sender, EventArgs e)
        {
            CenterToScreen();list();
        }

        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            Frm_Giris f= new Frm_Giris();
            f.Show();
        }
    }
}
