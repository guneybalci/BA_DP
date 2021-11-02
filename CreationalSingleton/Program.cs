using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalSingleton
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Ornek1 o = new Ornek1();
            Ornek1 o = Ornek1.ClassiGetir;
            o.KareAl(4);


            /*var deger = */
            Ornek2.newlenmisObje.Hede();

        }
    }
}
