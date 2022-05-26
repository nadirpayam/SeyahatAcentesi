
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
            //string sorgu = "select top 1 rezarvasyonID, ulasim, konaklama, gidisTarihi, donusTarihi, lokasyon,kacgunkalacak, fiyat from Rezarvasyonlar " +
            // " where KullaniciID='" + Classlar.KullaniciBilgileri.KullaniciID + "'" + " order by newid()";
            //DataTable tbl = new DataTable();
            //SqlDataAdapter adtr = new SqlDataAdapter(sorgu, sql.baglan());
            //adtr.Fill(tbl);
            //dataGridViewRezlerim.DataSource = tbl;
            //DataSet ds = new DataSet(); //string sorgulamak = "select top 1 rezarvasyonID, ulasim, konaklama, gidisTarihi, donusTarihi, lokasyon,kacgunkalacak, fiyat from Rezarvasyonlar " +
            // " where KullaniciID='" + Classlar.KullaniciBilgileri.KullaniciID + "'";
            //DataTable tbl = new DataTable();
            //SqlDataAdapter adtr = new SqlDataAdapter(sorgulamak, sql.baglan());
            //adtr.Fill(tbl);
            //dataGridViewRezlerim.DataSource = tbl;
            string sorgu = "select rezarvasyonID, ulasim, konaklama, gidisTarihi, donusTarihi, lokasyon,kacgunkalacak, fiyat from Rezarvasyonlar " +
            " where KullaniciID='" + Classlar.KullaniciBilgileri.KullaniciID + "'"; DataTable tbl = new DataTable();
            SqlDataAdapter adtr = new SqlDataAdapter(sorgu, sql.baglan());
            adtr.Fill(tbl);
            dataGridViewRezlerim.DataSource = tbl;
            string sorgu2 = "select top 1 rezarvasyonID, ulasim, konaklama, gidisTarihi, donusTarihi, lokasyon,kacgunkalacak, fiyat from Rezarvasyonlar " +
            " where KullaniciID='" + Classlar.KullaniciBilgileri.KullaniciID + "'" + " order by newid()"; DataTable tbl2 = new DataTable();
            SqlDataAdapter adtr2 = new SqlDataAdapter(sorgu2, sql.baglan());
            adtr2.Fill(tbl2);
            dataGridViewRezlerim.DataSource = tbl2; DataSet ds2 = new DataSet();
            ds2 = new DataSet();
            adtr2.Fill(ds2, "KULLANICIDENEME"); if (ds2.Tables[0].Rows.Count > 0)
            {
                //con.Close();
                string fiyattxt = ds2.Tables[0].Rows[0]["fiyat"].ToString();
                string GidisTarihitxt = ds2.Tables[0].Rows[0]["gidisTarihi"].ToString();
                string DonusTarihitxt = ds2.Tables[0].Rows[0]["donusTarihi"].ToString();
                string Lokasyontxt = ds2.Tables[0].Rows[0]["lokasyon"].ToString();
                string Ulasimtxt = ds2.Tables[0].Rows[0]["ulasim"].ToString();
                string Konaklamatxt = ds2.Tables[0].Rows[0]["konaklama"].ToString();
                // // burada veritabanından çektiğimiz bilgileri class'a ekliyoruz
                Classlar.RezarvasyonBilgileri.fiyat = fiyattxt;
                Classlar.RezarvasyonBilgileri.gidistarihi = GidisTarihitxt;
                Classlar.RezarvasyonBilgileri.donustarihi = DonusTarihitxt;
                Classlar.RezarvasyonBilgileri.lokasyon = Lokasyontxt;
                Classlar.RezarvasyonBilgileri.ulasim = Ulasimtxt;
                Classlar.RezarvasyonBilgileri.konaklama = Konaklamatxt;
            }
        }
        private void Rezarvasyonlarim_Load(object sender, EventArgs e)
        {
            RezarvasyonlariGetir();
        }
        int fiyat;
        int fiyat2;
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
        private void buttonReziptal_Click(object sender, EventArgs e)
        {
            string sorgu = "DELETE FROM Rezarvasyonlar WHERE rezarvasyonID=@id";
            SqlCommand komut = new SqlCommand(sorgu, sql.baglan());
            komut.Parameters.AddWithValue("@id", dataGridViewRezlerim.CurrentRow.Cells["rezarvasyonID"].Value);
            komut.ExecuteNonQuery();
            RezarvasyonlariGetir();
            MessageBox.Show("Rezarvasyon İptal Edildi");
        }
        private void button1_Click(object sender, EventArgs e)
        {
            RaporAlmak rapor = new RaporAlmak();
            rapor.Show();
            this.Hide();
        }
    }
}

