using Microsoft.AspNetCore.Mvc;

namespace aspCore.WatchShop.Areas.Admin.Controllers
{
    public class OrderController : Controller
    {
        [Area("Admin")]
        public ActionResult Index()
        {
            return View();
        }

    }
}