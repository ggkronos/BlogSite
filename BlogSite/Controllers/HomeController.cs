using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BlogSite.Models;

namespace BlogSite.Controllers
{
    public class HomeController : Controller
    {

        private BlogContext context = new BlogContext();



        // GET: Home
        public ActionResult Index()
        {
            return View(context.Blogs.ToList());
        }
    }
}