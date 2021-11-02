using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralMediator
{
    public class ChatMediator : IChatMediator
    {
        // Whatsapp Grubu için Katılımcılarımdan Eklediğim Kişileri Topladığım Alandır.
        List<IUser> _users;

        public ChatMediator()
        {
            _users = new List<IUser>();
        }
        public void AddUser(IUser user)
        {
            _users.Add(user);
        }

        public void SendMessage(string message, IUser user /* Mesaj Gönderen User */)
        {
            foreach (IUser item in _users)
            {
                // Eğer gönderici kendisi değil ise mesaj alsın 
                if (item != user)
                {
                    // Broadcast dağıtıyoruz.. Diğer kişilerin almasını sağlıyoruz.
                    item.ReceiveMessage(message);
                }
            }
        }
    }
}
