using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeyahatAcentesi.Classlar
{
    public class Otel : IKonaklama
    {
        void IKonaklama.konaklamaRezarvasyonuYap()
        {
          
        }

        public static string konaklamaTipi()
        {
            return "Otel";
        }
        public static int fiyat()
        {
            return 200;
        }
    }
}
