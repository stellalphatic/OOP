using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week4
{
    internal class Program
    {
        static Book[] books = new Book[100];
        static int bookCount = 0;
        static void BookDriver()
        {
            int opt = 0;
       
            while (true)
            {
                Console.WriteLine("1. Add a Book");
                Console.WriteLine("2. Search a book by title");
                Console.WriteLine("3. Search a book by ISBN");
                Console.WriteLine("4. Update no. of copies");
                Console.WriteLine("5. Quit");
                Console.Write("Enter your choice: ");
                opt=int.Parse(Console.ReadLine());
                if (opt == 1)
                    AddBook();
                if (opt == 2)
                    SearchByTitle();
                if (opt == 3)
                    SearchByISBN();
                if(opt==4)

                if (opt == 5)
                    break;
            }


        }
        static void SearchByTitle()
        {
            Console.Write("Enter Book title to search: ");
            string searchTitle = Console.ReadLine();

            foreach (var book in books)
            {
                if (book != null && book.showTitle()==searchTitle)
                {
                    Console.WriteLine("Book Found!");
                    book.DisplayBook();
                    return;
                }
            }
            Console.WriteLine("Book not found");
        }

        static void SearchByISBN()
        {
            Console.Write("Enter ISBN to Search: ");
            string searchISBN = Console.ReadLine();

            foreach (var book in books)
            {
                if (book != null && book.GetISBN()==searchISBN)
                {
                    Console.WriteLine("Book Found!");
                    book.DisplayBook();
                    return;
                }
            }
            Console.WriteLine("Book not found\n");
        }
        static void Main(string[] args)
        {
            BookDriver();
           
        }
        static void AddBook()
        {
            Console.Write("Enter Book Title: ");
            string title = Console.ReadLine();

            Console.Write("Enter Number of Authors: ");
            int authorNum=5;
            while (authorNum > 4)
            {
                 authorNum = int.Parse(Console.ReadLine());
            }
            string[] authors = new string[authorNum];

            for (int i = 0; i < authorNum; i++)
            {
                Console.Write($"Enter Author {i + 1} Name: ");
                authors[i] = Console.ReadLine();
            }

            Console.Write("Enter Publisher: ");
            string publisher = Console.ReadLine();

            Console.Write("Enter ISBN: ");
            string isbn = Console.ReadLine();

            Console.Write("Enter Price: ");
            double price = double.Parse(Console.ReadLine());

            Console.Write("Enter Stock Quantity: ");
            int stock = int.Parse(Console.ReadLine());

            books[bookCount++] = new Book(title, authors, publisher, isbn, price, stock);
            Console.WriteLine("Book added successfully!\n");
        }

    }
}
