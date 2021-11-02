using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CretionalProtoType
{
    class Program
    {
        static void Main(string[] args)
        {
            //DbContext  büyük yüklü classlar için new operatorunu oldukça az kullanmalıyız ki ram den tasarruf edelim. 
            //Game g1 = new Game(1,"heartStone","singlePlayer",true);
            //Game g2 =(Game) g1.Clone();
            //if (g1.Equals(g2))
            //{
            //    Console.WriteLine("bu tipler eşit");
            //}
            //else
            //{
            //    Console.WriteLine("farklı tipler");
            //}

            //ilk instance destroy edilmek uzere hazırlandı..
            using (Game g3 = new Game(1, "heartStone", "singlePlayer", true))
            {
                Game g4 = (Game)g3.Clone();
                //1000 kodlar 

            }

            Console.ReadKey();
        }
    }
}
