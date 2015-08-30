using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Data;
using Blog.Models;
using Aplication.Abstractions;


namespace Blog.Controllers
{
    public class HomeController : Controller
    {
        BlogDBEntities db = new BlogDBEntities();
        private readonly IHomeService _homeService;

        public HomeController(IHomeService homeService)
        {
            _homeService = homeService;
        }

        public ActionResult Index()
        {
            var _model = _homeService.getAllPosts();

            AutoMapper.Mapper.CreateMap<Post, PostViewModel>();

            var _postViewModel = AutoMapper.Mapper.Map<IList<Post>, IList<PostViewModel>>(_model);

            return View("~/Views/Blog/Index.cshtml", _postViewModel);
        }

        public ActionResult TagsCloud()
        {
            var _model = _homeService.getAllTags();

            AutoMapper.Mapper.CreateMap<Tag, TagViewModel>();

            var _postViewModel = AutoMapper.Mapper.Map<IList<Tag>, IList<TagViewModel>>(_model);

            return PartialView("~/Views/Shared/_TagsCloud.cshtml", _postViewModel);
        }

        public ActionResult Detail(int id)
        {
            var _model = _homeService.getAllPosts().Where(x => x.id_post == id).First();

            AutoMapper.Mapper.CreateMap<Post, PostViewModel>();

            var _postViewModel = AutoMapper.Mapper.Map<Post, PostViewModel>(_model);

            return View("~/Views/Blog/Detail.cshtml", _postViewModel);
        }
    }
}
