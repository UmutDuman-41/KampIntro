using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    class Musteri
    {
        //Class'ların 2 tane özelliği vardır; 1) İçerisinde özellikler tutar. 2) İçerisinde operasyonlar tutardı.
        // Özellik tuttuğumuz yerde operasyon tutmuyoruz, operasyon tuttuğunuz yerde özellik tutmuyoruz.
        public int Id { get; set; }
        public string MusteriNo { get; set; }

        //NOT: Eğer bir veri üzerinde matematiksel işlem yapmıyorsan(yani çarpma,bölme vs.) onu string olarak tanımlamak daha güzel olacaktır.
    }
}
