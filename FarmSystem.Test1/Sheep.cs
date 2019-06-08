using System;

namespace FarmSystem.Test1
{
    internal class Sheep: Animal, IAnimal
    {  
        public void Talk()
        {
            Console.WriteLine("Sheep says baa!");
        }
        
        public void Run()
        {
            Console.WriteLine("Sheep is running");
        }
    }

}