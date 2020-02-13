using System;

namespace exercise_114
{
    class Program
    {
        public static void Main(string[] args)
        {
            int counter = 0;

            while (true)
            {
                string strings = Console.ReadLine();
                if (strings == "end")
                {
                    break;
                }
                counter++;
            }
            Console.WriteLine(counter);
        }
    }
}