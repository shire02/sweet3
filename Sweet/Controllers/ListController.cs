using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Sweet.Models;
using System.ComponentModel.DataAnnotations;


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
        [Authorize(Users = "henok_afro@yahoo.com")]
        public ActionResult List(string searchBy, string search)
        {

            return View(db.NewTickets.ToList());


            //    if (searchBy == "Status")
            //  {
            // return View(db.NewTickets.Where(x => x.Status == 0 || search == null).ToList());
            // }
            //else
            // {
            //     return View(db.NewTickets.Where(x => x.Status = "Close Ticket").ToList());
            // }



        }
    }
}