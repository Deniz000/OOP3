using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class IhtiyacKrediManager : ICreditManager
    {
        public void Hesapla()
        {
            Console.WriteLine("İhtiyaç K. Hesaplandı");
         }

        public void Yap()
        {
            throw new NotImplementedException();
        }
    }

}
