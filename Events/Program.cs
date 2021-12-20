using Events.Classes;
using Events.EventArgs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Events
{
    class Program
    {
        static void Main(string[] args)
        {
            Ferrari someFerrari = new Ferrari("Harley", 69);
            someFerrari.Drive += GoOnDrive;

            Console.WriteLine("Before Explosion");

            someFerrari.StepOnGas();

            Console.WriteLine("After Explosion\n\n");

            IEnumerable<Ferrari> allFerraris = new List<Ferrari>(5);

            for (int i = 300; i < 550; i+=50)
            {
                Ferrari ferrari = new Ferrari($"Ferrari: {i - 167}",i );

                allFerraris = allFerraris.Append(ferrari).ToList();
            }

            foreach (Ferrari bombFromList in
                     allFerraris
                         .Where(x => x.HorsePower > 300)
                         .OrderBy(x => x.Model))
            {
                bombFromList.Drive += GoOnDrive;
                bombFromList.StepOnGas();
            }

            void GoOnDrive(object sender, CarEventArgs args)
            {
                Ferrari senderFerrari = sender as Ferrari;
                
                if(sender == null)
                {
                    throw new ArgumentNullException("sender was null");
                }
                else
                {
                    Console.WriteLine($"Car {senderFerrari?.Model} has been driven:");
                    Console.WriteLine($"HP: \t {args.HP}");
                }

                
            }
        }
    }
}
