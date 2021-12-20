using System;

namespace Stub
{
    public class Stub : ICar
    {
        public string Brand { set; get; }

        public string Model { set; get; }
        public Stub()
        {
            Model = "Aventador";
            Brand = "Lamborghini";
        }
        public void sell()
        {
            Console.WriteLine("Car was sold");
        }
        public void repair()
        {
            Console.WriteLine("Car repaired");
        }
    }
}
