using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeyahatAcentesi.Classlar
{

    public abstract class RaporFormatlari
    {
        public abstract void GenelBilgiler();
        public abstract void DetayliBilgiler();

        public abstract void fiyat();

        public abstract Rapor RaporOlustur();
    }
}
