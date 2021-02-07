using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class DatabaseLoggerService : ILoggerService // diyoruzki sen aslında bir ILoggerService alternatifisin.interface içinde sadece imza metotları olur içi dolu olamaz.
    {
        public void Log()
        {
            Console.WriteLine("Veri tabanına loglandı");
        }
    }
}
