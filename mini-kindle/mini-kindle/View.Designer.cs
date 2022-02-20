
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
            this.manTextBox = new System.Windows.Forms.TextBox();
            this.backwardButton = new System.Windows.Forms.Button();
            this.bookmarkButton = new System.Windows.Forms.Button();
            this.forwardButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // manTextBox
            // 
            this.manTextBox.Location = new System.Drawing.Point(13, 13);
            this.manTextBox.Multiline = true;
            this.manTextBox.Name = "manTextBox";
            this.manTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.manTextBox.Size = new System.Drawing.Size(775, 374);
            this.manTextBox.TabIndex = 0;
            // 
            // backwardButton
            // 
            this.backwardButton.Location = new System.Drawing.Point(237, 393);
            this.backwardButton.Name = "backwardButton";
            this.backwardButton.Size = new System.Drawing.Size(79, 35);
            this.backwardButton.TabIndex = 1;
            this.backwardButton.Text = "<----";
            this.backwardButton.UseVisualStyleBackColor = true;
            this.backwardButton.Click += new System.EventHandler(this.Backward_Clicked);
            // 
            // bookmarkButton
            // 
            this.bookmarkButton.Location = new System.Drawing.Point(322, 393);
            this.bookmarkButton.Name = "bookmarkButton";
            this.bookmarkButton.Size = new System.Drawing.Size(113, 35);
            this.bookmarkButton.TabIndex = 2;
            this.bookmarkButton.Text = "Bookmark";
            this.bookmarkButton.UseVisualStyleBackColor = true;
            this.bookmarkButton.Click += new System.EventHandler(this.Bookmark_Clicked);
            // 
            // forwardButton
            // 
            this.forwardButton.Location = new System.Drawing.Point(441, 393);
            this.forwardButton.Name = "forwardButton";
            this.forwardButton.Size = new System.Drawing.Size(84, 35);
            this.forwardButton.TabIndex = 3;
            this.forwardButton.Text = "--->";
            this.forwardButton.UseVisualStyleBackColor = true;
            this.forwardButton.Click += new System.EventHandler(this.Forward_Clicked);
            // 
            // View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.forwardButton);
            this.Controls.Add(this.bookmarkButton);
            this.Controls.Add(this.backwardButton);
            this.Controls.Add(this.manTextBox);
            this.Name = "View";
            this.Text = "mini-kindle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox manTextBox;
        private System.Windows.Forms.Button backwardButton;
        private System.Windows.Forms.Button bookmarkButton;
        private System.Windows.Forms.Button forwardButton;
    }
}

