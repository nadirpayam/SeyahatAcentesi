using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Net.Mail;

namespace SeyahatAcentesi
{
    public partial class UyeOl : Form
    {
        public UyeOl()
        {
            InitializeComponent();
        }

        private void buttonAnasayfa_Click(object sender, EventArgs e)
        {
            Anasayfa anasayfa = new Anasayfa();
            anasayfa.Show();
            this.Hide();

        }

        private void checkBoxGoster_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxGoster.CheckState == CheckState.Checked)
            {
                textBoxSifre.UseSystemPasswordChar = true;
                checkBoxGoster.Text = "Gizle";
            }
            else if (checkBoxGoster.CheckState == CheckState.Unchecked)
            {
                textBoxSifre.UseSystemPasswordChar = false;
                checkBoxGoster.Text = "Göster";

            }
        }

        private void buttonCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonGirisYap_Click(object sender, EventArgs e)
        {
            KullaniciGiris giris = new KullaniciGiris();
            giris.Show();
            this.Hide();
        }

        Classlar.SqlBaglantisi sql = new Classlar.SqlBaglantisi();
        private void buttonUyeOl_Click(object sender, EventArgs e)
        {

            // burada kullanıcının verilen bilgileri eksik girip girmediği kontrol ediliyor
            if (textBoxAd.Text == "" || textBoxSoyad.Text == "" || textBoxKulAd.Text == "" || textBoxMail.Text == "" || textBoxSifre.Text == "" || textBoxNo.Text=="")
            {
                MessageBox.Show("Lütfen tüm alanları doldurun");
            }
            else
            {
                // eğer tüm bilgileri girmişse bu bilgiler veritabanına kaydediliyor
                string sorgu = "insert into Kullanicilar(Ad,Soyad,KullaniciAd,Mail,Sifre,Telefon,TCKimlikNo)values(@ad,@soyad,@kulad,@mail,@sifre,@telefon,@tc)";
                SqlCommand komut = new SqlCommand(sorgu, sql.baglan());

                komut.Parameters.AddWithValue("@ad", textBoxAd.Text);
                komut.Parameters.AddWithValue("@soyad", textBoxSoyad.Text);
                komut.Parameters.AddWithValue("@kulad", textBoxKulAd.Text);
               komut.Parameters.AddWithValue("@mail", textBoxMail.Text);
                komut.Parameters.AddWithValue("@sifre", textBoxSifre.Text);
                komut.Parameters.AddWithValue("@telefon", textBoxNo.Text);
                komut.Parameters.AddWithValue("@tc", textBoxTC.Text);
                komut.ExecuteNonQuery();
                MessageBox.Show("Kaydınız başarıyla oluşturulmuştur.");
            }
        }
    }
}
