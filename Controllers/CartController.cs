using Microsoft.AspNetCore.Mvc;
using aspCore.WatchShop.DAOs;
using aspCore.WatchShop.EF;
using aspCore.WatchShop.Enums;
using aspCore.WatchShop.Models;

namespace aspCore.WatchShop.Controllers
{
    public class CartController : Controller
    {
        public ActionResult Index()
        {

            return View();
        }
    }
}