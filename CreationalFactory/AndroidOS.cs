using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalFactory
{
    class AndoridOS : MobilApplication
    {
        public override void Platform()
        {
            Console.WriteLine("uygulama Android phone için çalışabilecek şekilde kodlandı.. Çalıştırılıyor.");
        }
    }
}
