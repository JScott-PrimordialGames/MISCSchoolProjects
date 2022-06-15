using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalClasses
{
    class Falcon : Animal, IFlyable
    {
        public void Fly()
        {
            Console.WriteLine("I soar through the sky");
        }

        public void Land()
        {
            Console.WriteLine("Resting my wings");
        }
    }
}
