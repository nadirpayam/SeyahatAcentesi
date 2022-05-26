using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeyahatAcentesi.Classlar
{
   public  class OtobüsCadirFactory1 : RezarvasyonFactory
    {
        public override IKonaklama konaklamaOlustur()
        {
            return new Cadir();
        }

        public override IUlasim ulasimOlustur()
        {
            return new Otobüs();
        }
    }
}
