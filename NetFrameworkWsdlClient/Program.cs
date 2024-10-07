using System;

namespace NetFrameworkWsdlClient
{
    class Program
    {
        static void Main(string[] args)
        {
            // Proxy létrehozása
            var client = new CalculatorService.CalculatorClient();

            // Szolgáltatás meghívása
            int result = client.Add(5, 7);
            Console.WriteLine("5 + 7 = " + result);

            client.Close();

            Console.ReadLine();
        }
    }
}
