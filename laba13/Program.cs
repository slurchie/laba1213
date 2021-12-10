using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba13
{
    class Program
    {
        static public bool Finder(Book a, Book b)
        {
            if (a.Publisher.Length < b.Publisher.Length)
            {
                return false;
            }
            return true;
        }
        static public bool F(Book a, Book b)
        {
            if (a.Publisher[0] < b.Publisher[0])
            {
                return false;
            }
            return true;
        }
        static void Main(string[] args)
        {

            Console.WriteLine("vtnjl");
            Book[] books = new Book[4];
            books[0] = new Book("АПРП", "РАРПОП", "ПРРПО");
            books[1] = new Book("MПРП", "РАРПОП", "5335234 ");
            books[2] = new Book("АПРП", "РАРПОП", "SADASFDSGSDFSAD");
            books[3] = new Book("АПРП", "РАРПОП", "G");
            Searcher searcher = Finder;
            Container C = new Container(books);
            C.Sort(searcher);
            Searcher S1 = F;
            C.Sort(S1);
            ComplexNumbers numberone = new ComplexNumbers(6, 5);
            ComplexNumbers numbertwo = new ComplexNumbers(4, 1);
            ComplexNumbers sum = numberone + numbertwo;
            ComplexNumbers minus = numberone - numbertwo;
            ComplexNumbers multiply = numberone * numbertwo;
            numberone.ToString();
            numberone.Equals(numbertwo);

            Console.ReadKey();


        }
    }

    delegate bool Searcher(Book a, Book b);
    
}






