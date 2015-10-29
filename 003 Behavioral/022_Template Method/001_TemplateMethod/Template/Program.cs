using System;

namespace Template
{
    class Program
    {
        static void Main()
        {
            AbstractClass instance = new ConcreteClass();
            instance.TemplateMethod();
        }
    }
}
