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



        string sehir;
        string ulasiyor;
        string konakliyor;
        int rezTip;
        int totalfiyat;
        int fiyatulasim, fiyatkonak;



        private void buttonHesap_Click(object sender, EventArgs e)
        {



        }
        int gunfarki;
        void RezarvasyonKaydediliyor()
        {



            if (comboBoxUlasim.SelectedIndex == 0)
            {
                ulasiyor = Classlar.Ucak.ulasimTipi();
                fiyatulasim = Classlar.Ucak.fiyati();



            }
            else if (comboBoxUlasim.SelectedIndex == 1)
            {
                ulasiyor = Classlar.Otobüs.ulasimTipi();
                fiyatulasim = Classlar.Otobüs.fiyati();
            }



            if (comboBoxKonaklama.SelectedIndex == 0)
            {
                konakliyor = Classlar.Otel.konaklamaTipi();
                fiyatkonak = Classlar.Otel.fiyat();





            }



            else if (comboBoxKonaklama.SelectedIndex == 1)
            {
                konakliyor = Classlar.Cadir.konaklamaTipi();
                fiyatkonak = Classlar.Cadir.fiyati();



            }





            if (ulasiyor == "Otobüs" && konakliyor == "Otel")
            {
                rezTip = 1;



            }
            else if (ulasiyor == "Uçak" && konakliyor == "Otel")
            {
                rezTip = 2;



            }
            else if (ulasiyor == "Otobüs" && konakliyor == "Çadır")
            {
                rezTip = 3;



            }
            else if (ulasiyor == "Uçak" && konakliyor == "Çadır")
            {
                rezTip = 4;



            }



            sehir = comboBoxLokasyon.Text;



            TimeSpan tarihfarki = Convert.ToDateTime(dateTimePickerDonus.Value) - Convert.ToDateTime(dateTimePickerGidis.Value);
            gunfarki = Convert.ToInt32(tarihfarki.TotalDays);
            totalfiyat = (fiyatkonak * gunfarki) + fiyatulasim;

        }



       

        private void buttonHesabim_Click_1(object sender, EventArgs e)
        {
            RezarvasyonKaydediliyor();
            labelHesap.Visible = true;
            textBoxHesap.Visible = true;



            textBoxHesap.Text = totalfiyat.ToString();
        }

        private void buttonGonder_Click(object sender, EventArgs e)
        {
            RezarvasyonKaydediliyor();
            string sorgu = "insert into Rezarvasyonlar(ulasim,konaklama,KullaniciID, rezarvasyonTip,gidisTarihi,donusTarihi,lokasyon,fiyat,kacgunkalacak)values(@ulasim,@konaklama,@kulid,@reztip,@gidis,@donus,@lokasyon,@fiyat,@kacgun)"; // öğrencinin soruya verdiği cevabı veritabanına kaydediyoruz
            SqlCommand komut = new SqlCommand(sorgu, sql.baglan());




            komut.Parameters.AddWithValue("@ulasim", ulasiyor); // okey
            komut.Parameters.AddWithValue("@konaklama", konakliyor); // okey
            komut.Parameters.AddWithValue("@kulid", Classlar.KullaniciBilgileri.KullaniciID); // okey
            komut.Parameters.AddWithValue("@reztip", rezTip); //okey
            komut.Parameters.AddWithValue("@gidis", dateTimePickerGidis.Value); // okey
            komut.Parameters.AddWithValue("@donus", dateTimePickerDonus.Value); // okey
            komut.Parameters.AddWithValue("@lokasyon", sehir);
            komut.Parameters.AddWithValue("@fiyat", totalfiyat);
            komut.Parameters.AddWithValue("@kacgun", gunfarki);




            komut.ExecuteNonQuery();

            MessageBox.Show("Rezarvasyonunuz başarı bir şekilde kaydedildi");
        }

    }
}