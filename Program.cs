using System;
using ConsoleLibrary.Models;

namespace library
{
    class Program
    {
        static void Main(string[] args)
        {
            var library = new Library("LIBRARY!");
            // library.Name = "Banana"; this wont work because you made a private set in library.cs
            var mobyDick = new Book("Moby Dick", "Herman Melville", "1", "1470");
            var hp = new Book("Harry Potter and the Chamber of Secrets", "Jk Rowling", "12312453453", "1998");
            var lotr = new Book("The fellowship of the Ring", "Grey beard", "2364354342-324", "1954");
            library.AddBook(mobyDick);
            library.AddBook(hp);
            library.AddBook(lotr);

            var sportsIllustrated = new Magazine("Sports Illustrated", "2", "2018");
            var peopleMag = new Magazine("People", "3", "2018");
            var gamePro = new Magazine("GamePro", "4", "1995");

            library.AddMagazine(sportsIllustrated);
            library.AddMagazine(peopleMag);
            library.AddMagazine(gamePro);




            Console.Clear();

            var inthelibrary = true;
            while (inthelibrary)
            {
                System.Console.WriteLine("Welcome to " + library.Name);

                System.Console.WriteLine("thing you can do here.");

                System.Console.WriteLine("1 - Checkout book");
                System.Console.WriteLine("2 - Return book");
                System.Console.WriteLine("3 - Checkout magazine");
                System.Console.WriteLine("4 - Return magazine");

                System.Console.WriteLine("5 - Quit");
                System.Console.WriteLine("What would you like to do?");

                var userInput = Console.ReadLine();
                if (Int32.TryParse(userInput, out int choice))
                {
                    switch (choice)
                    {
                        case 1:
                            library.CheckoutMenu();
                            break;
                        case 2:
                            library.ReturnBook();

                            break;

                        case 3:
                            library.CheckoutMagazine();

                            break;


                        case 4:
                            library.ReturnMag();

                            break;




                        case 5:
                            inthelibrary = false;
                            Console.Clear();
                            Console.WriteLine("Bye Felicia");
                            break;


                        default:
                            System.Console.WriteLine("Invalid Choice Try Again");
                            break;




                    }
                }



            }

        }
    }
}
