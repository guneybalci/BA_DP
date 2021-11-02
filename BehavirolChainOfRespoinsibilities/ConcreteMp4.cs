using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavirolChainOfRespoinsibilities
{
    public class ConcreteMp4 : PlayerHandler
    {
        public override void Play(string filePath)
        {
            if (filePath.EndsWith(".mp4"))
            {
                Console.WriteLine("{0} uzantılı dosya formatı oynatılıyor", filePath);
            }
            else
            {
                Console.WriteLine("{0} geçerli bir dosya formatı girmediniz", filePath);
            }
        }
    }
}
