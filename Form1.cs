using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lblcinsiyet_Click(object sender, EventArgs e)
        {

        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            DateTime dogumTarihi = dateDogumTarihi.Value;          

            Hasta hasta = new Hasta
            {
                adi = txtAdi.Text,
                ucret = Convert.ToInt32(txtucret.Text),
                dogumYili = dogumTarihi.Year,
                cinsiyet = cmbcinsiyet.Text
            };
            hasta.YasHesapla();
            hasta.IndirimliUcretHesapla();
            dataGridView1.Rows.Add(hasta.adi, hasta.dogumYili, hasta.cinsiyet, hasta.ucret, hasta.indirimliUcret, hasta.yas);
        }

        private void cmbcinsiyet_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
