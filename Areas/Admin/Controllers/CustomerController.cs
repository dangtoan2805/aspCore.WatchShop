using Microsoft.AspNetCore.Mvc;

namespace aspCore.WatchShop.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CustomerController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}