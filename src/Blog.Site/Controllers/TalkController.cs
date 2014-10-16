using Blog.Model;
using SubSonic.Schema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Blog.Site.Controllers
{
    /// <summary>
    /// Talk
    /// 树洞和说说控制器
    /// </summary>
    public class TalkController : BaseController
    {
        public ActionResult List(int? page)
        {
            int pageNum = page.HasValue ? page.Value : 0;
            //PagedList<Talk> list = blogService.GetPaged<Talk>("CreatedDate desc", pageNum, 20);
            //ViewData["talklist"] = list;
            //ViewData["pageNum"] = pageNum;
            //return View(list);
            return View();
        }

    }
}
