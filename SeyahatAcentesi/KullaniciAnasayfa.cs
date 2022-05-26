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
    public partial class KullaniciAnasayfa : Form
    {
        public KullaniciAnasayfa()
        {
            InitializeComponent();
        }

        private void buttonRezYap_Click(object sender, EventArgs e)
        {
            RezarvasyonIslemleri islem = new RezarvasyonIslemleri();
            islem.Show();
            this.Hide();
        }

        private void buttonRezlerim_Click(object sender, EventArgs e)
        {
            Rezarvasyonlarim rezarvasyonlarim = new Rezarvasyonlarim();
            rezarvasyonlarim.Show();
            this.Hide();
        }
    }
}
