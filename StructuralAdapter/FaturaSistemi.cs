using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralAdapter
{
    public class FaturaSistemi
    {

        private ITarget _calisanlar;
        public FaturaSistemi(ITarget calisanlar)
        {
            _calisanlar = calisanlar;
        }
        public void CalisanGoster()
        {
            //select
            List<string> calisan = _calisanlar.EmployeeList();
            foreach (var item in calisan)
            {
                Console.Write(item);
            }
        }
    }
}
