using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_6
{
    class Program
    {
        static void Main(string[] args)
        {
            const double max = 100;
            double squareOfSum = Math.Pow((max / 2.0) * (max + 1), 2);
            double sumOfSquare = 0;

            for (int i = 1; i<=max; i++)
            {
                sumOfSquare = sumOfSquare + Math.Pow(i, 2);
            }
            Console.WriteLine(squareOfSum - sumOfSquare);
            Console.ReadLine();
        }
    }
}
