using System.Numerics;
using System.Timers;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace assigmentt_03_c__basics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. Create Book class, object, store it in object, then print
            //    public class Book
            //{
            //    public string Title { get; set; }
            //    public int Pages { get; set; }
            //}

            //Book book = new Book
            //{
            //    Title = "Clean Code",
            //    Pages = 464
            //};

            //object obj = book;

            //Console.WriteLine(obj);

            //2. Using the Book class above, print the result of calling ToString(), Equals() (compare book with itself), GetHashCode(), and GetType() on book.
            //Book book = new Book
            //{
            //    Title = "Clean Code",
            //    Pages = 464
            //};

            //Console.WriteLine(book.ToString());
            //Console.WriteLine(book.Equals(book));
            //Console.WriteLine(book.GetHashCode());
            //Console.WriteLine(book.GetType());

            //Look at the line below.Is it a compile - time error, a runtime error, or a logical error? Fix it int pages = "464";
            //            int pages = "464";
            //            This is a compile - time error.
            //Because "464" is a string, while pages is declared as an int.

            //Look at the line below.Is it a compile - time error, a runtime error, or a logical error? Fix it int pages = "464";
            //            int pages = "464";
            //            This is a compile - time error.
            //Because "464" is a string, while pages is declared as an int.

            //4. Write code that divides 10 by 0 inside a try block, catches the exception, prints "Cannot divide by zero", and then prints "Done" in a finally block.
            //try
            //{
            //    int result = 10 / 0;
            //}
            //catch (DivideByZeroException)
            //{
            //    Console.WriteLine("Cannot divide by zero");
            //}
            //finally
            //{
            //    Console.WriteLine("Done");
            //}

            //5. Declare an int pages = 300; then store it in a double variable without using a cast.
            //int pages = 300;
            //double value = pages;

            //6. Declare a double price = 49.99; then convert it into an int using a cast.
            //double price = 49.99;
            //int value = (int)price;

            //Console.WriteLine(value);

            //7.Given string pagesText = "464";, convert it into an int using the Convert class.
            //string pagesText = "464";

            //int pages = Convert.ToInt32(pagesText);

            //Console.WriteLine(pages);

            //8. Given string yearText = "2023";, convert it using int.Parse(). Then given string badText = "abc";, use int.TryParse() to safely try converting it, and print "Invalid number" if it fails.
            //string yearText = "2023";

            //int year = int.Parse(yearText);

            //Console.WriteLine(year);


            //string badText = "abc";

            //if (int.TryParse(badText, out int number))
            //{
            //    Console.WriteLine(number);
            //}
            //else
            //{
            //    Console.WriteLine("Invalid number");
            //}

            //9. Given int pages = 464;, convert it into a string using ToString() and print its type using GetType() to prove it's now a string.
            //int pages = 464;

            //string pagesText = pages.ToString();

            //Console.WriteLine(pagesText);
            //Console.WriteLine(pagesText.GetType());

            //10. Declare int copies = 100;. Box it into an object variable, then unbox it back into a new int variable, and print both.
            //int copies = 100;

            //object boxedCopies = copies;       // Boxing
            //int unboxedCopies = (int)boxedCopies; // Unboxing

            //Console.WriteLine(copies);
            //Console.WriteLine(unboxedCopies);

            //11. Given int pages = 464;, write an if / else statement that prints "Long Book" if pages is greater than 300, otherwise prints "Short Book".
            //int pages = 464;

            //if (pages > 300)
            //{
            //    Console.WriteLine("Long Book");
            //}
            //else
            //{
            //    Console.WriteLine("Short Book");
            //}

            //11. Given int pages = 464; and bool isAvailable = true;, print "You can borrow this book" only if pages is greater than 300 and isAvailable is true.Use the && operator.
            //int pages = 464;
            //bool isAvailable = true;

            //if (pages > 300 && isAvailable == true)
            //{
            //    Console.WriteLine("You can borrow this book");
            //}

            //12. Given string title = "Refactoring";, write a switch statement that prints "Great choice!" if the title is "Clean Code", "Nice pick!" if it's "Refactoring", and "Never heard of it" for anything else.
            //string title = "Refactoring";

            //switch (title)
            //{
            //    case "Clean Code":
            //        Console.WriteLine("Great choice!");
            //        break;

            //    case "Refactoring":
            //        Console.WriteLine("Nice pick!");
            //        break;

            //    default:
            //        Console.WriteLine("Never heard of it");
            //        break;
            //}

            //13.  Given int pages = 464;, use the ternary operator to store "Long Book" or "Short Book" into a variable sizeLabel(same rule as question 8: long if pages > 300).
            //int pages = 464;

            //string sizeLabel = pages > 300 ? "Long Book" : "Short Book";

            //Console.WriteLine(sizeLabel);

        }

    }
}
