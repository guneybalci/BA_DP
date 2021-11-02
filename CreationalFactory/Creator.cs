using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalFactory
{
    class Creator
    {

        public MobilApplication FactoryMethod(OSType osType)
        {
            MobilApplication deger = null;
            switch (osType)
            {
                case OSType.Android:

                    deger = new AndoridOS();
                    break;
                case OSType.IOS:
                    deger = new IOSOS();
                    break;
                case OSType.Windows:
                    deger = new WindowsOS();
                    break;
                default:
                    break;
            }

            return deger;

        }

    }
}