using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralMediator
{
    class Program
    {
        // Kullanım Alanları: Örneğin Chat Uygulamasıdır. yani broadcast dağıtım işlemi yapıcak 5 kişiye birden string ifade yollama.  5 Sınıfı yani 5 Nesne'yi birbiri ile iletişime sokmak istiyorsak kullanmamız gereken design patterndir.
        // Mediator Design Pattern: Çok-Çok ilişki varsa ise Mediator! 1-ÇOK ilişki varsa Observer Design Pattern.

        /*
       Mediator design pattern (aracı tasarım deseni), behavior grubununa ait, çalışmaları birbirleri ile aynı arayüzden türeyen nesnelerin durumlarına bağlı olan nesnelerin davranışlarını düzenleyen tasarım desenidir. uluslar arası kullanıma göre kullanım oranı %40 civarındadır. 

       Bazı durumlarda nesnelerin davranışları kendi türünden başka nesnelere bağlı olabilir. Mediator tasarım deseni birbirleri ile ilişkili olan bu nesneler arasında ki iletişimin ana bir nesne üzerinden (mediator) yapılmasını sağlar. Böylece nesneler arasındaki bağ zayıflatılır ve geliştirme aşamasında kod karmaşasını önler ve kodun yönetilmesini kolaylaştırır.


       Mediator: Nesneler arasındaki ilişkiyi sağlayacak metotların tanımlı olduğu arayüz.

       ConcreteMediator: Nesneler arasındaki ilişkiyi sağlayacak gerçek nesnedir. Mediator arayüzünü uygular. İçinde Colleague ara yüzünden türeyen nesnelerin listesini barındırır.

       Colleague: ConcreteMediator u kullanarak işlem gerçekleştirecek olan nesnelerin uygulaması gereken arayüzü temsil eder. Kendi içinde ConcreteMediator nesnesi barındırır.

       ConcreteColleague: ConcreteMediator üzerinden birbirleri ile ilişkili nesnelerdir. Colleague arayüzünü uygularlar.
        */
        static void Main(string[] args)
        {
            //Chat uygulaması başlat
            IChatMediator chatMediator = new ChatMediator();

            IUser guney = new BasicUser(chatMediator, "Güney");
            IUser cetin = new PremiumUser(chatMediator, "Çetin");
            IUser test = new PremiumUser(chatMediator, "Test");

            chatMediator.AddUser(guney);
            chatMediator.AddUser(cetin);
            chatMediator.AddUser(test);

            test.SendMessage("Merhaba Arkadaşlar...");

            Console.ReadKey();
        }
    }
}
