using Encapsulation_Part2.Models;
namespace Encapsulation_Part2
{
    internal class Program
    {
      

        static void Main(string[] args)
        {
            Book book = new Book("1984", "George Orwell");
            Book book2 = new Book("Lord Of Rings", "J. R. R. Tolkien");
            Book book3 = new Book("The Metamorphosis", "Frans Kafka");
            BookLibrary library = new BookLibrary();


            library.Add(book2);
            library.Add(book3);
            library.Add(book);
            library.SearchByAuthor("Frans Kafka");
            library.RemoveBook("1984");
            library.BorrowBook("The Metamorphosis");
            library.ReturnBook("The Metamorphosis");
            book.GetInfo();
            library.ShowAll();


        }
    }
}
