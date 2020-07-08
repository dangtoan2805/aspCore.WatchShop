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
using AutoMapper;

namespace aspCore.WatchShop.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class OrderController : Controller
    {
        private OrderModel _model = null;

        public OrderController(IMemoryCache cache, watchContext context, IMapper mapper)
        {
            _model = new OrderModel(context, mapper, cache);
        }

        public ActionResult Index() => View();

        // return new List() if not found
        public JsonResult Find(string key)
        {
            return Json(_model.FindOrder(key));
        }

        // return new List() if not found
        public JsonResult Orders(string start, string end)
        {
            return Json(_model.GetOrders(start, end));
        }

        public NoContentResult UpdateStatus(int orderID, int index)
        {
            _model.UpdateStatus(orderID, index);
            return NoContent();
        }

        //return null is not found
        public JsonResult Detail(int id)
        {
            return Json(_model.GetDetail(id));
        }
    }
}