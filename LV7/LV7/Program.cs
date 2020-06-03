using System;

namespace LV7
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Zadatak

            double[] numbers = new double[] { 7, 4, 6, 14, 9, 1, 3, 2, 0, 12, 5 };

            NumberSequence sequentialSortSequence = new NumberSequence(numbers);
            sequentialSortSequence.SetSortStrategy(new SequentialSort());

            NumberSequence bubbleSortSequence = new NumberSequence(numbers);
            bubbleSortSequence.SetSortStrategy(new BubbleSort());

            NumberSequence combSortSequence = new NumberSequence(numbers);
            combSortSequence.SetSortStrategy(new CombSort());

            sequentialSortSequence.Sort();
            bubbleSortSequence.Sort();
            combSortSequence.Sort();

            Console.WriteLine(sequentialSortSequence.ToString());
            Console.WriteLine(bubbleSortSequence.ToString());
            Console.WriteLine(combSortSequence.ToString());



            //2. Zadatak
            NumberSequence numberSequence = new NumberSequence(numbers);
            numberSequence.SetSearchStrategy(new SeqSearch());

            Console.WriteLine(numberSequence.Search(7));
            Console.WriteLine(numberSequence.Search(14));




            //3. i 4. Zadatak
            SystemDataProvider dataProvider = new SystemDataProvider();
            dataProvider.Attach(new FileLogger("data.txt"));
            dataProvider.Attach(new ConsoleLogger());

            while (true)
            {
                dataProvider.GetCPULoad();
                dataProvider.GetAvailableRAM();
                System.Threading.Thread.Sleep(1000);
            }
        }
    }
}
