using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;


namespace LibraryTask
{
    internal class Library
    {
        public List<string> Books = new List<string>();
        int _bookLimit = 10;

        public int BookLimit => _bookLimit;

        public void AddBook(string bookName)
        {
            foreach (var book in Books)
            {
                try
                {
                    if (book == bookName)
                        throw new Exception();
                }
                catch 
                {
                    Console.WriteLine("This book already exists!");
                    return;
                }
            }

            if (Books.Count >= _bookLimit)
            {
                Console.WriteLine("Book limit is full!");
                return;
            }

            Books.Add(bookName);
            Console.WriteLine("Book added!");
        }


        public bool RemoveBook(string bookName)
        {
            if (Books.Contains(bookName))
            {
                Books.Remove(bookName);
                return true;
            }
            else
                return false;
        }
    }

}
