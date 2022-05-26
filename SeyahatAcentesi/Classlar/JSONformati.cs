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
    public class JSONformati : RaporFormatlari
    {
        Rapor genel = new Rapor();
        public override void GenelBilgiler()
        {
        

            genel.ad = Classlar.KullaniciBilgileri.Ad;
            genel.soyad = Classlar.KullaniciBilgileri.Soyad;
            genel.tc = Classlar.KullaniciBilgileri.Soyad;
            genel.lokasyon = Classlar.RezarvasyonBilgileri.lokasyon;
            genel.gidisTarihi = Classlar.RezarvasyonBilgileri.gidistarihi;
            genel.donusTarihi = Classlar.RezarvasyonBilgileri.donustarihi;

            string JSONresult = JsonConvert.SerializeObject(genel);
            string path = @"C:\Users\NADİR PAYAM\Desktop\SeyahatAcentesi\SeyahatAcentesi\bin\Debug\55.json";
            if (File.Exists(path))
            {
                using (var tw = new StreamWriter(path, true))
                { tw.WriteLine(JSONresult.ToString()); tw.Close(); }
            }
            else if (!File.Exists(path))
            {
                using (var tw = new StreamWriter(path, true))
                { tw.WriteLine(JSONresult.ToString()); tw.Close(); }
            }



        }
        Rapor detayli = new Rapor();
        public override void DetayliBilgiler()
        {
   

            detayli.ulasim = Classlar.RezarvasyonBilgileri.ulasim;
            detayli.konaklama = Classlar.RezarvasyonBilgileri.konaklama;
            string JSONresult2 = JsonConvert.SerializeObject(detayli);
            string path = @"C:\Users\NADİR PAYAM\Desktop\SeyahatAcentesi\SeyahatAcentesi\bin\Debug\55.json";
            if (File.Exists(path))
            {
                using (var tw = new StreamWriter(path, true))
                { tw.WriteLine(JSONresult2.ToString()); tw.Close(); }
            }
            else if (!File.Exists(path))
            {
                using (var tw = new StreamWriter(path, true))
                { tw.WriteLine(JSONresult2.ToString()); tw.Close(); }
            }


        }
        Rapor fiyat2 = new Rapor();
        public override void fiyat()
        {
         
            fiyat2.fiyat = Convert.ToDouble(Classlar.RezarvasyonBilgileri.fiyat);
            string JSONresult3 = JsonConvert.SerializeObject(fiyat2);
            string path = @"C:\Users\NADİR PAYAM\Desktop\SeyahatAcentesi\SeyahatAcentesi\bin\Debug\55.json";
            if (File.Exists(path))
            {
                using (var tw = new StreamWriter(path, true))
                { tw.WriteLine(JSONresult3.ToString()); tw.Close(); }
            }
            else if (!File.Exists(path))
            {
                using (var tw = new StreamWriter(path, true))
                { tw.WriteLine(JSONresult3.ToString()); tw.Close(); }
            }


        }

        Rapor rapor = new Rapor();
        public override Rapor RaporOlustur()
        {
            return rapor;
        }
    }
}