using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kutuphaneotomasyon
{
    public partial class FrmTrKitaplar : Form
    {
        public FrmTrKitaplar()
        {
            InitializeComponent();
        }

        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            Frm_Giris frm_Giris = new Frm_Giris();
            frm_Giris.Show();
        }
    }
}
