using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MorningNewsPaper.Models;
using MorningNewsPaper.ViewModels;

namespace MorningNewsPaper.Controllers
{
    public class HomeController : Controller, MyServices
    {
        public IActionResult Index()
        {
            return View();
        }
        NewsInfoContext myCtx;
        public HomeController(NewsInfoContext ctx)
        {
            myCtx = ctx;
        }
        // Get
        public IActionResult Get()
        {
            return Json(myCtx.NewsInfos.ToList());
        }

        // Create 
        [HttpPost]
        public IActionResult Create([FromBody]NewsInfoVM vm)
        {
            NewsInfo nw = new NewsInfo();
            nw.title = vm.title;
            nw.description = vm.description;
            myCtx.NewsInfos.Add(nw);
            myCtx.SaveChanges();
            return Json(true);
        }

        // Edit
        [HttpPost]
        public IActionResult Edit(int id, [FromBody]NewsInfo nw)
        {
            var a = (from n in myCtx.NewsInfos where id == n.id select n).First();
            a.title = nw.title;
            a.description = nw.description;
            myCtx.SaveChanges();
            return Json(true);
        }

        // Delete
        public IActionResult Delete(int id)
        {
            myCtx.NewsInfos.Remove(myCtx.NewsInfos.Find(id));
            myCtx.SaveChanges();
            return Json(true);
        }
    }
}