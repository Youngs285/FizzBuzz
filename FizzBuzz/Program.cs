﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 101; i++)
            {
                if (i % 3 == 0)
                {
                    Console.Write(" ");
                    Console.Write("Fizz");
                }

                if (i % 5 == 0)
                {
                    Console.Write(" ");
                    Console.Write("Buzz");
                }

                if (i % 3 != 0 || i % 5 != 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
