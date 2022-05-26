using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeyahatAcentesi.Classlar
{
    public class Otobüs : IUlasim
    {

        void IUlasim.ulasimRezarvasyonuYap()
        {
         
        }
        public static string ulasimTipi()
        {
            return "Otobüs";
        }
        public static int fiyati()
        {
            return 50;
        }
    }
}
