using System;
using System.Collections.Generic;

namespace exercise_70
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<int> list = new List<int>();
            while (true)
            {
                int input = Convert.ToInt32(Console.ReadLine());
                if (input == -1)
                {
                    break;
                }
                list.Add(input);
            }
            int greatest = 0;

            for (int index = 0; index < list.Count; index++)
            {
                if (list[index] > greatest)
                {
                    greatest = list[index];
                }
            }
            Console.WriteLine("The greatest number: " + greatest);
        }
    }
}