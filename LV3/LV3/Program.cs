using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LV3
{
    class Program
    {
        static void Main(string[] args)
        {
            Dataset dataset = new Dataset("tekst.csv");
            Console.WriteLine("File data: \n" + dataset.ToString());

            Dataset cloneDataset = new Dataset();
            cloneDataset = (Dataset)dataset.Clone();
            Console.WriteLine("Cloned file data: \n" + cloneDataset.ToString());

            MatrixGenerator Matrix_Generator = MatrixGenerator.GetInstance();

            int[,] matrix = new int[6, 6];
            matrix = Matrix_Generator.GetMatrix(6,6);

            Logger logger = Logger.getInstance();
            logger.filePath = "Zapis.txt";
            logger.Log("Domagoj");
            logger.Log("Vocanec");

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(String.Format("{0}", matrix[i, j]) + "\t");
                }
                Console.Write("\n");
            }

            ConsoleNotification not1 =
                new ConsoleNotification("Domagoj", "Naslov 1", "Tekst 1", DateTime.Now, Category.ERROR, ConsoleColor.Cyan);
            ConsoleNotification not2 =
                new ConsoleNotification("Vocanec", "Naslov 2", "Tekst 2", DateTime.Now, Category.INFO, ConsoleColor.Green);
            
            NotificationManager NotManager = new NotificationManager();
            NotManager.Display(not1);
            NotManager.Display(not2);

            NotificationBuilder builder = new NotificationBuilder();
            builder.SetAuthor("Domagoj").SetLevel(Category.ERROR).SetText("Tekst 3").SetTitle("Naslov 3").SetColor(ConsoleColor.Blue);
            ConsoleNotification not3 = builder.Build();
            NotificationManager manager = new NotificationManager();
            manager.Display(not3);
        }

    }
}
