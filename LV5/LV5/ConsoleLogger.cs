using System;
using System.Collections.Generic;
using System.Text;

namespace LV5
{
    class ConsoleLogger
    {
        private static ConsoleLogger instance;

        private ConsoleLogger() { }

        public static ConsoleLogger Instance()
        {
            if (instance == null)
                instance = new ConsoleLogger();
            return instance;
        }

        public void Log()
        {
            Console.WriteLine(DateTime.Now);
        }

    }
}
