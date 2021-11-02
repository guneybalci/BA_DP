using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralAdapter
{
    public class CalisanSistem
    {
        public string[][] CalisanGetir()
        {
            //webapi den okuyor
            string[][] calisanlar = new string[2][];
            calisanlar[0] = new string[] { "250", "melike", "eğitmen" };
            calisanlar[1] = new string[] { "300", "demet", "danışman" };
            return calisanlar;
        }


    }
}
