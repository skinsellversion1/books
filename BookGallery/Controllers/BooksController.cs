using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BookGallery.Controllers
{
    public class BooksController : Controller
    {


        // GET: Books
        public ActionResult Detail()
        {
            ViewBag.title = "1984";
            ViewBag.author = "G Orwell";
            ViewBag.description = "An overview of how a society can be run";
            ViewBag.awards = new String[]
                {
                "Best book 2016",
                "Best book 1999",
                "Best book 1996"
                };

            return View();
        }
    }
}