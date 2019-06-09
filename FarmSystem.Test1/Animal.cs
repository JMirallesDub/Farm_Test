using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmSystem.Test1
{
    class Animal: IAnimal
    {
        public string Id { get; set; }
        public int NoOfLegs { get; set; } = 4;

        public void Run()
        {
        }

        public virtual void Talk()
        {
        }
    }
}
