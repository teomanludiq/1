using System;

namespace chisla
{
    class Program
    {
        static void Main(string[] args)
        {
            string chislo1 = "1101";
            string chislo2 = "1111";
            int chislo5 = Convert.ToInt32(chislo1, 2);
            int chislo6 = Convert.ToInt32(chislo2, 2);
            int chislo3 = chislo6 + chislo5;
            string chislo4 = Convert.ToString(chislo3, 2);
            Console.WriteLine(chislo4);
        }
    }
}
