using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SeyahatAcentesi
{
    public partial class Anasayfa : Form
    {
        public Anasayfa()
        {
            InitializeComponent();
        }

        private void buttonCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonUyeOl_Click(object sender, EventArgs e)
        {
            UyeOl uye = new UyeOl();
            uye.Show();
            this.Hide();
        }

        private void buttonOgrenciGiris_Click(object sender, EventArgs e)
        {
            KullaniciGiris giris = new KullaniciGiris();
            giris.Show();
            this.Hide();
        }
    }
}
