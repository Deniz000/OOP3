using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class KonutKrediManager : ICreditManager
    {
        public void Hesapla()
        {
            Console.WriteLine("Konut Hesaplandı.");
        }

        public void Yap()
        {
            throw new NotImplementedException();
        }
    }
}
