using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralMediator
{
    public class PremiumUser : IUser
    {
        string _name;
        IChatMediator _chatMediator;

        public PremiumUser(IChatMediator chatMediator, string name)
        {
            _name = name;
            _chatMediator = chatMediator;
        }
        public void ReceiveMessage(string message)
        {
            Console.WriteLine("Kullanıcı Tipi Premium {0}; Alınan mesaj: {1}", _name, message);
        }

        public void SendMessage(string message)
        {
            _chatMediator.SendMessage(message, this);
        }
    }
}
