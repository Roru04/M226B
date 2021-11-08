using System;
using System.Collections.Generic;
using System.Text;

namespace Serializer
{
    [Serializable]
    class Lion : Animal
    {
        public int toothlength { get; set; }

        public override void Greet()
        {
            Console.WriteLine("Hello im a Lion");
        }
    }
}
