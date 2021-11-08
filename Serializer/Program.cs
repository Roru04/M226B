using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace Serializer
{
    class Program
    {
        public static string FileNameDog { get; set; } = @"D:/Schule/M226B/Repo/Serializer/Daten/Dogs/dog.bin";
        public static string FileNameLion { get; set; } = @"D:/Schule/M226B/Repo/Serializer/Daten/Lions/lion.bin";
        private static bool isRunning = true;
        private static string option;

        static void Main(string[] args)
        {
            List<Dog> dogs = new List<Dog>();
            List<Lion> lions = new List<Lion>();
            while (isRunning)
            {


                Console.WriteLine("Is animal Dog or lion ");

                option = Console.ReadLine();
                if (option.ToLower() == "dog")
                {
                    Dog dog = new Dog();

                    Console.WriteLine("Enter the Name of the dog");

                    dog.Name = Console.ReadLine();

                    dog.Greet();

                    dogs.Add(dog);

                    using (FileStream fileStreamWrite = new FileStream(FileNameDog, FileMode.Create, FileAccess.ReadWrite))
                    {
                        IFormatter bf = new BinaryFormatter();

                        bf.Serialize(fileStreamWrite, dogs);


                    }




                }
                else if (option == "lion")
                {
                    Lion lion = new Lion();

                    Console.WriteLine("Enter the Toothlenght of the lion");

                    lion.toothlength = Convert.ToInt32(Console.ReadLine());

                    lion.Greet();

                    lions.Add(lion);

                    using (FileStream fileStreamWrite = new FileStream(FileNameLion, FileMode.Create, FileAccess.ReadWrite))
                    {
                        IFormatter bf = new BinaryFormatter();

                        bf.Serialize(fileStreamWrite, lions);


                    }

                }
                else
                {
                    Animal animal = new Animal();

                    animal.Greet();


                }


                using (FileStream fileStreamWrite = new FileStream(FileNameDog, FileMode.Open))
                {
                    IFormatter bf = new BinaryFormatter();

                    List<Dog> dogsRead = (List<Dog>)bf.Deserialize(fileStreamWrite);

                    Console.WriteLine("Names of Dogs:");

                    foreach (Dog dog in dogsRead)
                    {
                        Console.WriteLine(dog.Name);
                    }


                }


                try

                {
                    using (FileStream fileStreamWrite = new FileStream(FileNameLion, FileMode.Open))
                    {
                        IFormatter bf = new BinaryFormatter();

                        List<Lion> LionsRead = (List<Lion>)bf.Deserialize(fileStreamWrite);

                        Console.WriteLine("toothlenght of Lions:");

                        foreach (Lion lion in LionsRead)
                        {
                            Console.WriteLine(lion.toothlength);
                        }

                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("No lions");
                }



            }



        }
    }
}

