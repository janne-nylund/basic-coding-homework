using System;
using System.Collections.Generic;

namespace exercise_69
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
            Console.WriteLine("From where?");
            int start = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Where to?");
            int end = Convert.ToInt32(Console.ReadLine());

            for (int index = 0; index < list.Count; index++)
            {
                if (list[index] >= start && list[index] <= end)
                {
                    Console.WriteLine(list[index]);
                }
            }

        }
    }
}