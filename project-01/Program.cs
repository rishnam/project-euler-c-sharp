﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_01
{
    class Program
    {
        static void Main(string[] args)
        {
            int Sum = 0;
            for (int i = 1; i < 1000; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    Sum = Sum + i;
                }
            }
            Console.WriteLine(Sum);
            Console.ReadLine();
        }
    }
}
