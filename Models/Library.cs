using System;
using System.Collections.Generic;

namespace ConsoleLibrary.Models
{
    public class Library
    {
        public string Name { get; private set; }
        // private by default if accessor not specified.

        List<Book> Books = new List<Book>();  // typing new List<Book> instantiates it.  this is best practice
        List<Magazine> Magazines = new List<Magazine>();

        public void ViewMags()
        {
            for (int i = 0; i < Magazines.Count; i++)
            {
                Magazine magazine = Magazines[i];
                System.Console.WriteLine($"{i + 1} - {magazine.Title} - {(magazine.Available ? "Available" : "Not Available")}");

            }


        }

        public void ViewBooks()
        {
            // Book[] bs = new Book[Books.Count];
            // bs.Length
            for (int i = 0; i < Books.Count; i++) // count is how many items in the list, length is array
            {
                Book book = Books[i];  // could have also said var book = Books[i];
                // this is an if statement.  
                System.Console.WriteLine($"{i + 1} - {book.Title} {(book.Title.Length < 28 ? "\t\t\t" : book.Title.Length < 39 ? "\t\t" : "\t")}{(book.Available ? "Available" : "Not Available")}");
            }
        }

        public void AddBook(Book book) // its a book of type Book its book.cs
        {
            Books.Add(book);
        }

        public void AddMagazine(Magazine magazine)
        {
            Magazines.Add(magazine);
        }


        public Library(string name) // must have same name as the class itself.
        {
            Name = name;
        }

        private Book GetBookFromUserChoice()
        {

            ViewBooks();
            if (Int32.TryParse(Console.ReadLine(), out int n))
            {
                n = n - 1;
                if (n < 0 || n >= Books.Count)
                {
                    return null;
                }
                return Books[n];
            }
            else
            {
                return null;
            }

        }

        private Magazine GetMagFromUserChoice()
        {

            ViewMags();
            if (Int32.TryParse(Console.ReadLine(), out int n))
            {
                n = n - 1;
                if (n < 0 || n >= Magazines.Count)
                {
                    return null;
                }
                return Magazines[n];
            }
            else
            {
                return null;
            }

        }



        // when i execute this method i want it to return a book


        public void CheckoutMenu()
        {
            var checkingoutabook = true;
            while (checkingoutabook)
            {

                Console.Clear();
                // ViewBooks();
                // System.Console.WriteLine("\n\n\n");
                // System.Console.WriteLine($"{Books.Count} - Go Back ");

                Book book = GetBookFromUserChoice();

                if (book == null)
                {
                    checkingoutabook = false;
                }
                else
                {
                    book.Available = false;

                }
            }


        }

        public void CheckoutMagazine()
        {
            var checkingoutamag = true;
            while (checkingoutamag)
            {

                Console.Clear();

                Magazine magazine = GetMagFromUserChoice();

                if (magazine == null)
                {
                    checkingoutamag = false;
                }
                else
                {
                    magazine.Available = false;
                }




            }
        }

        public void ReturnBook()
        {
            var returningabook = true;
            while (returningabook)
            {
                Console.Clear();


                // System.Console.WriteLine($"You have {Books.Count} books checked out.");
                // System.Console.WriteLine("What book would you like to return?");

                Book book = GetBookFromUserChoice();

                if (book == null)
                {
                    returningabook = false;
                }
                else
                {
                    book.Available = true;

                }





            }

        }

        public void ReturnMag()
        {
            var returningamag = true;
            while (returningamag)
            {
                Console.Clear();


                // System.Console.WriteLine($"You have {Books.Count} books checked out.");
                // System.Console.WriteLine("What book would you like to return?");

                Magazine magazine = GetMagFromUserChoice();

                if (magazine == null)
                {
                    returningamag = false;
                }
                else
                {
                    magazine.Available = true;

                }





            }

        }
    }
}