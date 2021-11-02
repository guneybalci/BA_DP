using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalBuilder
{
   public class KrediKartiKullan
    {
        // Dışarıdan aldığı KrediKartuBuilder tetikliyecek. Ne ile newleydiysek o kartın bilgileri çalışcak örneğin garanti bankası
        public void Kullan(KrediKartiBuilder kart)
        {
            kart.BankaAdi();
            kart.KartLimiti();
            kart.KartTipi();
            kart.TaksitAtlat();
        }
    }
}
