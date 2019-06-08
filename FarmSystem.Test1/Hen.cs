using System;

namespace FarmSystem.Test1
{
    internal class Hen: Animal, IAnimal
    {
        public void Talk()
        {
            Console.WriteLine("Hen say CLUCKAAAAAWWWWK!");
        }

        public void Run()
        {
            Console.WriteLine("Hen is running");
        }
    }
}