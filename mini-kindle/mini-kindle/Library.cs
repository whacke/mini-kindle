using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mini_kindle
{
    /// <summary>
    /// Library Class
    /// </summary>
    public class Library
    {
        /// <summary>
        /// List of Books in this Library
        /// </summary>
        private List<Book> library;
        /// <summary>
        /// Library constructor
        /// </summary>
        public Library()
        {
            library = new List<Book>();
        }

        public Book AddBook(String title, String fullText)
        {
            Book b = new Book(fullText, title);
            if (library.Contains(b))
            {
                int bookIndex = 0;
                for(int i = 0; i < library.Count; i++)
                {
                    if (b.Equals(library[i]))
                    {
                        bookIndex = i;
                    }
                }
                return library[bookIndex];
            }
            else if (library.Count < 25)
            {
                library.Add(b);
                return b;
            } 
            return null;
        }
    }
}
