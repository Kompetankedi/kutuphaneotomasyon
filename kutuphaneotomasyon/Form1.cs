﻿using System;
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
    public partial class Frm_Giris : Form
    {
        public Frm_Giris()
        {
            InitializeComponent();
        }

        private void Frm_Giris_Load(object sender, EventArgs e)
        {
            CenterToScreen();
        }

        private void btnTrKitap_Click(object sender, EventArgs e)
        {
            FrmTrKitaplar frmTrKitaplar = new FrmTrKitaplar();
            frmTrKitaplar.Show();
        }

        private void btnYabancıKitaplar_Click(object sender, EventArgs e)
        {

            FrmYabancıKitaplar frmYabancıKitaplar = new FrmYabancıKitaplar();
            frmYabancıKitaplar.Show();
        }

        private void btnOdunc_Click(object sender, EventArgs e)
        {
            FrmOduncKitaplar f= new FrmOduncKitaplar();
            f.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ogrenci o= new Ogrenci();
            o.Show();
        }
    }
}
