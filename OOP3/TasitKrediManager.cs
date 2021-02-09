using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class TasitKrediManager : IKrediManager  //inherit ettiğimiz için 'TasitKrediManager' IKrediManager'daki Hesapla'ya sahip.Oradaki Hesapla Metodunu istediği kuralla kullanabilir.Aynı şekilde diğer class'lara.
    {
        public void BiseyYap()
        {
            throw new NotImplementedException();
        }

        public void Hesapla()
        {
            Console.WriteLine("Taşıt kredisi ödeme planı hesaplandı");
        }
    }
}
