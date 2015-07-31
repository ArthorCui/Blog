﻿using Blog.Model;
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
            PagedList<Talk> list = blogService.GetPaged<Talk>("CreatedDate desc", pageNum, PAGE_SIZE);
            ViewData["talklist"] = list;
            ViewData["pageNum"] = pageNum;
            ViewData["toatalCount"] = list.Count;

            return View(list);
        }

        public ActionResult Search(string keywords, int? page)
        {
            int pageNum = page.HasValue ? page.Value : 0;
            var list = blogService.Where<Talk>(x => x.Content.Contains(keywords)).ToPagedList(pageNum, PAGE_SIZE);
            ViewData["talklist"] = list;
            ViewData["pageNum"] = pageNum;

            return View(list);
        }

        [HttpGet]
        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add(Talk model)
        {
            var ret = blogService.Add<Talk>(model);
            return RedirectToAction("List");
        }

        [HttpGet]
        public ActionResult Edit(int talkId)
        {
            ViewData["IsUpdate"] = true;
            var talk = blogService.Single<Talk>(talkId);
            return View("Add", talk);
        }

        [HttpPost]
        public ActionResult Edit(Talk model)
        {
            var talk = blogService.Single<Talk>(model.Id);
            talk.Content = model.Content;
            talk.LastModifiedDate = DateTime.Now;
            var ret = blogService.Update<Talk>(talk);

            return RedirectToAction("List");
        }

        public ActionResult Delete(int talkId)
        {
            var talk = blogService.Delete<Talk>(talkId);
            return RedirectToAction("List");
        }

    }
}
