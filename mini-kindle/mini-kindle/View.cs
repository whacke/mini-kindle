using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

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

        public void UpdateDisplay(string text, int pageNum, bool bkMk)
        {
            mainTextBox.Text = text;
            if (bkMk) uxBookMarkCheck.Checked = true;
            else uxBookMarkCheck.Checked = false;
            uxPageLabel.Text = "Page " + (pageNum + 1);
        }

        private void uxOpenMenu_Click(object sender, EventArgs e)
        {
            String fullText = "";
            if (uxOpenFile.ShowDialog() == DialogResult.OK)
            {
                string fname = uxOpenFile.FileName;
                using (StreamReader inFile = new StreamReader(fname))
                {
                    while (!inFile.EndOfStream)
                    {
                        string line = inFile.ReadLine();
                        fullText += line;
                    }
                }
                selectBookHand(fname, fullText);
            }
        }
    }
}
