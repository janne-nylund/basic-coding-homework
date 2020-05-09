using System;

namespace Exercise
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Dog dog = new Dog();
            dog.Bark();
            dog.Eat();

            Dog barky = new Dog("Barky");
            barky.Bark();

            Console.WriteLine();

            Cat cat = new Cat();
            cat.Purr();
            cat.Eat();

            Cat fatso = new Cat("Fatso");
            fatso.Purr();

            Console.WriteLine();

            INoiseCapable noisyDog = new Dog();
            noisyDog.MakeNoise();

            INoiseCapable noisyCat = new Cat("Noisy");
            noisyCat.MakeNoise();

            Cat c = (Cat)noisyCat;
            c.Purr();
        }
    }
}
