using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Sweet.Models;

namespace Sweet.Controllers
{
    public class ListController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: List
       public ActionResult Index()
        {
           return View();
        }
        [Authorize (Users ="henok_afro@yahoo.com")]
        public ActionResult List(string Filter, string searchString, int? page)
        {

            if (searchString != null)
            {
                page = 1;
            }
            else
            {
                searchString = Filter;
            }

            ViewBag.CurrentFilter = searchString;

            var tickets = from t in db.NewTickets
                           select t;
            if (!String.IsNullOrEmpty(searchString))
            {
                 tickets= tickets.Where(t => t.Email.Contains(searchString)
                                       || t.UserName.Contains(searchString));
            }
            return View(db.NewTickets.ToList());

        }
    }
}