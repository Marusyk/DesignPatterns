using System;

namespace Memento
{
    class Program
    {
        static void Main()
        {
            Man David = new Man();
            Robot ASIMO = new Robot();

            David.Сlothes = "Футболка, Джинсы, Кеды";

            ASIMO.Backpack = David.Undress();

            David.Сlothes = "Шорты спортивные";

            David.Dress(ASIMO.Backpack);
        }
    }
}
