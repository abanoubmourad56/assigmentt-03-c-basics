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
        }
    }
}
