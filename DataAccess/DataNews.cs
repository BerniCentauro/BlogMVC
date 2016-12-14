using Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class DataNews
    {
        public List<News> SelectAll()
        {
            using (BlogModel ctx = new BlogModel())
            {
                List<News> newsList = ctx.News.ToList();

                return newsList;
            }
        }
    }
}
