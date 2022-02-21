using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        /// Number of characters displayed on a page
        /// </summary>
        private const int pageLength = 1800;

        /// <summary>
        /// book constructor
        /// </summary>
        public Book(String fullText, String title)
        {
            this.title = title; 
            bookmarks = new List<int>();
            pages = new List<string>();

            // This section of code builds pages!
            StringBuilder buildBook = new StringBuilder();
            for(int i = 0; i < fullText.Length; i++) // This for loop traverses the entire text
            {
                for (int j = 0; j < pageLength; j++) // This for loop tracks the length of this individual page!
                {
                    if(i >= fullText.Length) // if we reached the end of the book, break the loop
                    {
                        break;
                    }

                    if(fullText[i].Equals(Environment.NewLine)) // this was in an attempt to format with newlines, but they don't seem to exist in .txt files, so ¯\_(ツ)_/¯
                    {
                        buildBook.Append(Environment.NewLine);
                    }
                    else
                    {
                        buildBook.Append(fullText[i]);
                    }

                    i++; // keep track of current caracter
                }

                string newPage = buildBook.ToString(); // create new page
                pages.Add(newPage); // add new page
                buildBook.Clear(); // clear room for new page

            }

        }
        /// <summary>
        /// Method to add or remove a bookmark
        /// </summary>
        /// <param name="p">page number in question</param>
        /// <param name="a">true for add, false for remove</param>
        public void AddRemBkMk(bool a)
        {
            if (a && bookmarks.Count < 3)
                bookmarks.Add(currentPage);
            else
                bookmarks.Remove(currentPage);
        }
        /// <summary>
        /// Method to flip a page
        /// </summary>
        /// <param name="dir">true to go forward, false to go backwards</param>
        public void FlipPage(bool dir)
        {
            if (dir && currentPage < pages.Count)
                currentPage++;
            else if (currentPage > 0)
                currentPage--;
        }

        /// <summary>
        /// Returns the text of the current page;
        /// </summary>
        /// <returns></returns>
        public String GetCurPageText()
        {
            if (currentPage >= pages.Count) currentPage = currentPage - 1; // stops reader from going past the end of the book
            return pages[currentPage];
        }
    }
}
