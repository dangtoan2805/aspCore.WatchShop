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
            var data = _context.Products.ToList();
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
