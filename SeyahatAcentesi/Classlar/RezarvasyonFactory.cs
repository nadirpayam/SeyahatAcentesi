using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeyahatAcentesi.Classlar
{
    public abstract class RezarvasyonFactory
    {
        public abstract IUlasim ulasimOlustur();
        public abstract IKonaklama konaklamaOlustur();
    }
}
