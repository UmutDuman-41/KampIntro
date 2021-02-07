using System;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> isimler = new MyList<string>(); // MyList<string> string türünde bir liste demek.Yani arka planda bizim 'T'miz string oluyor.
            isimler.Add("Engin"); // Arka tarafta bizim T'miz string oldu bu yüzden string bir değer ekledik.
            Console.WriteLine("Hello World!");
        }
    }
}
