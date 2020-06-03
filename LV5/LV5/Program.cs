using System;

namespace LV5
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product("Product 1", 14, 7.77);
            Product product2 = new Product("Product 2", 7, 14.7);

            Box ListProducts = new Box("products");
            ListProducts.Add(product1);
            ListProducts.Add(product2);
            
            ShippingService shippingService = new ShippingService(7);
            Console.WriteLine(shippingService.CalculatePrice(ListProducts));



            DataConsolePrinter dataPrinter = new DataConsolePrinter();

            VirtualProxyDataset virtualProxy = new VirtualProxyDataset("data.csv");
            dataPrinter.printData(virtualProxy);

            User domagoj = User.GenerateUser("Domagoj");
            User vocanec = User.GenerateUser("Vocanec");

            ProtectionProxyDataset domagojProxy = new ProtectionProxyDataset(domagoj);
            ProtectionProxyDataset vocanecProxy = new ProtectionProxyDataset(vocanec);

            dataPrinter.printData(domagojProxy);
            dataPrinter.printData(vocanecProxy);


            LoggingProxy proxy = new LoggingProxy("data.csv");
            
            dataPrinter.printData(proxy);

        }
    }
}
