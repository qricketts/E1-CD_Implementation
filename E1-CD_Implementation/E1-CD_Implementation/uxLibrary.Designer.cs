
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
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.uxBookList = new System.Windows.Forms.ListBox();
            this.uxSelectBook = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(24, 283);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(66, 43);
            this.button1.TabIndex = 0;
            this.button1.Text = "add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(62, 257);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(32, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "Pages";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(24, 257);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(32, 20);
            this.textBox2.TabIndex = 2;
            this.textBox2.Text = "Title";
            // 
            // uxBookList
            // 
            this.uxBookList.FormattingEnabled = true;
            this.uxBookList.Location = new System.Drawing.Point(12, 12);
            this.uxBookList.Name = "uxBookList";
            this.uxBookList.Size = new System.Drawing.Size(355, 251);
            this.uxBookList.TabIndex = 0;
            this.uxBookList.SelectedIndexChanged += new System.EventHandler(this.uxBookList_SelectedIndexChanged);
            // 
            // uxSelectBook
            // 
            this.uxSelectBook.Enabled = false;
            this.uxSelectBook.Location = new System.Drawing.Point(117, 283);
            this.uxSelectBook.Name = "uxSelectBook";
            this.uxSelectBook.Size = new System.Drawing.Size(136, 47);
            this.uxSelectBook.TabIndex = 1;
            this.uxSelectBook.Text = "Select Book";
            this.uxSelectBook.UseVisualStyleBackColor = true;
            this.uxSelectBook.Click += new System.EventHandler(this.uxSelectBook_Click);
            // 
            // uxLibrary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 342);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.uxSelectBook);
            this.Controls.Add(this.uxBookList);
            this.Name = "uxLibrary";
            this.Text = "Library";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox uxBookList;
        private System.Windows.Forms.Button uxSelectBook;
    }
}

