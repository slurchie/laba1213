using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba13
{
    class Container
    {
        Book[] books;

        public Container(Book[] Books)
        {
            books = Books;
        }
        public void Sort(Searcher sorting)
        {
            for (int i = 0; i < books.Length - 1; i++)
            {
                for (int j = i + 1; j < books.Length; j++)
                {
                    if (sorting(books[i], books[j]))
                    {
                        Book temp;
                        temp = books[i];
                        books[i] = books[j];
                        books[j] = temp;
                    }
                }

            }
        }
    }
}
