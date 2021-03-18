using System;

namespace OOP3
{
    class FileLoggerSevice : ILoggerSevice
    {
        public void Log()
        {
            Console.WriteLine("Dosyaya loglandı");
        }
    }
}

