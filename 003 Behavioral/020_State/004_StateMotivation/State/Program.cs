using System;

namespace State
{
    class Program
    {
        static void Main()
        {
            var father = new Father();

            while (true)
            {
                Mark mark = (Mark)Enum.Parse(typeof(Mark), Console.ReadLine());

                if (mark == Mark.Two || mark == Mark.Five)
                    father.FindOut(mark);
            }
        }
    }
}
