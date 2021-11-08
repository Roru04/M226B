using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;


namespace SerializerJson
{
    class Program
    {
        public static string FileNameDog { get; set; } = @"D:/Schule/M226B/Repo/SerializerJson/Daten/Dog/dog.json";
        public static string FileNameLion { get; set; } = @"D:/Schule/M226B/Repo/SerializerJson/Daten/Lion/lion.json";
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




                    JsonSerializer serializer = new JsonSerializer();

                    using (StreamWriter sw = new StreamWriter(FileNameDog))
                    using (JsonWriter writer = new JsonTextWriter(sw))
                    {
                        serializer.Serialize(writer, dogs);

                    }




                }
                else if (option == "lion")
                {
                    Lion lion = new Lion();

                    Console.WriteLine("Enter the Toothlenght of the lion");

                    lion.toothlength = Convert.ToInt32(Console.ReadLine());

                    lion.Greet();

                    lions.Add(lion);

                    JsonSerializer serializer = new JsonSerializer();

                    using (StreamWriter sw = new StreamWriter(FileNameLion))
                    using (JsonWriter writer = new JsonTextWriter(sw))
                    {
                        serializer.Serialize(writer, lions);

                    }


                }
                else
                {
                    Animal animal = new Animal();

                    animal.Greet();


                }



                try

                {
                    using (StreamReader file = File.OpenText(FileNameDog))
                    {
                        JsonSerializer serializer = new JsonSerializer();
                        List<Dog> DogsRead = (List<Dog>)serializer.Deserialize(file, typeof(List<Dog>));

                        Console.WriteLine("Name of Dogs");
                        foreach (Dog dog in DogsRead)
                        {
                            Console.WriteLine(dog.Name);
                        }
                    }



                }
                catch (Exception ex)
                {
                    Console.WriteLine("No Dogs");
                }


                try

                {
                    using (StreamReader file = File.OpenText(FileNameLion))
                    {
                        JsonSerializer serializer = new JsonSerializer();
                        List<Lion> lionsRead = (List<Lion>)serializer.Deserialize(file, typeof(List<Lion>));

                        Console.WriteLine("Toothlenght of Lions");
                        foreach (Lion lion in lionsRead)
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


