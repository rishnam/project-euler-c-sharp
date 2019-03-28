using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_5
{
    class Program
    {
        static void Main(string[] args)
        {
            const int number = 20;
            bool foundNumber = false;
            bool divisibleUpTo20 = true;
            int i = 2;
            while (!foundNumber)
            {
                int z = 2;
                divisibleUpTo20 = true;
                while (z <= number && divisibleUpTo20)
                {
                    if (i % z == 0)
                    {
                        z++;
                    }
                    else
                    {
                        divisibleUpTo20 = false;
                    }
                }
                if (z == number + 1)
                {
                    Console.WriteLine(i);
                    Console.ReadLine();
                    Environment.Exit(0);
                }

                i++;
            }
            Console.ReadLine();
        }
    }
}
