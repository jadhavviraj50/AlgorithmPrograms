using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPrograms
{
    public class BubbleSort
    {
        public void Bubble()
        {
            int[] arr = new int[7] { 1, 5, 7, 8, 6, 5, 9 };
            int temp = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr[i] <= arr[j])
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            Console.WriteLine("After Sorting Array");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("{0},\n", arr[i]);
            }
        }
    }
}
