using System;
using System.Collections.Generic;
using System.Text;

namespace LV1
{
    class Program
    {
        static void Main(string[] args)
        {
            Zabiljeska zabiljeska = new Zabiljeska();
            Zabiljeska zabiljeska1 = new Zabiljeska("Tekst 1", "Domagoj", 4);
            Zabiljeska zabiljeska2 = new Zabiljeska("Tekst 2", string.Empty, 2);

            Console.WriteLine(zabiljeska.Tekst + ", " + zabiljeska.getAutor() + ", " + zabiljeska.Vaznost);
            Console.WriteLine(zabiljeska1.Tekst + ", " + zabiljeska1.getAutor() + ", " + zabiljeska1.Vaznost);
            Console.WriteLine(zabiljeska2.Tekst + ", " + zabiljeska2.getAutor() + ", " + zabiljeska2.Vaznost);
        }
    }
}
