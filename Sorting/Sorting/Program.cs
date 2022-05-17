using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    internal class Program
    {

        public static void sorter(int[] array)
        {

        }
        static void ain(string[] args)
        {
            int[] array = { 21, 42, 12, 62, 31, 213, 53, 13, 64, 222, 6, 1 };

            for (int j = 0; j < array.Length - 1; j++)
            {
                for (int i = j + 1; i < array.Length; i++)
                {
                    int num1 = array[j];
                    int num2 = array[i];

                    if (num1 >= num2)
                    {
                        int tempINT = array[j];
                        array[j] = array[i];
                        array[i] = tempINT;
                    }
                }


            }

            for (int j = 0; j < array.Length; j++)
            {
                Console.WriteLine(array[j]);
            }
            Console.ReadLine();
        }
    }
}
