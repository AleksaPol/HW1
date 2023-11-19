using System;
using System.Collections.Immutable;
using System.Linq.Expressions;
using System.Runtime.Serialization.Formatters;

namespace tsk
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers1 = { 8, 0, 5, 1, 3, 2, 9, 7 };
            int[] numbers2 = { 16, 91, 54, 62, 11, 29, 33, 81 };

            //task1 императивный стиль
            void imperativSort(int[] arr)
            {
                int lenArr = arr.Length;
                int index = 0;
                for (int i = 0; i < lenArr; i++)
                {
                    int tempMax = arr[i];
                    for (int j = i; j < lenArr; j++)
                    {
                        if (arr[j] > tempMax)
                        {
                            tempMax = arr[j];
                            index = j;  
                        }
                    }
                    arr[index] = arr[i];
                    arr[i] = tempMax;
                }
            }

            void consoleArray(int[] arr)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.Write(arr[i] + " ");
                }
            }

            //task2 декларативный стиль
            void declarativSort(int[] arr)
            {
                Array.Sort(arr, (i1, i2) => i2.CompareTo(i1));
            }

            imperativSort(numbers1);
            consoleArray(numbers1);
            Console.WriteLine();
            declarativSort(numbers2);
            consoleArray(numbers2);
        }
    }
}