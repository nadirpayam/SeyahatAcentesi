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
    public partial class KullaniciGiris : Form
    {
        public KullaniciGiris()
        {
            InitializeComponent();
        }

        Classlar.SqlBaglantisi sql = new Classlar.SqlBaglantisi();
        private void buttonGirisYap_Click(object sender, EventArgs e)
        {
            if (textBoxKulAd.Text == "" || textBoxSifre.Text == "")
            {
                MessageBox.Show("Kullanıcı adı veya şifre boş geçilmez.");
            }
            else
            {
                DataSet ds = new DataSet();
                string sql2 = "select * from Kullanicilar where KullaniciAd = '" + textBoxKulAd.Text + "'and Sifre = '" + textBoxSifre.Text + "'";
                SqlDataAdapter da = new SqlDataAdapter(sql2, sql.baglan());
                ds = new DataSet();
                da.Fill(ds, "KULLANICIDENEME");
                //con.Close();

                if (ds.Tables[0].Rows.Count > 0)
                {
                    // burada giren kullanıcının bilgilerini veritabnından çekiyoruz
                    string KullaniciIDtxt = ds.Tables[0].Rows[0]["KullaniciID"].ToString();
                    string Adtxt = ds.Tables[0].Rows[0]["Ad"].ToString();
                    string Soyadtxt = ds.Tables[0].Rows[0]["Soyad"].ToString();
                    string KullaniciAdtxt = ds.Tables[0].Rows[0]["KullaniciAd"].ToString();
                    string Mailtxt = ds.Tables[0].Rows[0]["Mail"].ToString();
                    string Telefontxt = ds.Tables[0].Rows[0]["Telefon"].ToString();


                    // burada veritabanından çektiğimiz bilgileri class'a ekliyoruz
                    Classlar.KullaniciBilgileri.KullaniciID = Convert.ToInt32(KullaniciIDtxt);
                    Classlar.KullaniciBilgileri.Ad = Adtxt;
                    Classlar.KullaniciBilgileri.Soyad = Soyadtxt;
                    Classlar.KullaniciBilgileri.KullaniciAd = KullaniciAdtxt;
                    Classlar.KullaniciBilgileri.Mail = Mailtxt;
                    Classlar.KullaniciBilgileri.Telefon = Telefontxt;

                    RezarvasyonIslemleri rezarvasyon = new RezarvasyonIslemleri();
                    rezarvasyon.Show();
                    this.Hide();



                }

                else
                {
                    //burada kullanıcı eğer yanlış bir bir kayıt girdiyse uyarı veriyoruz
                    MessageBox.Show("Kullanıcı  adı veya şifresi yanlış");
                    textBoxKulAd.Clear();
                    textBoxSifre.Clear();

                }
            }
        }

        private void buttonCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void linkLabelSifremiUnuttum_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SifremiUnuttum sifre = new SifremiUnuttum();
            sifre.Show();
            this.Hide();
        }

        private void buttonAnasayfa_Click(object sender, EventArgs e)
        {
            Anasayfa anasayfa = new Anasayfa();
            anasayfa.Show();
            this.Hide();
        }
    }
}
