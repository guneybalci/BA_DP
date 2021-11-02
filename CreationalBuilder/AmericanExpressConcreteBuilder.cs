using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalBuilder
{
    public class AmericanExpressConcreteBuilder : KrediKartiBuilder
    {
        public AmericanExpressConcreteBuilder()
        {
            kart = new KrediKarti();
        }
        public override void BankaAdi()
        {
            kart.BankaAdi = "Deniz Bank";
        }

        public override void KartLimiti()
        {
            kart.KartLimiti = 500;
        }

        public override void KartTipi()
        {
            kart.KartTipi = "American Express";
        }

        public override void TaksitAtlat()
        {
            kart.TaksitAtlat = true;
        }
    }
}
