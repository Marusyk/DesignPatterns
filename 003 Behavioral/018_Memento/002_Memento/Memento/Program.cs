using System;

namespace Memento
{
    class Program
    {
        static void Main()
        {
            Man David = new Man();
            Robot ASIMO = new Robot();

            David.�lothes = "��������, ������, ����";

            ASIMO.Backpack = David.Undress();

            David.�lothes = "����� ����������";

            David.Dress(ASIMO.Backpack);
        }
    }
}
