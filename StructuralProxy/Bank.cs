using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralProxy
{
    //real obj
    public class Bank
    {
        public bool Pay(double Amount)
        {
            if (Amount < 100)
            {
                Console.WriteLine("odeyeceğiniz tutar  100 tl den az olamaz :  Fark : " + (100 - Amount));
            }
            else if (Amount > 100)
            {
                Console.WriteLine("odeyeceğiniz tutar  100 tl den fazla olamaz :  Fark : " + (100 - Amount));
            }
            else
            {
                Console.WriteLine("ödeme yapıldı tutar : " + Amount);
                return true;
            }

            return false;
        }
    }
}
