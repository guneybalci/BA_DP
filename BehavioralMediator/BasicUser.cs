using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralMediator
{
    public class BasicUser : IUser
    {
        string _name;
        IChatMediator _chatMediator;

        public BasicUser(IChatMediator chatMediator , string name)
        {
            _name = name;
            _chatMediator = chatMediator;
        }
        public void ReceiveMessage(string message)
        {
            Console.WriteLine("Kullanıcı Tipi Basic {0}; Alınan mesaj : {1}", _name, message);
        }

        public void SendMessage(string message)
        {
            _chatMediator.SendMessage(message, this);
        }
    }
}
