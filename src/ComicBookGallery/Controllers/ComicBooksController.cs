using ComicBookGallery.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ComicBookGallery.Controllers
{
    public class ComicBooksController: Controller
    {
        public ActionResult Detail()
        {
            var comicBook = new ComicBook()
            {
                SeriesTitle = "The Amazing Spider Man",
                IssueNumber = 700,
                DescriptionHtml = "<p>Final issue! <strong>Will Peter?!?!?!</strong></p>",
                Artists = new Artist[]
                {
                    new Artist() { Name = "Jon Jon", Role = "Script"},
                    new Artist() { Name = "Thom Thom", Role = "Story"},
                    new Artist() { Name = "Bob Bob", Role = "Edits"}
                }
            };

            return View(comicBook);
        }
    }
}