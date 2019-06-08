using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmSystem.Test1
{
    internal class ReleaseAnimal : EventArgs
    {
        private string message;

        public ReleaseAnimal(string message)
        {
            this.message = message;
        }

        // This is a straightforward implementation for 
        // declaring a public field
        public string Message
        {
            get
            {
                return message;
            }
        }
    }
}
