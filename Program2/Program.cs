using System;
using System.ComponentModel.Design;

namespace SortingNumbers
{
    class Program2
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of elements: ");
            int numElements = Convert.ToInt32(Console.ReadLine());

            float[] numbers = new float[numElements];

            Console.Write("Enter the elements separagted by space: ");
            string[] inputNumbers = Console.ReadLine().Split(' ');

            for (int i = 0; i < numElements; i++)
            {
                numbers[i] = float.Parse(inputNumbers[i]);
            }

            SelectionSort(numbers);

            Console.Write("Sorted numbers: ");
            for (int i = 0; i < numElements; i++)
            {
                Console.Write(numbers[i] + " ");
            }
            Console.ReadLine();
        }

        private static void SelectionSort(float[] numbers)
        {
            int minIndex;

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                minIndex = i;

                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[j] < numbers[minIndex])
                    {
                        minIndex = j;
                    }
                }

                Swap(ref numbers[minIndex], ref numbers[i]);
            }
        }

        private static void Swap(ref float a, ref float b)
        {
            float temp = a;
            a = b;
            b = temp;
        }
    }
}

