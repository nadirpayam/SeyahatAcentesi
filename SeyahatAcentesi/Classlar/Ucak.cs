using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeyahatAcentesi.Classlar
{
    public class Ucak : IUlasim
    {
        
        void IUlasim.ulasimRezarvasyonuYap()
        {
          
        }
        public static string ulasimTipi()
        {
            return "Uçak";
        }

        public static int fiyati()
        {
            return 200;
        }
    }
}
