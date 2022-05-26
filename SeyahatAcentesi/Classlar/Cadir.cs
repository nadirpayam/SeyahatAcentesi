using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeyahatAcentesi.Classlar
{
    public class Cadir : IKonaklama
    {
        void IKonaklama.konaklamaRezarvasyonuYap()
        {
      
        }
        public static string konaklamaTipi()
        {
            return "Çadır";
        }
        public static int fiyati()
        {
            return 75;
        }
    }
}
