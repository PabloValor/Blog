using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Data;
using Blog.Models;

namespace Blog.Controllers
{
    public class HomeController : Controller
    {
        BlogDBEntities db = new BlogDBEntities();

        public ActionResult Index()
        {
            var _model = db.Posts.ToList();

            AutoMapper.Mapper.CreateMap<Post, PostViewModel>();

            var _postViewModel = AutoMapper.Mapper.Map<IList<Post>, IList<PostViewModel>>(_model);

            return View("~/Views/Blog/Index.cshtml", _postViewModel);
        }

        public ActionResult TagsCloud()
        {
            var _model = db.Tags.ToList();

            AutoMapper.Mapper.CreateMap<Tag, TagViewModel>();

            var _postViewModel = AutoMapper.Mapper.Map<IList<Tag>, IList<TagViewModel>>(_model);

            return PartialView("~/Views/Shared/_TagsCloud.cshtml", _postViewModel);
        }

        public ActionResult Detail(int id)
        {
            var _model = db.Posts.Where(x => x.id_post == id).First();

            return View("~/Views/Blog/Detail.cshtml", _model);
        }
    }
}
