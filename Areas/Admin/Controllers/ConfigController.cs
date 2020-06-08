using Microsoft.AspNetCore.Mvc;

namespace aspCore.WatchShop.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ConfigController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}