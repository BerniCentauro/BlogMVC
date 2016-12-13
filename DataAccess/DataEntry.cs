using Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class DataEntry
    {
        public List<Entry> Page(int pageNumber, int rowsPerPage, string search, out int totalRows)
        {
            using(BlogModel ctx = new BlogModel())
            {
                List<Entry> entries = ctx.Entry
                    .Where(entry => entry.Content.Contains(search))
                    .ToList();

                totalRows = entries.Count;

                entries = entries
                    .Skip((pageNumber - 1) * rowsPerPage)
                    .Take(rowsPerPage)
                    .ToList();

                return entries;
            }
        }

        public void Insert(Entry entry)
        {
            using(BlogModel ctx = new BlogModel())
            {
                ctx.Entry.Add(entry);
                ctx.SaveChanges();
            }
        }
    }
}
