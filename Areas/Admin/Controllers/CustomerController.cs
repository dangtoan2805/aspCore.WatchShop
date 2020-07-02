using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using aspCore.WatchShop.Entities;
using Microsoft.Extensions.Caching.Memory;
using aspCore.WatchShop.DAOs;
using aspCore.WatchShop.EF;
using System;
using System.Linq;
using aspCore.WatchShop.Helper;

namespace aspCore.WatchShop.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CustomerController : Controller
    {
        const string customerKey = "customers";
        private IMemoryCache _cache = null;
        private CustomerDao _db = null;
        public CustomerController(IMemoryCache cache, watchContext context)
        {
            _cache = cache;
            _db = new CustomerDao(context);
        }
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult Customers(int pageItems)
        {
            List<Customer> ls = GetCustomers();
            return Json(new List<object>() { ls.Take(pageItems), ls.Count });
        }

        public JsonResult Page(int number, int pageItems)
        {
            return Json(Helpful.GetPage(GetCustomers(), number, pageItems));
        }

        public JsonResult Find(string key, int pageItems)
        {
            List<Customer> re = (List<Customer>)_db.GetCusomters()
               .Where(p => p.Phone.ToString() == key || p.Name == key).ToList();
            return Json(re);
        }

        [NonAction]
        public List<Customer> GetCustomers()
        {
            List<Customer> ls;
            if (!_cache.TryGetValue(customerKey, out ls))
            {
                ls = _db.GetCusomters();
                _cache.Set(customerKey, ls, DateTime.MaxValue);
            }
            return ls;
        }
    }
}