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
            //string sorgu = "Select"
            //DataTable tbl = new DataTable();
            //SqlDataAdapter adtr = new SqlDataAdapter(sorgulamak, sql.baglan());
            //adtr.Fill(tbl);
            //dataGridViewSorular.DataSource = tbl;
        }
     
    }
}
