namespace exercise_133
{
    public class Money
    {

        private int euros;
        private int cents;

        public Money(int euros, int cents)
        {
            if (cents > 99)
            {
                euros = euros + cents / 100;
                cents = cents % 100;
            }

            this.euros = euros;
            this.cents = cents;
        }

        public Money Plus(Money addition)
        {
            // create a new Money object that has the correct worth
            Money newMoney = new Money(this.euros, this.cents);
            newMoney.euros += addition.euros;
            if (newMoney.cents + addition.cents > 100)
            {
                newMoney.cents = (newMoney.cents + addition.cents) - 100;
                newMoney.euros++;
            }
            else
            {
              newMoney.cents += addition.cents;
            }
            // return the new Money object
            return newMoney;
        }

        public Money Minus(Money decreaser)
        {
            Money newMoney = new Money(this.euros, this.cents);
            // create a new Money object that has the correct worth

            if (newMoney.cents - decreaser.cents < 0)
            {
                newMoney.cents = 100 - (decreaser.cents - newMoney.cents);
                newMoney.euros--;
                newMoney.euros -= decreaser.euros;
            }
            else
            {
                newMoney.cents -= decreaser.cents;
                newMoney.euros -= decreaser.euros;
            }

            if (newMoney.euros < 0)
            {
                newMoney.euros = 0;
                newMoney.cents = 0;
            }
            // return the new Money object
            return newMoney;
        }

        public bool LessThan(Money compared)
        {
            if (this.euros < compared.euros)
            {
                return true;
            }
            else if (this.euros == compared.euros && this.cents < compared.cents)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public override string ToString()
        {
            string zero = "";
            if (cents < 10)
            {
                zero = "0";
            }

            return euros + "." + zero + cents + "e";
        }
    }
}