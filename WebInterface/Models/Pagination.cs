using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebInterface.Models
{
    public class Pagination<T>
    {
        public List<T> Items { get; set; }

        public int PageNumber { get; set; }

        public int RowsPerPage { get; set; }

        public int TotalRows { get; set; }

        public string Search { get; set; }

        public int TotalPages {
            get
            {
                return TotalRows / RowsPerPage;
            }
        }

        public List<int> GetPages()
        {
            List<int> pages = new List<int>();

            for (int i = 1; i <= TotalPages; i++)
            {
                pages.Add(i);
            }

            return pages;
        }
    }
}