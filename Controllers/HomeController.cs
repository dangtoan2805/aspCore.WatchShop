using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using aspCore.WatchShop.Models;
using aspCore.WatchShop.EF;

namespace aspCore.WatchShop.Controllers
{
    public class HomeController : Controller
    {
        private watchContext _context=null;
        public HomeController(watchContext context)
        {
            _context=context;
        }

        public IActionResult Index()
        {
            // ViewBag.PromotionWatch =  await product.GetProductsBy(Instances.PROMOTION, 1 , Wires.ALL, Sorts.NO, 4);
            // ViewBag.MenWatch = await product.GetProductsBy(Instances.CATEGORY,Cates.MEN, Wires.ALL,Sorts.NO,4);
            // ViewBag.WomenWatch = await product.GetProductsBy(Instances.CATEGORY,Cates.WOMEN, Wires.ALL, Sorts.NO,4);
            ViewBag.PromotionWatch = _context.Products.Take(4).ToList();
            ViewBag.MenWatch = _context.Products.Take(4).ToList();
            ViewBag.WomenWatch = _context.Products.Take(4).ToList();

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
