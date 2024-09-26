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
    public partial class FrmYabancıKitaplar : Form
    {
        public FrmYabancıKitaplar()
        {
            InitializeComponent();
        }

        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            Frm_Giris f= new Frm_Giris();
            f.Show();
        }
    }
}
