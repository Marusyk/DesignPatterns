using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyMyExcample
{
    class BubbleSort : Strategy
    {
        public override void Sort(ref int[] array)
        {
            Console.WriteLine("Bubble sort");

            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = array.Length - 1; j > i; j--)
                {
                    int temp = array[j];
                    array[j] = array[j - 1];
                    array[j - 1] = temp;
                }
            }
        }
    }
}
