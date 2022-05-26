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

       static string xmlPath = Application.StartupPath + "rojhat.xml";
        XmlTextWriter customer = new XmlTextWriter(XMLformati.xmlPath, UTF8Encoding.UTF8);
        public void baslangic()
        {
            
            customer.Formatting = System.Xml.Formatting.Indented;

            customer.WriteStartDocument();
        }
        public override void GenelBilgiler()
        {
            customer.WriteStartElement("GenelBilgiler");
           

            customer.WriteAttributeString("Ad", Classlar.KullaniciBilgileri.Ad);

            customer.WriteAttributeString("Soyad", Classlar.KullaniciBilgileri.Soyad);

            customer.WriteAttributeString("TC", Classlar.KullaniciBilgileri.TC);

            customer.WriteElementString("GidilecekYer", Classlar.RezarvasyonBilgileri.lokasyon);

            customer.WriteElementString("GidisTarihi", Classlar.RezarvasyonBilgileri.gidistarihi);

            customer.WriteElementString("DonusTarihi", Classlar.RezarvasyonBilgileri.donustarihi);

            customer.WriteEndElement();
         


        }
        public override void DetayliBilgiler()
        {

               customer.WriteStartElement("DetayliBilgiler");


            customer.WriteAttributeString("UlasimAraci", Classlar.RezarvasyonBilgileri.ulasim);

            customer.WriteAttributeString("KonaklamaYeri", Classlar.RezarvasyonBilgileri.konaklama);

          

            customer.WriteEndElement();
          

        }

        public override void fiyat()
        {
           

        

            customer.WriteStartElement("RezarvasyonFiyati");


            customer.WriteAttributeString("Hesap", Classlar.RezarvasyonBilgileri.fiyat);

        



            customer.WriteEndElement();
            
        }
        public void bitis()
        {
            customer.Close();
        }

        public override Rapor RaporOlustur()
        {
            return rapor;
        }
    }
}