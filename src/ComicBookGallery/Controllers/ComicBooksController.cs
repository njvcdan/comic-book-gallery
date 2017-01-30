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
            ViewBag.SeriesTitle = "Title";
            ViewBag.IssueNumber = 700;
            ViewBag.Description = "<p>Final issue! <strong>Will Peter?!?!?!</strong></p>";
            ViewBag.Artists = new String[]
            {
                "Script: Name Name",
                "Story: Story Name",
                "Edits: Edits Name"
            };

            return View();
        }
    }
}