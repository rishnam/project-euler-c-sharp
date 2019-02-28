using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_2
{
    class Program
    {
        static void Main(string[] args)
        {
            ulong Sum = 0;
            int i = 1;
            while (Fib(i) <= 4000000)
            {
                if (Fib(i) % 2 == 0)
                {
                    Sum = Sum + Fib(i);
                }
                i++;
            }
            Console.WriteLine(Sum);
            Console.ReadLine();
        }
        public static ulong Fib(int n)
        {
            if (n == 1)
            {
                return 1;
            }
            else if (n  == 2)
            {
                return 2;
            }
            else
            {
                return Fib(n - 1) + Fib(n - 2);
            }
        }
    }
}
