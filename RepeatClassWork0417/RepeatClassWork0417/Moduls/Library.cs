using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepeatClassWork0417.Moduls
{
    internal class Library
    {
        Book[] _books = new Book[0];

        public Book this[int i]
        {
            get
            {
                foreach (Book book in _books)
                {
                    if(book.Id == i)
                    {
                        return book;
                    }
                }return null;

            }
        }
        public void Add(Book book)
        {
            Array.Resize(ref _books,_books.Length+1);
            _books[_books.Length-1] = book;
        }
    }
 }
