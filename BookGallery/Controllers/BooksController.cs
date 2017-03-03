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
            if (DateTime.Today.DayOfWeek == DayOfWeek.Friday)
            {
                return Redirect("/");
            }
               return Content("Hello World");
        }
    }
}