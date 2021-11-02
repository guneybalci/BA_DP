using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalBuilder
{
    //Builder Arayüzü(Interface,Abstract) Visa, Master, Troy
    //Bunu yapma sebebi: KrediKartı Asıl Nesnemizin yeteneklerini tutacakdır.
    public abstract class KrediKartiBuilder
    {
        // protected inherit edildiği yerde kullanılabilir.
        // Asıl ürünü product ' ı derdim hangi karta geçtiğimde visaya göre işlem yapmak, constructorda new'lemek için
        // Set etme işlemi burada yapıyoruz
        protected KrediKarti kart;

        // Sadece okuma işlemi yapıyoruz
        public KrediKarti Kart
        {
            get { return kart; }
        }

        // Derdim hepsini kartlara göre uygulamak
        public abstract void BankaAdi();

        public abstract void KartTipi();

        public abstract void KartLimiti();

        public abstract void TaksitAtlat();
    }
}
