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
    public partial class RaporAlmak : Form
    {
        public RaporAlmak()
        {
            InitializeComponent();
        }

        private void buttonXML_Click(object sender, EventArgs e)
        {
            Classlar.XMLformati xml = new Classlar.XMLformati();
           
            if (textBoxBas.Text == "Genel Bilgiler" && textBoxOrta.Text == "Detaylı Bilgiler" && textBoxSon.Text == "Rezarvasyon Fiyati")
            {
                xml.GenelBilgiler();
                xml.DetayliBilgiler();
                xml.fiyat();
            }

            else if (textBoxBas.Text == "Detaylı Bilgiler" && textBoxOrta.Text == "Genel Bilgiler" && textBoxSon.Text == "Rezarvasyon Fiyati")
            {
                xml.DetayliBilgiler();
                xml.GenelBilgiler();
                xml.fiyat();
            }
            else if (textBoxBas.Text == "Rezarvasyon Fiyati" && textBoxOrta.Text == "Genel Bilgiler" && textBoxSon.Text == "Detaylı Bilgiler")
            {
                xml.fiyat();
                xml.GenelBilgiler();
                xml.DetayliBilgiler();
            }
            else
            {
                xml.DetayliBilgiler();
                xml.fiyat();
                xml.GenelBilgiler();
            }
            
         
            string KullaniciPath = @"C:\Users\NADİR PAYAM\Desktop\SeyahatAcentesi\SeyahatAcentesi\bin\Debugrojhat.xml";
            System.Diagnostics.Process prc = new System.Diagnostics.Process();
            prc.StartInfo.FileName = KullaniciPath;
            prc.Start();
        }

        private void buttonBas_Click(object sender, EventArgs e)
        {
            if (radioButtonDetayli.Checked == true)
            {
                textBoxBas.Text = radioButtonDetayli.Text;
                radioButtonDetayli.Checked = false;
            }
            else if (radioButtonGenel.Checked == true)
            {
                textBoxBas.Text = radioButtonGenel.Text;
                radioButtonGenel.Checked = false;
            }
            else if (radioButtonfiyat.Checked == true)
            {
                textBoxBas.Text = radioButtonfiyat.Text;
                radioButtonfiyat.Checked = false;
            }
        }

        private void buttonOrta_Click(object sender, EventArgs e)
        {

            if (radioButtonDetayli.Checked == true)
            {
                textBoxOrta.Text = radioButtonDetayli.Text;
                radioButtonDetayli.Checked = false;
            }
            else if (radioButtonGenel.Checked == true)
            {
                textBoxOrta.Text = radioButtonGenel.Text;
                radioButtonGenel.Checked = false;
            }
            else if (radioButtonfiyat.Checked == true)
            {
                textBoxOrta.Text = radioButtonfiyat.Text;
                radioButtonfiyat.Checked = false;
            }
        }

        private void buttonSon_Click(object sender, EventArgs e)
        {
            if (radioButtonDetayli.Checked == true)
            {
                textBoxSon.Text = radioButtonDetayli.Text;
                radioButtonDetayli.Checked = false;
            }
            else if (radioButtonGenel.Checked == true)
            {
                textBoxSon.Text = radioButtonGenel.Text;
                radioButtonGenel.Checked = false;
            }
            else if (radioButtonfiyat.Checked == true)
            {
                textBoxSon.Text = radioButtonfiyat.Text;
                radioButtonfiyat.Checked = false;
            }
        }

        private void buttonJSON_Click(object sender, EventArgs e)
        {
            Classlar.JSONformati json = new Classlar.JSONformati();
         
            if (textBoxBas.Text == "Genel Bilgiler" && textBoxOrta.Text == "Detaylı Bilgiler" && textBoxSon.Text == "Rezarvasyon Fiyati")
            {
                json.GenelBilgiler();
                json.DetayliBilgiler();
                json.fiyat();
            }

            else if (textBoxBas.Text == "Detaylı Bilgiler" && textBoxOrta.Text == "Genel Bilgiler" && textBoxSon.Text == "Rezarvasyon Fiyati")
            {
                json.DetayliBilgiler();
                json.GenelBilgiler();
                json.fiyat();
            }
            else if (textBoxBas.Text == "Rezarvasyon Fiyati" && textBoxOrta.Text == "Genel Bilgiler" && textBoxSon.Text == "Detaylı Bilgiler")
            {
                json.fiyat();
                json.GenelBilgiler();
                json.DetayliBilgiler();
            }
            else
            {
                json.DetayliBilgiler();
                json.fiyat();
                json.GenelBilgiler();
            }

           
            string SeyahatPath = @"C:\Users\NADİR PAYAM\Desktop\SeyahatAcentesi\SeyahatAcentesi\bin\Debug\J3.json";
            System.Diagnostics.Process prc = new System.Diagnostics.Process();
            prc.StartInfo.FileName = SeyahatPath;
            prc.Start();
        }

        private void buttonHTML_Click(object sender, EventArgs e)
        {
            Classlar.HTMLformati html = new Classlar.HTMLformati();
            if (textBoxBas.Text == "Genel Bilgiler" && textBoxOrta.Text == "Detaylı Bilgiler" && textBoxSon.Text == "Rezarvasyon Fiyati")
            {
                html.GenelBilgiler();
                html.DetayliBilgiler();
                html.fiyat();
            }

            else if (textBoxBas.Text == "Detaylı Bilgiler" && textBoxOrta.Text == "Genel Bilgiler" && textBoxSon.Text == "Rezarvasyon Fiyati")
            {
                html.DetayliBilgiler();
                html.GenelBilgiler();
                html.fiyat();
            }
            else if (textBoxBas.Text == "Rezarvasyon Fiyati" && textBoxOrta.Text == "Genel Bilgiler" && textBoxSon.Text == "Detaylı Bilgiler")
            {
                html.fiyat();
                html.GenelBilgiler();
                html.DetayliBilgiler();
            }
            else
            {
                html.DetayliBilgiler();
                html.fiyat();
                html.GenelBilgiler();
            }


            string KullaniciPath = @"file:///C:\Users\NADİR PAYAM\Desktop\SeyahatAcentesi\SeyahatAcentesi\bin\Debug\okerd.html";
            System.Diagnostics.Process prc = new System.Diagnostics.Process();
            prc.StartInfo.FileName = KullaniciPath;
            prc.Start();
        }

        private void buttonCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
