
namespace E1_CD_Implementation
{
    partial class uxBook
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
            this.uxPage = new System.Windows.Forms.TextBox();
            this.uxPageBackward = new System.Windows.Forms.Button();
            this.uxPageForward = new System.Windows.Forms.Button();
            this.uxAddBookmark = new System.Windows.Forms.Button();
            this.uxRemoveBookmark = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uxPage
            // 
            this.uxPage.Location = new System.Drawing.Point(12, 12);
            this.uxPage.Multiline = true;
            this.uxPage.Name = "uxPage";
            this.uxPage.Size = new System.Drawing.Size(354, 237);
            this.uxPage.TabIndex = 0;
            // 
            // uxPageBackward
            // 
            this.uxPageBackward.Location = new System.Drawing.Point(12, 255);
            this.uxPageBackward.Name = "uxPageBackward";
            this.uxPageBackward.Size = new System.Drawing.Size(75, 23);
            this.uxPageBackward.TabIndex = 1;
            this.uxPageBackward.Text = "<";
            this.uxPageBackward.UseVisualStyleBackColor = true;
            this.uxPageBackward.Click += new System.EventHandler(this.uxPageBackward_Click);
            // 
            // uxPageForward
            // 
            this.uxPageForward.Location = new System.Drawing.Point(291, 255);
            this.uxPageForward.Name = "uxPageForward";
            this.uxPageForward.Size = new System.Drawing.Size(75, 23);
            this.uxPageForward.TabIndex = 2;
            this.uxPageForward.Text = ">";
            this.uxPageForward.UseVisualStyleBackColor = true;
            this.uxPageForward.Click += new System.EventHandler(this.uxPageForward_Click);
            // 
            // uxAddBookmark
            // 
            this.uxAddBookmark.Location = new System.Drawing.Point(12, 284);
            this.uxAddBookmark.Name = "uxAddBookmark";
            this.uxAddBookmark.Size = new System.Drawing.Size(139, 47);
            this.uxAddBookmark.TabIndex = 3;
            this.uxAddBookmark.Text = "Add Bookmark";
            this.uxAddBookmark.UseVisualStyleBackColor = true;
            this.uxAddBookmark.Click += new System.EventHandler(this.uxAddBookMark_Click);
            // 
            // uxRemoveBookmark
            // 
            this.uxRemoveBookmark.Location = new System.Drawing.Point(227, 284);
            this.uxRemoveBookmark.Name = "uxRemoveBookmark";
            this.uxRemoveBookmark.Size = new System.Drawing.Size(139, 47);
            this.uxRemoveBookmark.TabIndex = 4;
            this.uxRemoveBookmark.Text = "Remove Bookmark";
            this.uxRemoveBookmark.UseVisualStyleBackColor = true;
            this.uxRemoveBookmark.Click += new System.EventHandler(this.uxRemoveBookmark_Click);
            // 
            // uxBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 343);
            this.Controls.Add(this.uxRemoveBookmark);
            this.Controls.Add(this.uxAddBookmark);
            this.Controls.Add(this.uxPageForward);
            this.Controls.Add(this.uxPageBackward);
            this.Controls.Add(this.uxPage);
            this.Name = "uxBook";
            this.Text = "Book";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox uxPage;
        private System.Windows.Forms.Button uxPageBackward;
        private System.Windows.Forms.Button uxPageForward;
        private System.Windows.Forms.Button uxAddBookmark;
        private System.Windows.Forms.Button uxRemoveBookmark;
    }
}