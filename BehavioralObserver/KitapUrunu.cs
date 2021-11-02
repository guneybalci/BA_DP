using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralObserver
{
    // Takip Edeceğin Subject Konumuzdur (Abone Olacağımız Nesne)
    public abstract class KitapUrunu
    {
        private decimal _Fiyat;
        public KitapUrunu(string urunAdi, decimal urunFiyat)
        {
            this.UrunAdi = urunAdi;
            this._Fiyat = urunFiyat;
        }

        public string UrunAdi { get; set; }

        // Encapsüle ediyoruz 
        public decimal Fiyat
        {
            get { return _Fiyat; }
            set
            {
                if (_Fiyat > value)
                {
                    // Kullanıcılara Haber Vermem Gerekiyor
                    NotifyUrun();
                }
                _Fiyat = value;
            } }

        private void NotifyUrun()
        {
            //takipListesi: Takipçi listesine yani abone olanlara bilgi ver.

            foreach (IUye item in takipListesi)
            {

                item.Update(this);
            }
        }

        public List<IUye> takipListesi = new List<IUye>();
    }
}
