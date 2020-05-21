using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LV3
{
    class Logger
    {
        private static Logger instance;
        public string filePath { private get; set; }

        private Logger()
        {
            this.filePath = "default.txt";
        }
        public static Logger getInstance()
        {
            if (instance == null)
            {
                instance = new Logger();
            }
            return instance;
        }
        public void Log(String data)
        {
            using (System.IO.StreamWriter writer = new System.IO.StreamWriter(this.filePath, true))
            {
                writer.WriteLine(data);
            }
        }
    }
}
