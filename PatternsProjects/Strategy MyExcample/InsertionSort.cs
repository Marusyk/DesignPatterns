using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyMyExcample
{
    class InsertionSort : Strategy
    {
        public override void Sort(ref int[] array)
        {
            Console.WriteLine("Insertion sort");

            for (int i = 1; i < array.Length; i++)
            {
                int j = 0;
                int buffer = array[i];

                for (j = i -1; j >=0; j--)
                {
                    if (array[j] < buffer)
                        break;
                    array[j + 1] = array[j];
                }

                array[j + 1] = buffer;
            }
        }
    }
}
