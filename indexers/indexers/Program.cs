using System;
namespace Indexers
{
    public class BookCollection
    {
        private string[] books = new string[3]; // An array to hold book titles

        // Indexer for accessing book titles by index
        public string this[int index]
        {
            get
            {
                if (index >= 0 && index < books.Length)
                    return books[index]; // Return the book at the given index
                else
                    return "Invalid index";
            }
            set
            {
                if (index >= 0 && index < books.Length)
                    books[index] = value; // Set the book title at the given index
                else
                    Console.WriteLine("Invalid index");
            }
        }
    }

    class Program
    {
        static void Main()
        {
            BookCollection myBooks = new BookCollection(); //object create

            // Adding book titles using the indexer
            myBooks[0] = "Geeta";
            myBooks[1] = "Harry Potter";
            myBooks[2] = "Its End With Us";

            // Accessing book titles using the indexer
            Console.WriteLine($"Book at index 0: {myBooks[0]}"); // Output: Geeta
            Console.WriteLine($"Book at index 1: {myBooks[1]}"); // Output: Harry Potter
            Console.WriteLine($"Book at index 2: {myBooks[2]}"); // Output: It ends with Us

            // Trying to access an invalid index
            Console.WriteLine(myBooks[3]); // Output: Invalid index
        }
    }
}
