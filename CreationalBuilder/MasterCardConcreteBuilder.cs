using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalBuilder
{
    // Somut Builder Nesnesi
   public class MasterCardConcreteBuilder : KrediKartiBuilder
    {
        public MasterCardConcreteBuilder()
        {
            kart = new KrediKarti();
        }
        public override void BankaAdi()
        {
            kart.BankaAdi = "İş Bankası";
        }

        public override void KartLimiti()
        {
            kart.KartLimiti = 3000;
        }

        public override void KartTipi()
        {
            kart.KartTipi = "MasterCard";
        }

        public override void TaksitAtlat()
        {
            kart.TaksitAtlat = true;
        }
    }
}
