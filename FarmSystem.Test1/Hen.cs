using System;

namespace FarmSystem.Test1
{
    internal class Hen: Animal, IAnimal
    {
        public new void Talk()
        {
            Console.WriteLine("Hen say CLUCKAAAAAWWWWK!");
        }

        public new void Run()
        {
            Console.WriteLine("Hen is running");
        }
    }
}