using System;
using System.Collections.Generic;

namespace Exercise
{

    public class Program
    {
        public static void Main(string[] args)
        {
            Student first = new Student("jamo");
            Student second = new Student("jamo1");

            // Should print -1
            Console.WriteLine(second.CompareTo(first));
        }
    }
}
