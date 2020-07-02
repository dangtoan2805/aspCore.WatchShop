using System.Linq;
using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using aspCore.WatchShop.DAOs;
using aspCore.WatchShop.Entities;
using aspCore.WatchShop.Helper;
using aspCore.WatchShop.EF;
using aspCore.WatchShop.Models;

namespace aspCore.WatchShop.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class OrderController : Controller
    {
        const string ordersKey = "orders";
        private IMemoryCache _cache = null;
        private OrderModel model = null;

        public OrderController(IMemoryCache cache, watchContext context)
        {
            _cache = cache;
            model = new OrderModel(context);
        }


        public ActionResult Index() => View();

        // return new List() if not found
        public JsonResult Find(string key, int pageItems)
        {
            List<OrderVM> result = SetInCache(model.FindOrder(key));
            return Json(Helpful.ToResult(result, pageItems));

        }

        // return new List() if not found
        public JsonResult Orders(string start, string end, int pageItems)
        {
            List<OrderVM> result = SetInCache(model.GetListViewData(start, end));
            return Json(Helpful.ToResult(result, pageItems));
        }

        public NoContentResult UpdateStatus(int orderID, int index)
        {
            model.UpdateStatus(orderID, index);
            return null;
        }

        public JsonResult OrderByCost(int index, int pageItems)
        {
            List<OrderVM> result = GetInCache();
            if (result != null)
            {
                if (index == 0)
                    result = result.OrderBy(item => item.Total).ToList();
                else
                    result = result.OrderByDescending(item => item.Total).ToList();
            }
            else
                result = new List<OrderVM>();
            return Json(Helpful.ToResult(result, pageItems));
        }

        public JsonResult FilterByStatus(int index, int pageItems)
        {
            List<OrderVM> result = GetInCache();
            if (result != null)
            {
                result = result.Where(item => item.Status == index).ToList();
                if (result == null)
                    result = new List<OrderVM>();
            }
            else
                result = new List<OrderVM>();
            return Json(Helpful.ToResult(result, pageItems));
        }

        public JsonResult Page(int number, int pageItems)
        {
            List<OrderVM> result = GetInCache();
            return Json(Helpful.ToResult(Helpful.GetPage(result, number, pageItems), pageItems));
        }

        //return null is not found
        public JsonResult Detail(int id)
        {
            return Json(model.GetViewDetail(id));
        }

        [NonAction]
        public List<OrderVM> GetInCache()
        {
            return CacheData.GetData<List<OrderVM>>(_cache, ordersKey);
        }

        [NonAction]
        public List<OrderVM> SetInCache(List<OrderVM> modelData)
        {
            if (modelData == null)
                return new List<OrderVM>();
            CacheData.SetData(_cache, ordersKey, modelData);
            return modelData;
        }

    }
}