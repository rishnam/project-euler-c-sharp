using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable threeDigitFactors = new Hashtable();
            int y = 1;
            for (int i = 999 * 999; i>= 100*100; i--)
            {
                string number = i.ToString();
                string reverse = "";
                for (int z = number.Length - 1; z>=0; z--)
                {
                    reverse = String.Concat(reverse, number[z]);
                }
                if (number == reverse) // thats a palindrome number
                {
                    for (int x = 1; x <= i/2; x++) // look at its factors
                    {
                        string factors = x.ToString();
                        if (i % x == 0 && factors.Length == 3)
                        {
                            threeDigitFactors.Add(y, x);
                            y++;
                            int s = x;
                            int b = i / s;
                            if (threeDigitFactors.ContainsValue(b))
                            {
                                Console.WriteLine(" The largest palindrome is: {0} = {1} * {2}", i, s, b);
                                Console.ReadLine();
                                Environment.Exit(0);
                            }
                        }
                    }
                     
                }
                threeDigitFactors.Clear();
            }
            Console.ReadLine();
        }
    }
}
