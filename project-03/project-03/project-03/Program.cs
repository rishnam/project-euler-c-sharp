using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_3
{
    class Program
    {
        static void Main(string[] args)
        {
            const long number = 600851475143;
            long highestPrimeFactor = 0;
            for (long i = 2; i * i <= number; i++)
            {
                if (number % i == 0)
                {
                    long z = 2;
                    while (i % z != 0 && z <= i / 2)
                    {
                        z++;
                    }
                    if (z > i / 2 && i % (z - 1) != 0)
                    {
                        highestPrimeFactor = i;
                    }

                }
            }
            Console.WriteLine(highestPrimeFactor);
            Console.ReadLine();
        }
    }
}
