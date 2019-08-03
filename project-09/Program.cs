using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_9
{
    class Program
    {
        static void Main(string[] args)
        {

            pythagoreanTriplets(1000);
            Console.ReadLine();
        }
        static void pythagoreanTriplets(int limit)
        {
 
            int a, b, c = 0;
            int m = 2;
            while (c < limit)
            {
                for (int n = 1; n < m; ++n)
                {
                    a = m * m - n * n;
                    b = 2 * m * n;
                    c = m * m + n * n;

                    if (c > limit)
                        break;


                    if (a+b+c == 1000)
                    {
                        Console.WriteLine("{0},{1},{2}", a, b, c);

                        Console.WriteLine(a * b * c);
                    }
                    
                }
                m++;
            }
        }
    }
}
