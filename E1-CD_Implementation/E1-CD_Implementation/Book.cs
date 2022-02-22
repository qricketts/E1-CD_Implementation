using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E1_CD_Implementation
{
    public class Book
    {
        public string Title { get; set; }

        public int PageCount { get; set; }

        public int CurrentPage { get; set; }

        private int[] bookMarks;

        public Book(string title, int pageCount)
        {
            Title = title;
            PageCount = pageCount;
            CurrentPage = 0;
            bookMarks = new int[3];
        }

        public void SetBookMark(int index, int pageNum)
        {
            if (index > 2) throw new Exception("Bookmark Index Out of Range");
            bookMarks[index] = pageNum;
        }

        public int[] GetBookMarks()
        {
            return bookMarks;
        }

        //Changes page
        public void GoToPage(int pageNum)
        {
            if (pageNum < PageCount && pageNum >= 0) CurrentPage = pageNum;
        }

        //Changes page
        public void NextPage()
        {
            if (CurrentPage >= PageCount - 1) throw new Exception("No Pages Remaining");
            CurrentPage++;
        }

        //Changes page
        public void PrevPage()
        {
            if (CurrentPage <= 0) throw new Exception("No Previous Pages");
            CurrentPage--;
        }


    }
}
