using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyMyExcample
{
    class SelectionSort : Strategy
    {
        public override void Sort(ref int[] array)
        {
            Console.WriteLine("Selection sort");

            for (int i = 0; i < array.Length - 1; i++)
            {
                int k = i;

                for (int j = i + 1; j < array.Length; j++)
                    if (array[k] > array[j])
                        k = j;
                if(k != i)
                {
                    int temp = array[k];
                    array[k] = array[i];
                    array[i] = temp;
                }
            }
        }
    }
}
