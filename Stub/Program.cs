using System;

namespace Stub
{
    public class Program
    {
        public void main(string[] args)
        {
            Stub Lambo = new Stub();
            Console.WriteLine(Lambo.Brand, Lambo.Model);
            Lambo.sell();
            Lambo.repair();
        }
    }
}
