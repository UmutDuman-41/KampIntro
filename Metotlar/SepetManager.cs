using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{

    class SepetManager
    {
        // Parametre olarak 'urun' ekledik.
        public void Ekle(Urun urun) // Ne eklemek istediğimizi parantez içinde metoda(fonksiyon da denebilir) verdik.'Urun' veri tipi; küçük urun ise kullanırken verdiğimiz isimlendirme.
        {
            Console.WriteLine("Tebrikler.Sepete Eklendi : " + urun.Adi);

        }

        public void Ekle2(string urunAdi,string aciklama, double fiyat,int stokAdedi) // uzun uzun yazmaktansa Urun clasına stokAdedini ekleyerek işimizi kolaylaştırırız.
        {
            Console.WriteLine("Tebrikler.Sepete Eklendi = " + urunAdi);
        }

    }
}
