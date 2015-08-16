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
        BlogDBEntities db = new BlogDBEntities();

        public ActionResult Index()
        {
            var _model = db.Posts.ToList();

            return View("~/Views/Blog/Index.cshtml", _model);
        }

        public ActionResult Detail(int id)
        {
            var _model = db.Posts.Where(x => x.id_post == id).First(); 

            return View("~/Views/Blog/Detail.cshtml", _model);
        }

    }
}
