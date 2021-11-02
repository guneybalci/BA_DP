using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralAdapter
{
    class Program
    {
        static void Main(string[] args)
        {
            ITarget target = new CalisanAdapter();

            FaturaSistemi f = new FaturaSistemi(target);
            f.CalisanGoster();

            Console.WriteLine("***************************************");
            ITarget trg = new PersonelDBAdapter();

            FaturaSistemi fs = new FaturaSistemi(trg);
            fs.CalisanGoster();

            Console.ReadKey();
        }
    }
}
