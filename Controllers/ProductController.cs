using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using aspCore.WatchShop.DAOs;
using aspCore.WatchShop.EF;
using aspCore.WatchShop.Enums;
using aspCore.WatchShop.Models;

namespace aspCore.WatchShop.Controllers
{
    public class ProductController : Controller
    {
        // private ProductDao _product = null;
        private watchContext _context = null;
        private static int _keyCurr;
        private static int _instanCurr;
        // private static int _wireIDCurr = Wires.ALL;
        // private static int _sortCurr = Sorts.NO;
        public ProductController(watchContext context)
        {
            _context = context;
        }

        public async Task<List<ProductVM>> Search(string key)
        {
            // return await _product.FindProductWithKey(key, 5);
            return null;
        }

        public ActionResult ProductDetail(int id)
        {
            // ProductVM p= await _product.GetProductById(id);
            // return View(p);
            var p = _context.Products.Find(id);
            return View(p);
        }

        public ActionResult Products(int id)
        {
            // if (id == 0)
            //     id = _keyCurr;
            // _instanCurr = Instances.CATEGORY;
            // _keyCurr = id;
            // _wireIDCurr = Wires.ALL;
            //var tuple = await _product.GetPagesOf(_instanCurr, _keyCurr, _wireIDCurr);
            //ViewBag.Pages = tuple.Item1;
            //ViewBag.Items = tuple.Item2;
            return View();
        }

        public async Task<ActionResult> DiscountProducts()
        {
            // _instanCurr = Instances.PROMOTION;
            // _keyCurr = 1; 
            // var tuple = await _product.GetPagesOf(_instanCurr, _keyCurr, _wireIDCurr);
            // ViewBag.Pages = tuple.Item1;
            // ViewBag.Items = tuple.Item2;
            return View("Products");
        }

        public JsonResult GetProducts()
        {
            // List<object> a = new List<object>();
            // var tuple = await _product.GetPagesOf(_instanCurr, _keyCurr, _wireIDCurr);
            // a.Add(tuple.Item1);
            // a.Add(tuple.Item2);
            // a.Add(await _product.GetProductRange(_instanCurr, _keyCurr, _wireIDCurr, _sortCurr, 0));
            // return Json(a);

            List<object> a = new List<object>();
            a.Add(5);
            a.Add(5);
            a.Add(_context.Products.Take(10).ToList());
            return Json(a);
        }

        public async Task<JsonResult> Page(int page = 1)
        {
            // return Json(await _product.GetProductRange(_instanCurr, _keyCurr, _wireIDCurr, _sortCurr, page - 1));
            return null;
        }

        public void GetProductsSort(int sort)
        {
            // _sortCurr = sort;
        }

        public void GetProductsWire(int wireID)
        {
            // _wireIDCurr = wireID;

        }

        public ActionResult Filter()
        {
            return View();
        }
    }
}