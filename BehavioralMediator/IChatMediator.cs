using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralMediator
{
    // Mediator(Aracı) nesneleri konuşturur.
    public interface IChatMediator
    {
        //Userlarımızı tutmamızı sağlayan method
        void AddUser(IUser user);

        // Messageları göndermemizi sağlayan method
        void SendMessage(string message, IUser user);
    }
}
