using System;

namespace GoTo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            Console.WriteLine("Singapore");
            Console.WriteLine("Korea");
            Console.WriteLine("USA");
            Console.WriteLine("Japan");
            mylabel:
            Console.WriteLine("Nepal");
            i++;
            if (i <= 5)
            {
                goto mylabel;
            }
            Console.WriteLine("Dubai");

            Console.ReadKey();
        }
    }
}
