
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
            this.uxPageLabel = new System.Windows.Forms.Label();
            this.uxBookMarkCheck = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // mainTextBox
            // 
            this.mainTextBox.Location = new System.Drawing.Point(12, 10);
            this.mainTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mainTextBox.Multiline = true;
            this.mainTextBox.Name = "mainTextBox";
            this.mainTextBox.ReadOnly = true;
            this.mainTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.mainTextBox.Size = new System.Drawing.Size(689, 300);
            this.mainTextBox.TabIndex = 0;
            // 
            // backwardButton
            // 
            this.backwardButton.Location = new System.Drawing.Point(159, 314);
            this.backwardButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.backwardButton.Name = "backwardButton";
            this.backwardButton.Size = new System.Drawing.Size(70, 28);
            this.backwardButton.TabIndex = 1;
            this.backwardButton.Text = "<----";
            this.backwardButton.UseVisualStyleBackColor = true;
            this.backwardButton.Click += new System.EventHandler(this.Backward_Clicked);
            // 
            // addBookmark
            // 
            this.addBookmark.Location = new System.Drawing.Point(235, 314);
            this.addBookmark.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addBookmark.Name = "addBookmark";
            this.addBookmark.Size = new System.Drawing.Size(152, 28);
            this.addBookmark.TabIndex = 2;
            this.addBookmark.Text = "Add Bookmark";
            this.addBookmark.UseVisualStyleBackColor = true;
            this.addBookmark.Click += new System.EventHandler(this.AddBookmark_Clicked);
            // 
            // forwardButton
            // 
            this.forwardButton.Location = new System.Drawing.Point(548, 314);
            this.forwardButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.forwardButton.Name = "forwardButton";
            this.forwardButton.Size = new System.Drawing.Size(75, 28);
            this.forwardButton.TabIndex = 3;
            this.forwardButton.Text = "--->";
            this.forwardButton.UseVisualStyleBackColor = true;
            this.forwardButton.Click += new System.EventHandler(this.Forward_Clicked);
            // 
            // removeBookMark
            // 
            this.removeBookMark.Location = new System.Drawing.Point(392, 314);
            this.removeBookMark.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.removeBookMark.Name = "removeBookMark";
            this.removeBookMark.Size = new System.Drawing.Size(151, 28);
            this.removeBookMark.TabIndex = 4;
            this.removeBookMark.Text = "Remove Bookmark";
            this.removeBookMark.UseVisualStyleBackColor = true;
            this.removeBookMark.Click += new System.EventHandler(this.RemoveBookmark_Clicked);
            // 
            // bookSelector
            // 
            this.bookSelector.Location = new System.Drawing.Point(12, 314);
            this.bookSelector.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bookSelector.Name = "bookSelector";
            this.bookSelector.Size = new System.Drawing.Size(108, 28);
            this.bookSelector.TabIndex = 5;
            this.bookSelector.Text = "Select Book";
            this.bookSelector.UseVisualStyleBackColor = true;
            this.bookSelector.Click += new System.EventHandler(this.uxOpenMenu_Click);
            // 
            // uxPageLabel
            // 
            this.uxPageLabel.AutoSize = true;
            this.uxPageLabel.Location = new System.Drawing.Point(629, 320);
            this.uxPageLabel.Name = "uxPageLabel";
            this.uxPageLabel.Size = new System.Drawing.Size(45, 17);
            this.uxPageLabel.TabIndex = 6;
            this.uxPageLabel.Text = "Page ";
            // 
            // uxBookMarkCheck
            // 
            this.uxBookMarkCheck.AutoSize = true;
            this.uxBookMarkCheck.Enabled = false;
            this.uxBookMarkCheck.Location = new System.Drawing.Point(584, 347);
            this.uxBookMarkCheck.Name = "uxBookMarkCheck";
            this.uxBookMarkCheck.Size = new System.Drawing.Size(117, 21);
            this.uxBookMarkCheck.TabIndex = 7;
            this.uxBookMarkCheck.Text = "Bookmarked?";
            this.uxBookMarkCheck.UseVisualStyleBackColor = true;
            // 
            // View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 373);
            this.Controls.Add(this.uxBookMarkCheck);
            this.Controls.Add(this.uxPageLabel);
            this.Controls.Add(this.bookSelector);
            this.Controls.Add(this.removeBookMark);
            this.Controls.Add(this.forwardButton);
            this.Controls.Add(this.addBookmark);
            this.Controls.Add(this.backwardButton);
            this.Controls.Add(this.mainTextBox);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
        private System.Windows.Forms.Label uxPageLabel;
        private System.Windows.Forms.CheckBox uxBookMarkCheck;
    }
}

