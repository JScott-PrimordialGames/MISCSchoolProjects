using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalClasses
{
    class Dog : Animal, IDomesticated
    {
        public Dog()
        {
            Console.WriteLine("Dog Constructor. Good puppy.");
        }
        public new void Talk()
        {
            Console.WriteLine("Bark Bark Bark");
        }
        public override void Sing()
        {
            Console.WriteLine("Hooowwwl!");
        }

        public void Fetch(String thing)
        {
            Console.WriteLine("Oh boy. Here is you " + thing + " Let's do it again!");
        }

        public void TouchMe()
        {
            Console.WriteLine("Please scratch behing my ears.");
        }

        public void FeedMe()
        {
            Console.WriteLine("It's suppertime. The bery best time of the day!!!");
        }
    }
}
