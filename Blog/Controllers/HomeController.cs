using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Data;

namespace Blog.Controllers
{
    public class HomeController : Controller
    {
        // GET: /Home/
        BlogDBEntities db = new BlogDBEntities();

        public ActionResult Index()
        {
            var _model = db.Posts.ToList();

            return View(_model);
        }

    }
}
