using System;
using System.Linq;
using System.Collections.Generic;
using System.IO;
using aspCore.WatchShop.Entities;
using aspCore.WatchShop.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using aspCore.WatchShop.DAOs;
using aspCore.WatchShop.EF;
using aspCore.WatchShop.Helper;

namespace aspCore.WatchShop.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductController : Controller
    {
        const string productKey = "products";
        const string cateKey = "cates";
        const string wireKey = "wires";
        private IMemoryCache _cache = null;
        private ProductDao _db = null;
        public ProductController(IMemoryCache cache, watchContext context)
        {
            _cache = cache;
            _db = new ProductDao(context);
        }

        // HTML, Categotys. Wires
        public ActionResult Index()
        {
            ViewBag.Category = GetCategories();
            ViewBag.Wires = GetTypeWires();
            return View();
        }

        // return new List(), count = 0 if not found
        public JsonResult Products(int indexCate, int indexWire, int pageItems)
        {
            List<ProductVM> ls = _db.GetProducts();
            return Json(new object[] { ls.Take(pageItems), ls.Count });
        }

        // return new List(), count = 0 if not found
        public JsonResult OrderByStatus(int index, int pageItems)
        {
            return null;
        }

        public JsonResult OrderByCost(int index, int pageItems)
        {
            return null;
        }

        // List Product
        public JsonResult Page(int number, int pageItems)
        {
            return Json(Helpful.GetPage(_db.GetProducts(), number, pageItems));
        }

        // List Product
        public JsonResult Find(string key, int pageItems)
        {
            List<ProductVM> re = (List<ProductVM>)_db.GetProducts()
                .Where(p => p.ID.ToString() == key || p.Name == key).ToList();
            return Json(re);
        }

        // Category, Wire, Image, ProducDetai;
        public ActionResult Detail(int id)
        {
            return RedirectToAction("Product", FindProductByID(id));
        }

        public ActionResult Create()
        {
            return RedirectToAction("ProductForm", new ProductVM() { ID = -1 });
        }

        public ActionResult Product(ProductVM p)
        {
            ViewBag.Category = GetCategories();
            ViewBag.Wires = GetTypeWires();
            ViewBag.Props = new ProductDetail().GetType().GetProperties().Select(o => o.Name).ToArray();
            return View("ProductDetail", p);
        }

        // Category, Wire,
        public void UpdateStatus(int id, int indexStatus)
        {

        }

        //******** Detail Page *******//
        public ActionResult Submit(ProductVM p, string Files)
        {
            if (p.ID != -1)
            {
                //Update data in Database
            }
            else
            {
                // Add data base
            }
            return RedirectToAction("Index");
        }

        public string UploadImage(int id, IFormFile img)
        {
            if (img != null)
            {
                string path = Path.Combine(Directory.GetCurrentDirectory(), @"wwwroot\product", img.FileName);
                img.CopyToAsync(new FileStream(path, FileMode.Create));
                FindProductByID(id).AddImage(img.FileName);
                return img.FileName;
            }
            return "";
        }

        public JsonResult GetImages(int id)
        {
            return Json(FindProductByID(id).GetImages());
        }

        public ActionResult Delete(int id)
        {
            // list.Remove(FindProductByID(id));
            return RedirectToAction("Index");
        }

        [NonAction]
        public ProductVM FindProductByID(int id)
        {
            ProductVM p = _db.GetProducts().Find(p => p.ID == id);
            if (p != null) return p;
            return new ProductVM() { ID = 9999 };
        }

        [NonAction]
        public List<Category> GetCategories()
        {
            List<Category> ls;
            if (!_cache.TryGetValue(cateKey, out ls))
            {
                ls = _db.GetCategories();
                _cache.Set(cateKey, ls, DateTime.MaxValue);
            }
            return ls;
        }

        [NonAction]
        public List<TypeWire> GetTypeWires()
        {
            List<TypeWire> ls;
            if (!_cache.TryGetValue(wireKey, out ls))
            {
                ls = _db.GetTypeWires();
                _cache.Set(wireKey, ls, DateTime.MaxValue);
            }
            return ls;
        }


    }
}