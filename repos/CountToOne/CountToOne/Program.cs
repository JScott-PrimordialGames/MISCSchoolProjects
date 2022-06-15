﻿using System;
using System.Net;

namespace CountToOne
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Out.Write("Please enter an integer. I will do some mat and eventually arrive at 1 ");
            int startingNumber = int.Parse(Console.ReadLine());
            int x = countdownToOne(startingNumber);
            Console.ReadLine();
        }

        static public int countdownToOne(int n)
        {
            Console.Out.WriteLine("N is {0}", n);
            if(n == 1)
            {
                return 1;
            }
            else
            {
                if(n % 2 == 0)
                {
                    Console.Out.WriteLine("N is even. Divide by 2");
                    return countdownToOne(n / 2);
                }
                else
                {
                    Console.Out.WriteLine("N is odd. Add 1");
                    return countdownToOne(n + 1);
                }         
            }
        }
    }
}
