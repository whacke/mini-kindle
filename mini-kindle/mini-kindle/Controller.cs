using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace mini_kindle
{
    /// <summary>
    /// Controller class
    /// </summary>
    public class Controller
    {
        private Library library;
        private Book curBook;
        private UpdateDisplayDel updateDisplayHand;
        //refresh delegate here

        public Controller()
        {
            curBook = null;
            library = new Library();
        }

        public void AssignDisplay(UpdateDisplayDel del)
        {
            updateDisplayHand = del;
        }

        public void FlipPage(bool dir)
        {
            if (curBook != null)
            {
                curBook.FlipPage(dir);
                updateDisplayHand(curBook.GetCurPageText(), curBook.GetCurPageNumber(), curBook.CheckPageBookMark());
            }
        }

        public void HandleBkMk(bool a)
        {
            if (curBook != null)
            {
                curBook.AddRemBkMk(a);
                updateDisplayHand(curBook.GetCurPageText(), curBook.GetCurPageNumber(), curBook.CheckPageBookMark());
            }
        }

        public void HandleSelectBook(String title)
        {
            String fullText = "";
            using (StreamReader inFile = new StreamReader(title))
            {
                while (!inFile.EndOfStream)
                {
                    string line = inFile.ReadLine();
                    fullText += line;
                }
            }

            Book book = library.AddBook(title, fullText);
            if (book != null)
            {
                curBook = book;
                updateDisplayHand(curBook.GetCurPageText(), curBook.GetCurPageNumber(), curBook.CheckPageBookMark());
            }
        }
    }
}
