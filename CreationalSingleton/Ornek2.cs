using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalSingleton
{
    class Ornek2
    {
        public void Hede()
        {

        }

        private static Ornek2 _obje;

        private static Object lockObject = new Object();

        private Ornek2() { }

        public static Ornek2 newlenmisObje
        {
            get
            {
                if (_obje == null)
                {
                    //nullanıncaya kadar 
                    lock (lockObject)
                    {

                        if (_obje == null)
                        {
                            _obje = new Ornek2();
                        }
                    }
                }
                return _obje;
            }
        }
    }
}
