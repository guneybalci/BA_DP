using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalSingleton
{
    class Ornek1
    {
        private Ornek1()
        {

        }

        #region MyRegion
        //eager
        private static Ornek1 benimNesnem = new Ornek1();
        public static Ornek1 YeniVeri()
        {
            return benimNesnem;
        }

        public static Ornek1 ClassiGetir
        {
            get
            {

                return benimNesnem;
            }
        }
        #endregion

        //lazy
        private static Ornek1 mySingletonObje;
        public static Ornek1 MysingletonProperty
        {
            get
            {
                if (mySingletonObje == null)
                    mySingletonObje = new Ornek1();

                return mySingletonObje;
            }
        }
        public int KareAl(int deger)
        {
            return deger + deger;
        }
    }
}
