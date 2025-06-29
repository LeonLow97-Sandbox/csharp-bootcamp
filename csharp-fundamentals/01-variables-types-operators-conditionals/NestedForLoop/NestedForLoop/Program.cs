using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestedForLoop
{
    internal class Program
    {
        static void Main()
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 5; j >= 1; j--)
                {
                    System.Console.Write(j);
                    System.Console.Write(" ");
                }
                System.Console.WriteLine();
            }
        }
    }
}
