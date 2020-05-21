using System;
using System.Collections.Generic;

namespace LV4
{
    class Program
    {
        static void Main(string[] args)
        {
            Dataset dataset = new Dataset("zadatak.txt");
            Analyzer3rdParty analyzer = new Analyzer3rdParty();
            Adapter adapter = new Adapter(analyzer);

            double[] rowAverages = adapter.CalculateAveragePerRow(dataset);
            double[] columnAverages = adapter.CalculateAveragePerColumn(dataset);
            
            Console.WriteLine("Row averages:");
            foreach (double number in rowAverages)
                Console.WriteLine(number);
            
            Console.WriteLine("Column averages:");
            foreach (double number in columnAverages)
                Console.WriteLine(number);
            
            List<IRentable> rentables = new List<IRentable>();
            
            rentables.Add(new Video("Video 1"));
            rentables.Add(new Book("Book 1"));

            RentingConsolePrinter printer = new RentingConsolePrinter();
            
            printer.DisplayItems(rentables);
            printer.PrintTotalPrice(rentables);
            
            rentables.Add(new HotItem(new Video("Trending video")));
            rentables.Add(new HotItem(new Book("Trending book")));
            
            printer.DisplayItems(rentables);
            printer.PrintTotalPrice(rentables);

        }

    }
}
