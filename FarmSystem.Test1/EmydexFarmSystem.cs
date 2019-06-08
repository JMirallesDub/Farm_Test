using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;

namespace FarmSystem.Test1
{
    public class EmydexFarmSystem
    {
        //List<IAnimal> animals = new List<IAnimal>();
        private ObservableCollection<IAnimal> _includeAnimals;
        public EmydexFarmSystem()
        {
            _includeAnimals = new ObservableCollection<IAnimal>();
        }
        public ObservableCollection<IAnimal> IncludeAnimals
        {
            get { return _includeAnimals; }
        }

        //TEST 1
        public void Enter(IAnimal animal)
        {
            //TODO Modify the code so that we can display the type of animal (cow, sheep etc) 
            //Hold all the animals so it is available for future activities
            _includeAnimals.Add(animal);
            Console.WriteLine(animal.GetType().Name + " has entered the Emydex farm");
        }
     
        //TEST 2
        public void MakeNoise()
        {
            //Test 2 : Modify this method to make the animals talk
            foreach (IAnimal animal in _includeAnimals)
            {
                animal.Talk();

            }
        }

        //TEST 3
        public void MilkAnimals(IMilkableAnimal milkableAnimal)
        {
            //Console.WriteLine("Cannot identify the farm animals which can be milked");
            foreach (IAnimal animal in _includeAnimals)
            {
                if (animal is IMilkableAnimal)
                {
                    Console.WriteLine(animal.GetType().Name + " was milked!");
                }
            }
        }

        //TEST 4
        internal void ReleaseAllAnimals()
        {
            //foreach (IAnimal animal in _includeAnimals)
            //{
            //    Console.WriteLine(animal.GetType().Name + " has left the farm");
            //    _includeAnimals.Remove(animal);
            //}
            int includeAnimalsCount = _includeAnimals.Count;
            _includeAnimals.CollectionChanged += IncludeAnimals_CollectionClear;
            for (int i = _includeAnimals.Count - 1; i >= 0; i--)
            {
                Console.WriteLine(_includeAnimals[i].GetType().Name + " has left the farm");
                _includeAnimals.Remove(_includeAnimals[i]);
                
            }

        }

        private void IncludeAnimals_CollectionClear(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (_includeAnimals.Count == 0)
            {
                Console.WriteLine("Emydex Farm is now empty");
            }
        }

    }


}

