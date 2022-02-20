using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* TODO:
 * 1) Decide how we want to do the constructor for the book
 * considering we probably want to keep current page and bookmarks
 * saved somewhere
 * 2) Update UML to reflect those changes and the addition of title
*/
namespace mini_kindle
{
    /// <summary>
    /// Book class
    /// </summary>
    public class Book
    {
        /// <summary>
        /// current page of book
        /// </summary>
        private int currentPage;
        /// <summary>
        /// list of string values for all pages
        /// </summary>
        private List<String> pages;
        /// <summary>
        /// author's name
        /// </summary>
        private String author;
        /// <summary>
        /// title of book
        /// </summary>
        private String title;
        /// <summary>
        /// list of bookmark page numbers 
        /// </summary>
        private List<int> bookmarks;
        /// <summary>
        /// book constructor
        /// </summary>
        public Book()
        {

        }
        /// <summary>
        /// Method to add or remove a bookmark
        /// </summary>
        /// <param name="p">page number in question</param>
        /// <param name="a">true for add, false for remove</param>
        public void AddRemBkMk(int p, bool a)
        {
            if (a && bookmarks.Count < 3)
                bookmarks.Add(p);
            else
                bookmarks.Remove(p);
        }
        /// <summary>
        /// Method to flip a page
        /// </summary>
        /// <param name="dir">true to go forward, false to go backwards</param>
        public void FlipPage(bool dir)
        {
            if (dir)
                currentPage++;
            else
                currentPage--;
        }
    }
}
