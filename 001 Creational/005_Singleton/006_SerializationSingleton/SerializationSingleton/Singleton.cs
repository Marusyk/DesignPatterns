using System;
using System.Runtime.Serialization;

namespace SerializationSingleton
{
    // Класс Singleton не должен сериализовываться напрямую и не должен иметь атрибута [Serializable]! 
    public sealed class Singleton
    {
        private static Singleton instance = null;
        public String field = "Some value";
        public static Singleton Instance
        {
            get { return (instance == null) ? instance = new Singleton() : instance; }
        }
        public static SurrogateSelector SurrogateSelector
        {
            get
            {
                var selector = new SurrogateSelector();
                var singleton = typeof(Singleton);
                var context = new StreamingContext(StreamingContextStates.All);
                var surrogate = new SerializationSurrogate();

                selector.AddSurrogate(singleton, context, surrogate);
                return selector;
            }
        }

        // Nested class

        private sealed class SerializationSurrogate : ISerializationSurrogate
        {
            // Метод вызывается для сериализации объекта типа Singleton
            void ISerializationSurrogate.GetObjectData(Object obj, SerializationInfo info, StreamingContext context)
            {
                Singleton singleton = Singleton.Instance;
                info.AddValue("field", singleton.field);
            }

            // Метод вызывается для десериализации объекта типа Singleton
            Object ISerializationSurrogate.SetObjectData(Object obj, SerializationInfo info, StreamingContext context, ISurrogateSelector selector)
            {
                Singleton singleton = Singleton.Instance;
                singleton.field = info.GetString("field");
                return singleton;
            }
        }
    }
}
