using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralAdapter
{
    public class PersonelSistem
    {
        public string[][] PersonelGetir()
        {
            //db den okuyor
            string[][] calisanlar = new string[2][];
            calisanlar[0] = new string[] { "250", "Ayşe", "eğitmen" };
            calisanlar[1] = new string[] { "300", "Fatma", "danışman" };
            return calisanlar;
        }
    }
}
