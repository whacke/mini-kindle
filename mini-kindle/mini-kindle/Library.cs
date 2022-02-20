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
    }
}
