using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5
{
    public class Books
    {
        public string BookName { get; set; }
        public string AuthorName { get; set; }

        public Books(string bookName, string authorName)
        {
            BookName = bookName;
            AuthorName = authorName;
        }

        public void Display()
        {
            Console.WriteLine($"Book Name: {BookName}, Author Name: {AuthorName}");
        }
    }

    public class BookShelf
    {
        private List<Books> books;

        // Constructor to initialize the list to store books (composition)
        public BookShelf()
        {
            books = new List<Books>();
        }

        // Method to add a book to the shelf (aggregation)
        public void AddBook(Books book)
        {
            if (books.Count < 5)
            {
                books.Add(book);
            }
            else
            {
                Console.WriteLine("Bookshelf is full. Cannot add more than 5 books.");
            }
        }

        public Books this[int index]
        {
            get
            {
                if (index >= 0 && index < books.Count)
                {
                    return books[index];
                }
                else
                {
                    Console.WriteLine("Index out of range. Please provide an index between 0 and 4.");
                    return null;
                }
            }
        }

        public void DisplayBooks()
        {
            foreach (var book in books)
            {
                if (book != null)
                {
                    book.Display();
                }
                else
                {
                    Console.WriteLine("No book at this index.");
                }
            }
        }
    }

    public class Program1
    {
        public static void Main()
        {
            BookShelf bs = new BookShelf();

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Enter details for book {i + 1}:");

                Console.Write("Book Name: ");
                string bookName = Console.ReadLine();

                Console.Write("Author Name: ");
                string authorName = Console.ReadLine();

                Books book = new Books(bookName, authorName); // Books can exist independently (aggregation)
                bs.AddBook(book); // Adding books to the shelf (composition)
            }

            Console.WriteLine("\nBooks on the shelf:");
            bs.DisplayBooks();

            Console.Read();
        }
    }
}
