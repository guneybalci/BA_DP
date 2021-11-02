using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavirolChainOfRespoinsibilities
{
    public class ConcreteAvi : PlayerHandler
    {
        public override void Play(string filePath)
        {
            if (filePath.EndsWith(".avi"))
            {
                Console.WriteLine("{0} uzantılı dosya oynatılıyor", filePath);
            }
            else
            {
                if (_SonrakiHandler != null)
                {
                    _SonrakiHandler.Play(filePath);
                }
            }
        }
    }
}
