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
    public class HTMLformati : RaporFormatlari
    {
        Rapor rapor = new Rapor();
        public override void GenelBilgiler()
        {
            //rapor.gidisTarihi = Classlar.RezarvasyonBilgileri.gidistarihi;
            //rapor.donusTarihi = Classlar.RezarvasyonBilgileri.donustarihi;
            //rapor.lokasyon = Classlar.RezarvasyonBilgileri.lokasyon;
            //rapor.ad = Classlar.KullaniciBilgileri.Ad;
            //rapor.soyad = Classlar.KullaniciBilgileri.Soyad;
            //rapor.tc = Classlar.KullaniciBilgileri.TC;

            string KullaniciBilgi = "okerd";
                    using (StreamWriter writer2 = new StreamWriter(KullaniciBilgi + ".html", append: true))
                   {
                writer2.WriteLine("<br><br> <b>GENEL BİLGİLER</b> <br> <br>");
                writer2.WriteLine("Adınız: " + "  " + Classlar.KullaniciBilgileri.Ad + "<br>");
                writer2.WriteLine("Soyadınız: " + "  " + Classlar.KullaniciBilgileri.Soyad + "<br>");
                writer2.WriteLine("TC'niz: " + "  " + Classlar.KullaniciBilgileri.TC + "<br>");
                writer2.WriteLine("Gideceğiniz Yer: " + "  " + Classlar.RezarvasyonBilgileri.lokasyon + "<br>");
                writer2.WriteLine("Gidiş Tarih: " + "  " + Classlar.RezarvasyonBilgileri.gidistarihi + "<br>");
                writer2.WriteLine("Dönüş Tarihinz: " + "  " + Classlar.RezarvasyonBilgileri.donustarihi + "<br><br><br>");
            }


        }
        public override void DetayliBilgiler()
        {
            //rapor.ulasim = Classlar.RezarvasyonBilgileri.ulasim;
            //rapor.konaklama = Classlar.RezarvasyonBilgileri.konaklama;

            string KullaniciBilgi = "okerd";
            using (StreamWriter writer2 = new StreamWriter(KullaniciBilgi + ".html", append: true))
            {
                writer2.WriteLine("<b>Detaylı Bilgiler</b>  <br> <br>");
                writer2.WriteLine("Ulaşım için kullanacağınız araç: " + "  " + Classlar.RezarvasyonBilgileri.ulasim + "<br>");
                writer2.WriteLine("Konaklamak için kalacağınız yer: " + "  " + Classlar.RezarvasyonBilgileri.konaklama + "<br><br><br>");

              }

        }

        public override void fiyat()
        {
            //rapor.fiyat = Convert.ToInt32(Classlar.RezarvasyonBilgileri.fiyat);

            string KullaniciBilgi = "okerd";
            using (StreamWriter writer2 = new StreamWriter(KullaniciBilgi + ".html", append: true))
            {
                writer2.WriteLine("<b>Rezarvasyon Fiyatı</b> <br> <br>");
                writer2.WriteLine("Ödeyeceğiniz toplam fiyat: " + "  " + Classlar.RezarvasyonBilgileri.fiyat + " ₺ " + "<br>");
               

            }

        }

        public override Rapor RaporOlustur()
        {
            return rapor;
        }

    }
    //public class HTMLformati
    //{
    //    public void html()
    //    {
    //        string KullaniciBilgi = "Kullanııo";
    //        using (StreamWriter writer2 = new StreamWriter(KullaniciBilgi + ".html", append: true))
    //        {
    //            writer2.WriteLine("donus:" + "  " + Classlar.RezarvasyonBilgileri.donustarihi + "\t");
               
    //        }
    //    }
    
}
