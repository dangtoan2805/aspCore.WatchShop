using System;
using System.Linq;
using aspCore.WatchShop.EF;
using aspCore.WatchShop.Models;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;

namespace aspCore.WatchShop.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HomeController : Controller
    {
        private OrderModel _model;

        public HomeController(watchContext context, IMemoryCache cache, IMapper mapper)
        {
            _model = new OrderModel(context, mapper, cache);
        }
        public ActionResult Index()
        {
            var data = _model.GetCountStatus();
            ViewBag.Dones = data.Item1;
            ViewBag.Deliverys = data.Item3;
            ViewBag.Received = data.Item2;
            ViewBag.TotalRevenue = data.Item4;
            return View();
        }

        public JsonResult OrderReport(string start, string end)
        {
            return Json(_model.GetReport(start, end));
        }

    }
}