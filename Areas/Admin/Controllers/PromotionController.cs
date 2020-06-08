using System.Diagnostics;
using aspCore.WatchShop.Models;
using Microsoft.AspNetCore.Mvc;

namespace aspCore.WatchShop.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class PromotionController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Detail()
        {
            return View();
        }
    }
}