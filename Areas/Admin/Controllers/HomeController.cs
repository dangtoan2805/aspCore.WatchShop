using System;
using System.Collections.Generic;
using System.Linq;
using aspCore.WatchShop.EF;
using aspCore.WatchShop.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching;
using Microsoft.Extensions.Caching.Memory;

namespace aspCore.WatchShop.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HomeController : Controller
    {
        private watchContext _db = null;
        private IMemoryCache _cache;

        public HomeController(watchContext context, IMemoryCache memory)
        {
            _db = context;
            _cache = memory;
        }
        public ActionResult Index()
        {

            ViewBag.Dones = 100;
            ViewBag.Deliverys = 20;
            ViewBag.Received = 30;
            ViewBag.TotalRevenue = 1000;
            _cache.Set("Hello", DateTime.Now, DateTime.MaxValue);
            return View();
        }

        public JsonResult OrderReport(string start, string end)
        {
            var obj = Json(_db.Products.ToList());
            return obj;
        }

    }
}