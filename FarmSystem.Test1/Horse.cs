using System;

namespace FarmSystem.Test1
{
    internal class Horse: Animal, IAnimal
    {       

        public void Talk()
        {
            Console.WriteLine("Horse says neigh!");
        }

        public void Run()
        {
            Console.WriteLine("Horse is running");
        }
        
    }
}