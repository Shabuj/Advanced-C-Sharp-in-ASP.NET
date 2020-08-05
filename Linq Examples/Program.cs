using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_Examples
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Book> books = new List<Book>()
            {
                new Book { Author="Rahman", Name="Data Structures",Price=777, PublishedDate=new DateTime(1995,06,12)},
                new Book { Author="Abdur Rahman", Name=" Algorithm", Price= 1000, PublishedDate=new DateTime(1999,04,02)}
            };
            //LINQ 
            var selectedBook = from book in books
                               where book.Price>=777
                               select book;

            var selectB = books.FindAll(book => book.Author.StartsWith("A"));//Lamda Expression
            foreach (var aValue in selectB)
            {
                Console.WriteLine(aValue.Author + " " + aValue.Name + " " + aValue.Price + " " + aValue.PublishedDate);

            }
            Console.WriteLine("-----------------");
            foreach (var aValue in selectedBook)
            {
                Console.WriteLine(aValue.Author + " " + aValue.Name + " " + aValue.Price + " " + aValue.PublishedDate);

            }

            
            Console.ReadKey();
        }
    }
}
