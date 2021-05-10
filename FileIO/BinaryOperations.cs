using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileIO
{
    class BinaryOperations
    {
        //serialization
        public static void BinarySerialization()
        {
            Person person = new Person();
            string path = @"C:\Users\K.R.DHASHNIGA\source\repos\FileIO\FileIO\sample.txt";
            BinaryFormatter binary = new BinaryFormatter();
            FileStream file = new FileStream(path, FileMode.OpenOrCreate);
            binary.Serialize(file, person);
        }

        //Deserialization
        public static void BinaryDeserialization()
        {
            Person person = new Person();
            string path = @"C:\Users\K.R.DHASHNIGA\source\repos\FileIO\FileIO\sample.txt";
            BinaryFormatter binary = new BinaryFormatter();
            FileStream file = new FileStream(path, FileMode.Open);
            Person results = (Person)binary.Deserialize(file);
            Console.WriteLine("FirstName \t" + results.FirstName + "\tLastName\t" + results.LastName);
        }
    }

    [Serializable]
    class Person
    {
        public string FirstName { get; set; } = "Shaloo";
        public string LastName { get; set; } = "Singh";

    }
}
