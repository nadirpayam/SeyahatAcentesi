
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
    public partial class Rezarvasyonlarim : Form
    {
        public Rezarvasyonlarim()
        {
            InitializeComponent();
        }
        Classlar.SqlBaglantisi sql = new Classlar.SqlBaglantisi();
        void RezarvasyonlariGetir()
        {
            string sorgulamak = "select top 1 * from Rezarvasyonlar where KullaniciID='" + Classlar.KullaniciBilgileri.KullaniciID + "'" + "  order by newid()";

            DataTable tbl = new DataTable();
            SqlDataAdapter adtr = new SqlDataAdapter(sorgulamak, sql.baglan());
            adtr.Fill(tbl);
            dataGridViewRezlerim.DataSource = tbl;
        }
       
        int fiyat;
        int fiyat2;
   
     
        
       

        private void buttonRapor_Click(object sender, EventArgs e)
        {
            
            RaporAlmak rapor = new RaporAlmak();
            rapor.Show();
            this.Hide();
        }

        private void Rezarvasyonlarim_Load(object sender, EventArgs e)
        {
            RezarvasyonlariGetir();
            DataSet ds = new DataSet();
            string sql2 = "select top 1 * from Rezarvasyonlar where KullaniciID='" + Classlar.KullaniciBilgileri.KullaniciID + "'" + "  order by newid()";
            SqlDataAdapter da = new SqlDataAdapter(sql2, sql.baglan());
            ds = new DataSet();
            da.Fill(ds, "KULLANICIDENEME");
            //con.Close();

            if (ds.Tables[0].Rows.Count > 0)
            {
                // burada giren kullanıcının bilgilerini veritabnından çekiyoruz
                string donustxt = ds.Tables[0].Rows[0]["donusTarihi"].ToString();
                string gidistxt = ds.Tables[0].Rows[0]["gidisTarihi"].ToString();
                string konaklamatxt = ds.Tables[0].Rows[0]["konaklama"].ToString();
                string lokasyontxt = ds.Tables[0].Rows[0]["lokasyon"].ToString();
                string ulasimtxt = ds.Tables[0].Rows[0]["ulasim"].ToString();
                string fiyattxt = ds.Tables[0].Rows[0]["fiyat"].ToString();


                // burada veritabanından çektiğimiz bilgileri class'a ekliyoruz
                Classlar.RezarvasyonBilgileri.donustarihi = donustxt;
                Classlar.RezarvasyonBilgileri.gidistarihi = gidistxt;
                Classlar.RezarvasyonBilgileri.konaklama = konaklamatxt;
                Classlar.RezarvasyonBilgileri.lokasyon = lokasyontxt;
                Classlar.RezarvasyonBilgileri.ulasim = ulasimtxt;
                Classlar.RezarvasyonBilgileri.fiyat = fiyattxt;

                //////burada öğrenci anasayfasına yönlendiriyoruz

                //Kontrol kont = new Kontrol();
                //kont.Show();
                //this.Hide();

            }


        }

        private void buttonKonak_Click(object sender, EventArgs e)
        {
            string sorgu = "update Rezarvasyonlar set konaklama = 'İptal Edildi', fiyat=@yenifiyat where rezarvasyonID= @id";
            string a = dataGridViewRezlerim.CurrentRow.Cells["konaklama"].Value.ToString();
            switch (a)
            {
                case "Otel":
                    fiyat2 = Classlar.Otel.fiyat();
                    break;
                case "Çadır":
                    fiyat2 = Classlar.Cadir.fiyati();
                    break;
            }
            int kacgun = Convert.ToInt32(dataGridViewRezlerim.CurrentRow.Cells["kacgunkalacak"].Value);
            int yeni = ((Convert.ToInt32(dataGridViewRezlerim.CurrentRow.Cells["fiyat"].Value)) - (fiyat2 * kacgun));
            SqlCommand komut = new SqlCommand(sorgu, sql.baglan());
            komut.Parameters.AddWithValue("@id", Convert.ToInt32(dataGridViewRezlerim.CurrentRow.Cells["rezarvasyonID"].Value));
            komut.Parameters.AddWithValue("@yenifiyat", yeni);
            komut.ExecuteNonQuery();
            MessageBox.Show("Albüm bilgileri güncellendi.");
            RezarvasyonlariGetir();
        }

        private void buttonUlasim_Click(object sender, EventArgs e)
        {
            string sorgu = "update Rezarvasyonlar set ulasim = 'İptal Edildi', fiyat=@yenifiyat where rezarvasyonID= @id";
            string a = dataGridViewRezlerim.CurrentRow.Cells["ulasim"].Value.ToString();
            switch (a)
            {
                case "Uçak":
                    fiyat = Classlar.Ucak.fiyati();
                    break;
                case "Otobüs":
                    fiyat = Classlar.Otobüs.fiyati();
                    break;
            }
            MessageBox.Show(fiyat.ToString());
            SqlCommand komut = new SqlCommand(sorgu, sql.baglan());
            komut.Parameters.AddWithValue("@id", Convert.ToInt32(dataGridViewRezlerim.CurrentRow.Cells["rezarvasyonID"].Value));
            komut.Parameters.AddWithValue("@yenifiyat", Convert.ToInt32(dataGridViewRezlerim.CurrentRow.Cells["fiyat"].Value) - fiyat);
            komut.ExecuteNonQuery();
            MessageBox.Show("Albüm bilgileri güncellendi.");
            RezarvasyonlariGetir();
        }

        private void buttonRezİptal_Click(object sender, EventArgs e)
        {
            string sorgu = "DELETE FROM Rezarvasyonlar WHERE rezarvasyonID=@id";
            SqlCommand komut = new SqlCommand(sorgu, sql.baglan());
            komut.Parameters.AddWithValue("@id", dataGridViewRezlerim.CurrentRow.Cells["rezarvasyonID"].Value);
            komut.ExecuteNonQuery();
            RezarvasyonlariGetir();
            MessageBox.Show("Rezarvasyon İptal Edildi");
        }
    }
}

