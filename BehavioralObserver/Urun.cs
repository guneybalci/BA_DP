using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralObserver
{
    public class Urun : KitapUrunu
    {
        public Urun(string urunAdi, decimal urunFiyat) : base(urunAdi, urunFiyat)
        {
        }
    }
}
