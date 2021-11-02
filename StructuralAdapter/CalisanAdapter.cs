using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralAdapter
{
    public class CalisanAdapter : CalisanSistem, ITarget
    {
        public List<string> EmployeeList()
        {
            List<string> calisanlarim = new List<string>();

            foreach (string[] item in CalisanGetir())
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
