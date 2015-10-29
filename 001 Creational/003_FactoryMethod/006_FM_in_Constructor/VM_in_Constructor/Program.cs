using System;

namespace VM_in_Constructor
{
    // Продукты ---------------------------------------------------------

    abstract class Product
    {
    }

    class DefaultProduct : Product
    {       
    }

    class SpecialProduct : Product
    {
    }

    // Создатели --------------------------------------------------------

    abstract class Creator
    {
        protected Product product = null;

        public Creator()
        {
            product = FactoryMethod();
            Console.WriteLine(product.GetType().Name);
        }

        // Виртуальный фабричный метод базового класса не вызовется 
        // при его переопределении в производном классе.
        public virtual Product FactoryMethod()
        {
            return new DefaultProduct();
        }
    }

    class ConcreteCreator : Creator
    {
        public ConcreteCreator()
        {
            product = FactoryMethod();
            Console.WriteLine(product.GetType().Name);
        }

        // Переопределение виртуального метода.
        public override Product FactoryMethod()
        {
            return new SpecialProduct();
        }
    }
    
    class Program
    {
        static void Main()
        {
            Creator creator = new ConcreteCreator();

            // В этом примере на экран будет выведено: 
            // SpecialProduct  -  работа конструктора базового класса
            // SpecialProduct  -  работа конструктора производного класса

            // Delay.
            Console.ReadKey();
        }
    }
}
