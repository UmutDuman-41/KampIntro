using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    interface IKrediManager // interface interface derki  birisi bu interface kullanırsa o arkadaş bu metodu içermeli.(Hesapla metodunu kastediyoruz.ya da BiseyYap metodunu.)
   // interface içeren classlar kendini interface e göre doldurmak zorndadır.
   //interfaceleri birbirinin alternatifi olan ama kod içerikleri farklı olan durumlar için kullanırız.
    
    {
        void Hesapla();
        void BiseyYap();
        

        
    }
}
