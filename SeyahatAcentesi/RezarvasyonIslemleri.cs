using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace SeyahatAcentesi
{
    public partial class RezarvasyonIslemleri : Form
    {
        public RezarvasyonIslemleri()
        {
            InitializeComponent();
        }

        private void buttonCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        Classlar.SqlBaglantisi sql = new Classlar.SqlBaglantisi();
        string ulasiyor;
        string konakliyor;
        int rezTip;
        int stabil;
        int katsayi;
        int fiyat;
        private void buttonGonder_Click(object sender, EventArgs e)
        {
            string sorgu = "insert into Rezarvasyon(ulasim,konaklama,KullaniciID, rezarvasyonTip,gidisTarihi,donusTarihi,lokasyon,fiyat)values(@ulasim,@konaklama,@kulid,@reztip,@gidis,@donus,@lokasyon,@fiyat)"; // öğrencinin soruya verdiği cevabı veritabanına kaydediyoruz
            SqlCommand komut = new SqlCommand(sorgu, sql.baglan());

        
           

          if(comboBoxUlasim.SelectedIndex == 0)
            {
                ulasiyor = "Uçak";
       
            }
          else if (comboBoxUlasim.SelectedIndex == 1)
            {
                ulasiyor = "Otobüs";

            }

           if (comboBoxKonaklama.SelectedIndex == 0)
            {
                konakliyor = "Otel";
           
            }

            else if(comboBoxKonaklama.SelectedIndex == 1)
            {
                konakliyor = "Çadır";
               
            }



            if (ulasiyor == "Otobüs" && konakliyor == "Otel")
            {
                rezTip = 1;
                stabil = 200;
            }
            else if (ulasiyor == "Uçak" && konakliyor == "Otel")
            {
                rezTip = 2;
                stabil = 500;
            }
            else if (ulasiyor == "Otobüs" && konakliyor == "Çadır")
            {
                rezTip = 3;
                stabil = 150;
            }
            else if (ulasiyor == "Uçak" && konakliyor == "Çadır")
            {
                rezTip = 4;
                stabil = 450;
            }

          

            katsayi = Convert.ToInt32(comboBoxLokasyon.Text.Substring(16,19));

            string a = comboBoxLokasyon.Text.Substring(0, 14);

            

            TimeSpan fark = Convert.ToDateTime(dateTimePickerGidis.Text) - Convert.ToDateTime(dateTimePickerDonus.Value);
            int fark1 = Convert.ToInt32(fark.TotalDays);
            fiyat = stabil * katsayi * fark1 ;

            komut.Parameters.AddWithValue("@ulasim", ulasiyor); // öğrencinin verdiği cevap kaydedildi
            komut.Parameters.AddWithValue("@konaklama",konakliyor);
            komut.Parameters.AddWithValue("@kulid", Classlar.KullaniciBilgileri.KullaniciID);
            komut.Parameters.AddWithValue("@reztip",rezTip);
            komut.Parameters.AddWithValue("@gidis", dateTimePickerGidis.Value);
            komut.Parameters.AddWithValue("@donus", dateTimePickerDonus.Value);
            komut.Parameters.AddWithValue("@lokasyon", a);
            komut.Parameters.AddWithValue("@fiyat", fiyat);

            komut.ExecuteNonQuery();
            MessageBox.Show("Rezarvasyonunuz başarı bir şekilde kaydedildi");
        }
    }
}
