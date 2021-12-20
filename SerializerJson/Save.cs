using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;


namespace SerializerJson
{
    public static class Save
    {
        public static void SaveInClass(Dog animal, List<Dog> list, string filenameDog)
        {
            JsonSerializer serializer = new JsonSerializer();

            

                using (StreamWriter sw = new StreamWriter(filenameDog))
                using (JsonWriter writer = new JsonTextWriter(sw))
                {
                    serializer.Serialize(writer, list);

                }
            
           
        }


        public static void SaveInClass(Lion animal, List<Lion> list, string filenameLion)
        {
            JsonSerializer serializer = new JsonSerializer();

            
            
            
                using (StreamWriter sw = new StreamWriter(filenameLion))
                using (JsonWriter writer = new JsonTextWriter(sw))
                {
                    serializer.Serialize(writer, list);

                }
            
        }
    }
}
