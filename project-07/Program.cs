using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 1;
            int count = 0;
            while (count != 1001)
            {
                number++;
                if (PrimeCheck(number)) // prime
                {
                    count++;
                }
                
            }
            Console.WriteLine(number);

            Console.ReadLine();
        }
        static bool PrimeCheck(int num)
        {
            for (int i = 2; i < num; i++)
            {
                if (num % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

    }
}
