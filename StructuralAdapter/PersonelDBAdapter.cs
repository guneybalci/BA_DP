using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralAdapter
{
    public class PersonelDBAdapter : PersonelSistem, ITarget
    {
        public List<string> EmployeeList()
        {
            List<string> calisanlarim = new List<string>();
            //dbden gelen veri uzerinde çalış
            foreach (string[] item in PersonelGetir())
            {
                calisanlarim.Add(item[0]);
                calisanlarim.Add(",");
                calisanlarim.Add(item[1]);
                calisanlarim.Add(",");
                calisanlarim.Add(item[2]);
                //boşluk 
            }

            return calisanlarim;

        }
    }
}
