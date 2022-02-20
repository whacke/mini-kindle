using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mini_kindle
{
    public partial class View : Form
    {
        private FlipPageHandler fpHand;
        private BookMkHandler bkMkHand;
        private SelectBookDel selectBookHand;
        public View(FlipPageHandler fp, BookMkHandler bkMk, SelectBookDel selectBook)
        {
            InitializeComponent();
            fpHand = fp;
            bkMkHand = bkMk;
            selectBookHand = selectBook;
        }

        public void Backward_Clicked(object sender, EventArgs e)
        {
            fpHand(false);
        }
        public void AddBookmark_Clicked(object sender, EventArgs e)
        {
            bkMkHand(true);
        }
        public void RemoveBookmark_Clicked(object sender, EventArgs e)
        {
            bkMkHand(false);
        }
        public void Forward_Clicked(object sender, EventArgs e)
        {
            fpHand(true);
        }
    }
}
