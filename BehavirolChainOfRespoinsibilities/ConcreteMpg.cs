using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavirolChainOfRespoinsibilities
{
    public class ConcreteMpg : PlayerHandler
    {
        // Gelen filePath içerisindeki mpg veya api mi öyle ise oynat işlemi yapıcağız.
        // Gelen filePath oynatabiliyormuyuz? oynatabiliyorsak oynatalım. Oynatamıyorsak diğer dosya türüne geçelim.
        public override void Play(string filePath)
        {
            if (filePath.EndsWith(".mpg"))
            {
                Console.WriteLine("{0} dosya oynatılıyor..", filePath);
            }
            else
            {
                if (_SonrakiHandler != null)
                {
                    // mpg değilse _SonrakiHandler ile geçiş yapmasıdır.
                    // Sonrakinde ne varsa avi, mpg onu işlet.
                    _SonrakiHandler.Play(filePath);
                }
            }
        }
    }
}
