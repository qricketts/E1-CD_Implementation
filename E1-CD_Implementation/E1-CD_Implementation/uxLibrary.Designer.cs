
namespace E1_CD_Implementation
{
    partial class uxLibrary
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
            this.uxBookList = new System.Windows.Forms.ListBox();
            this.uxSelectBook = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uxBookList
            // 
            this.uxBookList.FormattingEnabled = true;
            this.uxBookList.Location = new System.Drawing.Point(12, 12);
            this.uxBookList.Name = "uxBookList";
            this.uxBookList.Size = new System.Drawing.Size(355, 251);
            this.uxBookList.TabIndex = 0;
            // 
            // uxSelectBook
            // 
            this.uxSelectBook.Location = new System.Drawing.Point(117, 283);
            this.uxSelectBook.Name = "uxSelectBook";
            this.uxSelectBook.Size = new System.Drawing.Size(136, 47);
            this.uxSelectBook.TabIndex = 1;
            this.uxSelectBook.Text = "Select Book";
            this.uxSelectBook.UseVisualStyleBackColor = true;
            // 
            // uxLibrary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 342);
            this.Controls.Add(this.uxSelectBook);
            this.Controls.Add(this.uxBookList);
            this.Name = "uxLibrary";
            this.Text = "Library";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox uxBookList;
        private System.Windows.Forms.Button uxSelectBook;
    }
}

