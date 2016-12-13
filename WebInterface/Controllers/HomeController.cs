using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DataAccess;
using Context;
using WebInterface.Models;

namespace WebInterface.Controllers
{
    public class HomeController : Controller
    {
        private DataEntry _dataEntry = new DataEntry();
        private const int ROWS_PER_PAGE = 1;

        // GET: Home
        public ActionResult Index(int page = 1, string search = "")
        {
            int totalRows = 0;
            
            Pagination<Entry> pagination = new Pagination<Entry>();
            pagination.Items = _dataEntry.Page(page, ROWS_PER_PAGE, search, out totalRows);
            pagination.PageNumber = page;
            pagination.RowsPerPage = ROWS_PER_PAGE;
            pagination.TotalRows = totalRows;
            pagination.Search = search;

            return View(pagination);
        }
        
        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add(Entry pEntry)
        {
            if (ModelState.IsValid)
            {
                pEntry.CreationDate = DateTime.Now;

                _dataEntry.Insert(pEntry);

                return RedirectToAction("Index");
            }

            return View(pEntry);
        }

    }
}