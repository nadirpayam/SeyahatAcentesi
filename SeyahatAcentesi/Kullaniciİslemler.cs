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
    public partial class Kullaniciİslemler : Form
    {
        public Kullaniciİslemler()
        {
            InitializeComponent();
        }

        private void buttonRezarvasyon_Click(object sender, EventArgs e)
        {
            RezarvasyonIslemleri rezarvasyon = new RezarvasyonIslemleri();
            rezarvasyon.Show();
            this.Hide();
        }
    }
}
