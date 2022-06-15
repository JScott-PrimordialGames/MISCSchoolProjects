using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalClasses
{
    class Robin : Animal
    {

        public virtual void Sing()
        {
            Console.WriteLine("Chirp Chirp");
        }
    }
}
