using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalClasses
{
    class Lion : Animal, IPreditor
    {
        public void Pounce()
        {
            Console.WriteLine("I got you!");
        }

        public void Stalk()
        {
            Console.WriteLine("Sneaking Sneaking Sneaking");
        }
    }
}
