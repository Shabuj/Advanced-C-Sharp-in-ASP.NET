using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnnonymousType
{
    class Program
    {
        static void Main(string[] args)
        {
            var aCustomer = new { Name = "Shabuj", Address = "Hakimpur", Age = "27" };
            var aStudent = new { Name = "Nayan", Roll = "171018", Age = "18" };
            Console.WriteLine(aCustomer.Name +" "+aCustomer.Address+" " + aStudent.Age +" " );
            var names = new[] { "Rahman", "Abir", "Shopnil" };
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
            var annList = new[]
            {
                new {Name="Rahim",Address="Hakimpur", Age="12" },
                new {Name="Abrar",Address="Jhenaidah", Age="17"},
                new {Name="Karim",Address="Dhaka", Age="18" }
            };
            foreach (var aValue in annList)
            {
                Console.WriteLine(aValue.Name);
            }
            show(annList);
            Console.ReadKey();

        }

        private static void show(IEnumerable<dynamic>annList)
        {
            foreach (var aValue in annList)
            {
                printCode(aValue);
            }
        }

        private static void printCode(dynamic aValue)
        {
            Console.WriteLine(aValue.Name);
        }
    }
}
