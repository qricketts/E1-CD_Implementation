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

        private List<int> bookMarks;

        public Book(string title, int pageCount)
        {
            Title = title;
            PageCount = pageCount;
            CurrentPage = 0;
            bookMarks = new List<int>();
        }

        public void SetBookMark(List<int> bookmark)
        {
            bookMarks = bookmark;
        }

        public void SetBookMark(int index, int pageNum)
        {
            if (index < 3)
                bookMarks.Add(pageNum);
        }

        public List<int> GetBookMarks()
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
            if (CurrentPage < PageCount)
                CurrentPage++;
        }

        //Changes page
        public void PrevPage()
        {
            if (CurrentPage > 0)
                CurrentPage--;
        }

        public override string ToString()
        {
            return Title;
        }
    }
}
