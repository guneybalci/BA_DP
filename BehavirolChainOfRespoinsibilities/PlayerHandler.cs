using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavirolChainOfRespoinsibilities
{
    // Yönetici sınıfımızdır.
    // 1 tane Abstract veya Interface Class içermelidir. Seçim bize aittir.
    // Kodumuzun içerisinde if-else & switch-case yapısından kurtulmak ve bunun yerini conditional class ile yapmış olacağız.
    public abstract class PlayerHandler
    {
        //
        protected PlayerHandler _SonrakiHandler;

        public PlayerHandler SonrakiHandler
        {
            set
            {
                _SonrakiHandler = value;
            }
        }

        // örneğin mp4, avi  dosya türlerini gelip oynatabildiğini kontrol edicez.
        public abstract void Play(string filePath);
    }
}
