using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalBuilder
{
    public class VisaCardConcreteBuilder : KrediKartiBuilder
    {
        public VisaCardConcreteBuilder()
        {
            kart = new KrediKarti();
        }
        public override void BankaAdi()
        {
            kart.BankaAdi = "Garanti Bankası";
        }

        public override void KartLimiti()
        {
            kart.KartLimiti = 8500;
        }

        public override void KartTipi()
        {
            kart.KartTipi = "VisaCard";
        }

        public override void TaksitAtlat()
        {
            kart.TaksitAtlat = false;
        }
    }
}
