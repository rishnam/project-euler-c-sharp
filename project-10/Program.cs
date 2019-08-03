using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_7
{
    class Program
    {
        static long MAX = 2000000;
        static List<long> Numbers = new List<long>();

        public static void Main(string[] args)
        {
            long i = 2;
            long sum = 0;

            Numbers.Add(i);
            sum += i;
            i++;

            do
            {
                if (PrimeCheck(i))
                {
                    Numbers.Add(i);
                    sum += i;
                }
                i += 2;

            } while (i < MAX);

            Console.WriteLine(sum);

            Console.ReadLine();


        }

        public static bool PrimeCheck(long n)
        {

            foreach (long number in Numbers)
            {
                if (Math.Pow(number, 2) > n)
                {
                    break;
                }
                else if (n % number == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
