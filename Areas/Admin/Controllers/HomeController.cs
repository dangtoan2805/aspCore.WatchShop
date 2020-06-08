using Microsoft.AspNetCore.Mvc;

namespace aspCore.WatchShop.Areas.Admin.Controllers
{
    public class HomeController : Controller
    {
        [Area("Admin")]
        public ActionResult Index()
        {

            return View();
        }

    }
}