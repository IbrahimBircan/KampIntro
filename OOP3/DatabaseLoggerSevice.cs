using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class DatabaseLoggerSevice : ILoggerSevice
    {
        public void Log()
        {
            Console.WriteLine("Veritabanı loglandı");
        }
    }
}

