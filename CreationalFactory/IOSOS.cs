using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalFactory
{
    class IOSOS : MobilApplication
    {
        public override void Platform()
        {
            Console.WriteLine("uygulama IOS phone için çalışabilecek şekilde kodlandı.. Çalıştırılıyor.");
        }
    }
}
