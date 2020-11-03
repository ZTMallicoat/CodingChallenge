using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            while (i <= 1000)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine($"{i}");
                }
                else
                {
                    if (i % 5 == 0)
                    {
                        Console.WriteLine($"{i}");
                    }
                }
                i++;
            }
        }
    }
}
