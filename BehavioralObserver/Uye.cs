using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralObserver
{
    public class Uye : IUye
    {
        public string Email { get; set; }
        public void Update(KitapUrunu urun)
        {
            // Mail Gönderme Kodları İşletilmesi Gerekiyor
            //mail gönderme kodu 
            Console.WriteLine("{0} 'ın fiyatı {1} oldu.{2} adresine mail atıldı",urun.UrunAdi,urun.Fiyat,Email);
        }
    }
}
