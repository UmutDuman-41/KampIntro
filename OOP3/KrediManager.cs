using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    interface IKrediManager //  interface derki  birisi bu interface'i kullanırsa o arkadaş bu metodu içermeli.(Hesapla metodunu kastediyoruz.ya da BiseyYap metodunu.)
   // interface içeren classlar kendini interface e göre doldurmak zorundadır.
   //interfaceleri birbirinin alternatifi olan ama kod içerikleri farklı olan durumlar için kullanırız.
   // İnterface'ler sayesinde  class'lar Hesapla metodunu farklı işlemler için kullanablir.
    // IKrediManager'daki I, interface olduğunu anlamamız içindir.
    {
        void Hesapla();
        void BiseyYap();
        

        
    }
}
