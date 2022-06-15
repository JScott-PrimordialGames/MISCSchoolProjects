using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalClasses
{
    class Eagle : Animal, IFlyable, IPreditor
    {
        public void Fly()
        {
            Console.WriteLine("Magestic Flight!");
        }

        public void Land()
        {
            Console.WriteLine("Proudly Land");
        }

        public void Pounce()
        {
            Console.WriteLine("Snatched a fish");
        }

        public void Stalk()
        {
            Console.WriteLine("I see you down there.");
        }
    }
}
