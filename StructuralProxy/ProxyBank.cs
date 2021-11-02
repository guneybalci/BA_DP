using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralProxy
{
    class ProxyBank : IBank
    {
        Bank banka;
        bool Login;
        string _username, _password;
        public ProxyBank(string username, string password)
        {
            _username = username;
            _password = password;
        }
        bool GirisYap()
        {
            if (_username.Equals("melike") && _password.Equals("123"))
            {
                banka = new Bank();
                Login = true;
                Console.WriteLine("Başarılı bir giriş yaptınız ... ");
                return true;
            }
            else
            {
                Console.WriteLine("hatalı giriş yaptınız..");
            }

            Login = false;
            return false;
        }

        public bool OdemeYap(double tutar)
        {
            GirisYap();
            if (!Login)
            {
                Console.WriteLine("hesaba giriş yapılamadıgından ödeme alınamamıştır...");
                return false;
            }

            banka.Pay(tutar);
            return true;
        }
    }
}
