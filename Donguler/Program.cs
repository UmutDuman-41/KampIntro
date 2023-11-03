 using System;

namespace Donguler
{
    class Program
    {   
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım Geliştirici Yetiştirme Kampı"; 
            string kurs2 = "Programlamaya Başlangıç için Temel Kurs";
            string kurs3 = "Java"; // Bu şekilde uzun uzun stringleri tanımlamaktansa dizilerde tanımlayarak işimizi kolaylaştırabiliriz.
            string kurs4 = "Python";
            string kurs5 = "C#";

            //Bu tip verileri dizilerde yani array'lerde tutarız.
            //Bir array alttaki gibi yazılır.
            string[] kurslar = new string[] { "Yazılım Geliştirici Yetiştirme Kampı" ,"Programlamaya Başlangıç için Temel Kurs",
            "Java","Python","C#"};   //kurslar diye bir array oluşturduk ve bu sayede istediğimiz kadar kursu tek bir değişkende tutabiliriz.


            for (int i = 0; i < kurslar.Length; i++)  // i++;i'yi 1 er 1 er attır demek. i yi 1 den başlat 10 a kadar 1 er 1 er attır demek bu döngü.
                                          // i = i+2 demek i'yi 2 şer 2 şer attır demek. i+=2 de aynı şeydir.kurslar.Length demek tüm elemanlar demek.
            {
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine("For bitti");

            foreach (string kurs in kurslar) // in kurslar demek kurslar içindeki kursları tek tek dolaş.Foreach dizilere uygulanır. Foreach dizi temelli yapıları tek tek dönmeye
                                             // yarıyor.kurs'un veri tipi ise string

            {
                Console.WriteLine(kurs);
            }
            
            
            Console.WriteLine("Sayfa sonu");
        }
    }
}
