using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    // Biz aşağıda işlemlerimizi T tipi ile yaptık. 
    class MyList<T>         // Biz MyList te T ile çalışacağız.T yerine başka bir şey de yazabiliriz.İstersek string,double hatta bir class bile koyabilirdik.
    {
        T[] items; // bir diziyi new'lememiz lazım yoksa hata alırız.Burada 'T' türünde bir dizi tanımladık. T ise hangi tür seçilirse o türe dönüşür.
        // BU blok constructor
        public MyList() // buda aslında bir metot.bu metot bloğunu ctor yazıp iki kez tab yaptığımızda kolayca yapabiliriz.Constructor bloğu.
        {
            items = new T[0];  //artık bizim elimizde bir dizi var 0 elemanlı. ve biz şimdi dizimize eleman ekleyebiliriz. Aşağıda ekleyeceğiz.
        }
        //Diyelimki program.cs'nin içinde string MyList oluşturduk(yukarıda class ın yanındaki).new'lediğimiz an public MyList() constructor'ı çalışır.İlk etapta items diye bir tane array'imiz oluşuyor.items Heap'te 0 elemanlı olarak oluştu.
        //DEVAM: MyList.Add deyince (yeni bir eleman eklemek istediğimizde yani) string bir şey yollayacağız.Örneğin Engin'i yolladık.Ama Heap'te hiç boşluk yok çünkü 0 elemanlı.Bu yüzden bizim Heap'te 1 eleman tutabileceğimiz bir versiyonunu oluşturmamız lazım.
        //DEVAM: O yüzden new'leriz.items.Length + 1 dediğimizde de 1 yer ayarlıyoruz.
        public void Add(T item) // Yeni bir eleman eklemek istediğimizde MyList.Add dediğimizde bir eleman eklemek istedik ama liste 0 elemanlı olduğu için önce eleman sayısını new ile aşağıda arttırdık.
        {
            T[] tempArray = items;  //tempArray geçici dizi demek. geçici dizinin referansı items ın referansı.yani items'ın referansını tutuyor.yani elemanlarımız kaybolmayacak çünkü tempArray e emanet ediyoruz.Böylece new dediğimiz zaman kaybolacak olan elemanlar burada tutulacak. 
            items = new T[items.Length + 1]; // items.Length+1 dediğimizde dizinin eleman sayısını 1 arttırıyoruz.ve bunun için new dedik.
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];  // diyoruzki bizim items'ın i'ninci elemanı = tempArray den gelen geçici olarak verdiğim i'ninci elemandır.Yani  tempArrey e verdiğimiz emanet değerleri sırası ile üstümüze geri alıyoruz.

            }

            items[items.Length - 1] = item; //items' ın son elemanı(items.Length-1 yani) = item.dediğimizde yukarıdan gelen asıl eklemek istediğimiz elemanı eklemiş oluyoruz.  
        }
    }
}
