using System;
using System.Collections.Generic;
using System.Text;

namespace SerializerJson
{
    [Serializable]
    public class Dog : Animal
    {
        public string Name { get; set; }


        public override void Greet()
        {
            Console.WriteLine("Hello im a dog");
        }

    }
}
