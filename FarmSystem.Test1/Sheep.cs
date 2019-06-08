using System;

namespace FarmSystem.Test1
{
    internal class Sheep: Animal, IAnimal
    {  
        public new void Talk()
        {
            Console.WriteLine("Sheep says baa!");
        }
        
        public new void Run()
        {
            Console.WriteLine("Sheep is running");
        }
    }

}