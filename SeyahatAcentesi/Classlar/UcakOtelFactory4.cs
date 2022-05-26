using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeyahatAcentesi.Classlar
{
   public class UcakOtelFactory4 : RezarvasyonFactory
    {
        public override IUlasim ulasimOlustur()
        {
            return new Ucak();
        }
        public override IKonaklama konaklamaOlustur()
        {
            return new Otel();
        }
    }
}
