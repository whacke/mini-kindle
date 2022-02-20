
namespace mini_kindle
{
    partial class View
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainTextBox = new System.Windows.Forms.TextBox();
            this.backwardButton = new System.Windows.Forms.Button();
            this.addBookmark = new System.Windows.Forms.Button();
            this.forwardButton = new System.Windows.Forms.Button();
            this.removeBookMark = new System.Windows.Forms.Button();
            this.uxOpenFile = new System.Windows.Forms.OpenFileDialog();
            this.bookSelector = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mainTextBox
            // 
            this.mainTextBox.Location = new System.Drawing.Point(13, 13);
            this.mainTextBox.Multiline = true;
            this.mainTextBox.Name = "mainTextBox";
            this.mainTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.mainTextBox.Size = new System.Drawing.Size(775, 374);
            this.mainTextBox.TabIndex = 0;
            // 
            // backwardButton
            // 
            this.backwardButton.Location = new System.Drawing.Point(179, 393);
            this.backwardButton.Name = "backwardButton";
            this.backwardButton.Size = new System.Drawing.Size(79, 35);
            this.backwardButton.TabIndex = 1;
            this.backwardButton.Text = "<----";
            this.backwardButton.UseVisualStyleBackColor = true;
            this.backwardButton.Click += new System.EventHandler(this.Backward_Clicked);
            // 
            // addBookmark
            // 
            this.addBookmark.Location = new System.Drawing.Point(264, 393);
            this.addBookmark.Name = "addBookmark";
            this.addBookmark.Size = new System.Drawing.Size(171, 35);
            this.addBookmark.TabIndex = 2;
            this.addBookmark.Text = "Add Bookmark";
            this.addBookmark.UseVisualStyleBackColor = true;
            this.addBookmark.Click += new System.EventHandler(this.AddBookmark_Clicked);
            // 
            // forwardButton
            // 
            this.forwardButton.Location = new System.Drawing.Point(617, 393);
            this.forwardButton.Name = "forwardButton";
            this.forwardButton.Size = new System.Drawing.Size(84, 35);
            this.forwardButton.TabIndex = 3;
            this.forwardButton.Text = "--->";
            this.forwardButton.UseVisualStyleBackColor = true;
            this.forwardButton.Click += new System.EventHandler(this.Forward_Clicked);
            // 
            // removeBookMark
            // 
            this.removeBookMark.Location = new System.Drawing.Point(441, 393);
            this.removeBookMark.Name = "removeBookMark";
            this.removeBookMark.Size = new System.Drawing.Size(170, 35);
            this.removeBookMark.TabIndex = 4;
            this.removeBookMark.Text = "Remove Bookmark";
            this.removeBookMark.UseVisualStyleBackColor = true;
            this.removeBookMark.Click += new System.EventHandler(this.RemoveBookmark_Clicked);
            // 
            // bookSelector
            // 
            this.bookSelector.Location = new System.Drawing.Point(13, 393);
            this.bookSelector.Name = "bookSelector";
            this.bookSelector.Size = new System.Drawing.Size(122, 35);
            this.bookSelector.TabIndex = 5;
            this.bookSelector.Text = "Select Book";
            this.bookSelector.UseVisualStyleBackColor = true;
            this.bookSelector.Click += new System.EventHandler(this.uxOpenMenu_Click);
            // 
            // View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bookSelector);
            this.Controls.Add(this.removeBookMark);
            this.Controls.Add(this.forwardButton);
            this.Controls.Add(this.addBookmark);
            this.Controls.Add(this.backwardButton);
            this.Controls.Add(this.mainTextBox);
            this.Name = "View";
            this.Text = "mini-kindle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox mainTextBox;
        private System.Windows.Forms.Button backwardButton;
        private System.Windows.Forms.Button addBookmark;
        private System.Windows.Forms.Button forwardButton;
        private System.Windows.Forms.Button removeBookMark;
        private System.Windows.Forms.OpenFileDialog uxOpenFile;
        private System.Windows.Forms.Button bookSelector;
    }
}

