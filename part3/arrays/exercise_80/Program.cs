using System;
using System.Collections.Generic;

namespace exercise_80
{
    class Program
    {
        public static void Main(string[] args)
        {
            int[] numbers = { 5, 1, 3, 4, 2 };
            int sumOfArray = SumOfNumbersInArray(numbers);
            Console.WriteLine(sumOfArray);

        }

        public static int SumOfNumbersInArray(int[] numbers)
        {
            int sumOfArray = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sumOfArray += numbers[i];
            }
            return sumOfArray;
        }

    }
}


