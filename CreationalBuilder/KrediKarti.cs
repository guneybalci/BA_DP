using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalBuilder
{
    // Real Object = Asıl Nesne = Product
    public class KrediKarti
    {
        public string BankaAdi { get; set; }

        public string KartTipi { get; set; }

        public decimal KartLimiti { get; set; }

        public bool TaksitAtlat { get; set; }

        public override string ToString()
        {
            return $"{BankaAdi} bankasına ait müşteri {KartTipi}'ni kullanmaktadır ve {KartLimiti} TL'dir. Ayrıca taksit atlatma özelliği ise {TaksitAtlat}";
        }
    }
}
