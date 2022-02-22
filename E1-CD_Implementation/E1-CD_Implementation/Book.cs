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

        private int[] bookMarks = new int[3];

        public void SetBookMark(int index, int pageNum)
        {
            bookMarks[index] = pageNum;
        }

        public int[] GetBookMarks()
        {
            return bookMarks;
        }
    }
}
