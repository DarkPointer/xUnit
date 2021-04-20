using System;

namespace PrimeService.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            PrimeService primeService = new PrimeService();

            int result = primeService.dummy();
            
            Console.WriteLine("Hello World!");
            Console.WriteLine(result);
        }
    }
}
