using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeyahatAcentesi.Classlar
{
    public class RezarvasyonKontrol
    {
        private RezarvasyonFactory _rezarvasyonFactory;
        private IUlasim _ulasim;
        private IKonaklama _konaklama;

        public RezarvasyonKontrol(RezarvasyonFactory rezarvasyonFactory)
        {
            _rezarvasyonFactory = rezarvasyonFactory;
            _ulasim = _rezarvasyonFactory.ulasimOlustur();
            _konaklama = _rezarvasyonFactory.konaklamaOlustur();
        }

        public void RezarvasyonOlustur()
        {
            _ulasim.ulasimRezarvasyonuYap();
            _konaklama.konaklamaRezarvasyonuYap();
        }
    }
}
