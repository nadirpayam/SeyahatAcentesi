using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeyahatAcentesi.Classlar
{
    public class UcakCadirFactory3 : RezarvasyonFactory
    {
        public override IUlasim ulasimOlustur()
        {
            return new Ucak(); 
        }
        public override IKonaklama konaklamaOlustur()
        {
            return new Cadir();
        }
    }
}
