using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LamdaExpression
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names= new List<string>() {"Rahim","Karim","Ronik"};
            string found = names.Find(name => name.StartsWith("R"));
            var founded = names.FindAll(name => name.StartsWith("R"));
            Console.WriteLine(found);
            List<double> num = new List<double>(){1, 3 , 6 , 56, 23};
            var n = num.FindAll(numb =>( numb > 3));

            List<Book> books = new List<Book>()
            {
                new Book { Author="Rahman", Name="Data Structures", PublishedDate=new DateTime(1995,06,12)},
                new Book { Author="Abdur Rahman", Name=" Agorithm", PublishedDate=new DateTime(1999,04,02)}
            };

            foreach (var aValue in books)
            {
                Console.WriteLine(aValue.Author);
            }
            var selectedBooks = books.FindAll(book => book.Author == "Rahman" );

            foreach (var aValue in selectedBooks)
            {
                Console.WriteLine(aValue.Author);
            }
            Console.ReadKey();
        }
    }
}
