using BookGallery.Models;
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

            var book = new Book()
            {
                Title = "1984",
                Author = "G Orwell",
                DescriptionHtml = "An overview of how a society can be run",
                Awards = new Awards[]
                {
                    new Awards() {Name = "Best Movie", Year = "1999"}
                }


            };


            return View(book);
        }
    }
}