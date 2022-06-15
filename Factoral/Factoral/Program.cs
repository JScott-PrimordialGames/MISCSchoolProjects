using System;

namespace Factoral
{
    class Program
    {
        static void Main(string[] args)
        {
            int startingNumber = 9999;
            Console.Out.WriteLine(factoral(startingNumber));
            Console.ReadLine();
        }

        static int factoral(int x)
        {
            Console.Out.WriteLine("x is {0}", x);
            if(x == 1)
            {
                return 1;
            }
            else
            {
                return x * factoral(x - 1);
            }
        }
    }
}
