using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week4
{
    internal class Book
    {
         string title;
         string[] authors;
         string publisher;
         string ISBN;
         double price;
         int numberOfCopies;
         int authorCount;
        public Book(string title, string[] authors, string publisher, string isbn, double price, int copies)
        {
            this.title = title;
            this.authors = authors;
            this.publisher = publisher;
            this.ISBN = isbn;
            this.price = price;
            this.numberOfCopies = copies;
            this.authorCount = authors.Length;
        }
        public string showTitle()
        {
            return title;
        }
        public void setTitle(string t)
        {
            this.title = t;
        }
        public int showCopies()
        {
            return numberOfCopies;
        }
        public void setNumberOfCopies(int n)
        {
            numberOfCopies = n;
        }
        public string GetPublisher()
        {
           return publisher;
        }
        public void SetPublisher(string newPublisher) { publisher = newPublisher; }

        public string GetISBN()
        {
            return ISBN;
        }
        public void SetISBN(string newISBN) { 
            ISBN = newISBN; 
        }

        public double GetPrice() {
            return price; 
        }
        public void SetPrice(double newPrice) { 
            price = newPrice; 
        }
        public void DisplayBook()
        {
           
            Console.WriteLine($"Title: {title}");
            Console.WriteLine($"Authors: {string.Join(", ", authors)}");
            Console.WriteLine($"publisher: {publisher}");
            Console.WriteLine($"ISBN: {ISBN}");
            Console.WriteLine($"Price: ${price}");
            Console.WriteLine($"copies: {numberOfCopies}");
            
        }
    }
}
