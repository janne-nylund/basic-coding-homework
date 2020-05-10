using System;
using System.Collections.Generic;

namespace Exercise
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Hand hand1 = new Hand();

            hand1.Add(new Card(11, Suit.Heart));
            hand1.Add(new Card(11, Suit.Heart));
            hand1.Add(new Card(11, Suit.Heart));

            Hand hand2 = new Hand();

            hand2.Add(new Card(11, Suit.Diamond));
            hand2.Add(new Card(11, Suit.Diamond));
            hand2.Add(new Card(11, Suit.Diamond));

            int comparison = hand1.CompareTo(hand2);

            if (comparison < 0)
            {
                Console.WriteLine("better hand is");
                hand2.Print();
            }
            else if (comparison > 0)
            {
                Console.WriteLine("better hand is");
                hand1.Print();
            }
            else
            {
                Console.WriteLine("hands are equal");
            }
        }
    }
}
