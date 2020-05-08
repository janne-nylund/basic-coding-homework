namespace Exercise
{
   public class Student : Person
    {
        public int credits { get; set; }
        public Student(string personName, string personAddress) : base(personName, personAddress)
        {
            this.credits = credits;
        }

        public void Study()
        {
            this.credits++;
        }

        public override string ToString()
        {
            return base.ToString() + " credits: " + this.credits;
        }
    }
}