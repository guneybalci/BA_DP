using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralProxy
{
    class Program
    {
        static void Main(string[] args)
        {
            string kullaniciAdi = "güney";
            string sifre = "123";
            double tutar = 100;

            var deger = new ProxyBank(kullaniciAdi, sifre);
            deger.OdemeYap(tutar);
            Console.ReadKey();
        }
    }
}
