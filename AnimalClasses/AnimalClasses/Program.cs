using System;

namespace AnimalClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Animal beast = new Animal();

            beast.Talk();
            beast.Greet();
            beast.Sing();
            */

            Dog bowser = new Dog();

            bowser.Talk();
            bowser.Greet();
            bowser.Sing();
            bowser.Fetch("stick");
            bowser.FeedMe();
            bowser.TouchMe();

            Robin red = new Robin();

            red.Talk();
            red.Greet();
            red.Sing();

            Console.ReadLine();

            Lion leo = new Lion();
            leo.Pounce();
            leo.Stalk();

            Falcon falco = new Falcon();
            falco.Fly();
            falco.Land();

            Eagle majestic = new Eagle();
            majestic.Fly();
            majestic.Land();
            majestic.Stalk();
            majestic.Pounce();
        }
    }
}
