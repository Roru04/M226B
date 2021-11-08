using System;
using System.Collections.Generic;
using System.Text;

namespace SerializerJson
{
    [Serializable]
    public class Animal
    {
        private string weight;


        public virtual void Greet()
        {
            Console.WriteLine("Hello I am an undiscovered animal");
        }
    }
}
