using System;
using System.Collections.Generic;

namespace Exercise
{
  public class Hand : IComparable<Hand>
    {
        private List<Card> hand;

        public Hand()
        {
            this.hand = new List<Card>();
        }

        public void Add(Card card)
        {
            if (!this.hand.Contains(card))
            {
                this.hand.Add(card);
            }
        }

        public void Print()
        {
            foreach (Card item in this.hand)
            {
                Console.WriteLine(item.ToString());
            }
        }

        public void Sort()
        {
            this.hand.Sort();
        }

        public int CompareTo(Hand hand)
        {
            int sum = 0;
            foreach (Card item in this.hand)
            {
                sum += item.value;
            }

            int sumComp= 0;
            foreach (Card item in hand.hand)
            {
                sumComp += item.value;
            }

            return sum - sumComp;
        }
  }
}