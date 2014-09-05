using Blog.Core;
using StructureMap;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Blog.Site.Controllers
{
    public class BaseController : Controller
    {
        public IBlogService blogService
        {
            get
            {
                if (_blogService == null)
                {
                    _blogService = ObjectFactory.GetInstance<IBlogService>();
                }
                return _blogService;
            }
        } private IBlogService _blogService;

        const int PAGE_SIZE = 20;
    }
}
