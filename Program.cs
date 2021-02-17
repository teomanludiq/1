using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vuvedete dvuichno chislo: ");
            string bin = Console.ReadLine();
            int dec = Convert.ToInt32(bin, 2);
            Console.WriteLine("deseti4no"+dec);
            Console.WriteLine("dvoi4no"+bin);
        }
    }
}
