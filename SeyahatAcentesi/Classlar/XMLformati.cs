using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
using Newtonsoft.Json;
using System;
using System.Xml;


namespace SeyahatAcentesi.Classlar
{
    public class XMLformati : RaporFormatlari
    {
        Rapor rapor = new Rapor();

       
        public override void GenelBilgiler()
        {
            XmlTextWriter genel = new XmlTextWriter("7.xml", Encoding.UTF8);
            //veri.Formatting = Formatting.Indented;

            genel.WriteStartElement("GenelBilgiler");
            genel.WriteElementString("Ad", Classlar.KullaniciBilgileri.Ad);
            genel.WriteElementString("Soyad", Classlar.KullaniciBilgileri.Soyad);
            genel.WriteElementString("TC" ,Classlar.KullaniciBilgileri.TC);
            genel.WriteElementString("Gidilecekyer", Classlar.RezarvasyonBilgileri.lokasyon);
            genel.WriteElementString("TC", Classlar.KullaniciBilgileri.TC);
            genel.WriteElementString("GidisTarihi",  Classlar.RezarvasyonBilgileri.gidistarihi);
            genel.WriteElementString("DonusTarihi", Classlar.RezarvasyonBilgileri.donustarihi);
           
            genel.WriteEndElement();
            genel.Close();

            string Genel = @"C:\Users\NADİR PAYAM\Desktop\SeyahatAcentesi\SeyahatAcentesi\bin\Debug\7.xml";
            System.Diagnostics.Process prc3 = new System.Diagnostics.Process();
            prc3.StartInfo.FileName = Genel;
            prc3.Start();
        }
        public override void DetayliBilgiler()
        {
            XmlTextWriter detayli = new XmlTextWriter("8.xml", Encoding.UTF8);
           detayli.WriteStartElement("DetayliBilgiler");
            detayli.WriteElementString("UlasimAraci ", Classlar.RezarvasyonBilgileri.ulasim);
            detayli.WriteElementString("KonaklYeri" , Classlar.RezarvasyonBilgileri.konaklama);
            detayli.WriteEndElement();
            detayli.Close();

            string Detay = @"C:\Users\NADİR PAYAM\Desktop\SeyahatAcentesi\SeyahatAcentesi\bin\Debug\8.xml";
            System.Diagnostics.Process prc = new System.Diagnostics.Process();
            prc.StartInfo.FileName = Detay;
            prc.Start();
        }

        public override void fiyat()
        {
            XmlTextWriter fiyat = new XmlTextWriter("9.xml", Encoding.UTF8);
          

            fiyat.WriteStartElement("RezarvasyonFiyati");
            fiyat.WriteElementString("ToplamHesap", Classlar.RezarvasyonBilgileri.fiyat);
            fiyat.WriteEndElement();
            fiyat.Close();

            string Fiyat = @"C:\Users\NADİR PAYAM\Desktop\SeyahatAcentesi\SeyahatAcentesi\bin\Debug\9.xml";
            System.Diagnostics.Process prc2 = new System.Diagnostics.Process();
            prc2.StartInfo.FileName = Fiyat;
            prc2.Start();

        }
        

        public override Rapor RaporOlustur()
        {
            return rapor;
        }
    }
}