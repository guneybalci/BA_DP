using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalBuilder
{
    class Program
    {
        // Amaç Gerçek Nesneyi Kullanmamakdır.
        static void Main(string[] args)
        {
            // Kart Seçme Nesnesi
            KrediKartiBuilder kullaniciKart = new AmericanExpressConcreteBuilder();
            // Kart ile yapılacak işlemler nesnesi
            KrediKartiKullan kullan = new KrediKartiKullan();
            kullan.Kullan(kullaniciKart);

            //Console.WriteLine(kullaniciKart.ToString());
            Console.WriteLine(kullaniciKart.Kart.ToString());

            kullaniciKart = new VisaCardConcreteBuilder();
            kullan.Kullan(kullaniciKart);
            Console.WriteLine(kullaniciKart.ToString());
           
        }
    }
}
