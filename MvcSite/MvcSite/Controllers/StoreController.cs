using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcSite.Models
{
    public class StoreController : Controller
    {
        //
        // GET: /Store/
        public ActionResult Index()
        {
            List<God> gods = new List<God>
            {
                new God
                {
                    Name = "李金",
                    Age = "26"
                }
            };
            //ViewBag.Gods = gods;

            return View(gods);
        }

        public string Browse(string genre)
        {
            //return "Hello World, Genre = " + genre;
            return HttpUtility.HtmlEncode("Hello World, Genre = " + genre);
        }

        public ActionResult Detail()
        {
            return View("Index");
        }

        public ActionResult AboutMe()
        {
            return View();
        }
    }

    public class God
    {
        public string Name;
        public string Age;
    }

    public class Person
    {
        public string Name;
    }
}
