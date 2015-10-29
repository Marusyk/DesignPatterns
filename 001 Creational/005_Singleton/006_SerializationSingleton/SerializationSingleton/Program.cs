#define Serialization
//#define Deserialization

using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace SerializationSingleton
{
    class Program
    {
#if Serialization
        static void Main()
        {
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.SurrogateSelector = Singleton.SurrogateSelector;

            // Сериализация.

            FileStream stream = new FileStream("Data.bin", FileMode.Create);
            Singleton singleton = Singleton.Instance;
            singleton.field = "New value";
            formatter.Serialize(stream, singleton);
            stream.Dispose();

            Console.WriteLine("Serialization succeeded");

            // Delay.
            Console.ReadKey();
        }
#endif

#if Deserialization
        static void Main()
        {
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.SurrogateSelector = Singleton.SurrogateSelector;

            // Двойная десериализация.

            Stream stream1 = new FileStream("Data.bin", FileMode.Open);
            Singleton singleton1 = formatter.Deserialize(stream1) as Singleton;
            stream1.Dispose();

            Stream stream2 = new FileStream("Data.bin", FileMode.Open);
            Singleton singleton2 = formatter.Deserialize(stream2) as Singleton;
            stream2.Dispose();

            // Проверка двойной десериализации.

            Console.WriteLine(singleton1.GetHashCode());
            Console.WriteLine(singleton2.GetHashCode());

            Console.WriteLine(singleton1.field);
            Console.WriteLine(singleton2.field);

            // Delay.
            Console.ReadKey();
        }
#endif
    }
}
