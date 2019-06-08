using System;

namespace FarmSystem.Test1
{
    internal class Horse: Animal, IAnimal
    {       

        public new void Talk()
        {
            Console.WriteLine("Horse says neigh!");
        }

        public new void Run()
        {
            Console.WriteLine("Horse is running");
        }
        
    }
}