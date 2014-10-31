using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Blog.Site.Controllers
{
    /// <summary>
    /// Blog, Note, Diary
    /// 博客和日记控制器
    /// </summary>
    public class PostController : BaseController
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}
