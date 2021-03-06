namespace Exercise
{
    using System;
    using System.Collections.Generic;
    public class TextInterface
    {
        // Create the userinterface here
        private List<Book> books;
        public TextInterface()
        {
            this.books = new List<Book>();
        }

        public void Start()
        {
            while (true)
            {
                Console.WriteLine("Input the name of the book, empty stops:");
                string name = Console.ReadLine();
                if (name == "")
                {
                    break;
                }
                Console.WriteLine("Input the age recommendation:");
                string input = Console.ReadLine();
                if (input == "")
                {
                    break;
                }
                int age = Convert.ToInt32(input);
                this.books.Add(new Book(name, age));
            }
            Console.WriteLine(books.Count + " books in total.\n\nBooks:");
            books.Sort();
            foreach (Book item in this.books)
            {
                Console.WriteLine(item);
            }
        }
    }
}