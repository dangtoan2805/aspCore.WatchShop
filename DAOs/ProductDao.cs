using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using aspCore.WatchShop.EF;
using aspCore.WatchShop.Entities;

namespace aspCore.WatchShop.DAOs
{
    public class ProductDao
    {
        private watchContext _db = null;

        public ProductDao(watchContext context)
        {
            _db = context;
        }

        public List<Category> GetCategories()
        {
            return _db.Categories.ToList();
        }

        public List<TypeWire> GetTypeWires()
        {
            return _db.TypeWires.ToList();
        }

        public List<Product> GetProducts()
        {
            return _db.Products.Where(item => item.isDel == false).ToList();
        }

        public List<Product> GetProductsByCate(int id)
        {
            return _db.Products.Where(item => item.CategoryID == id).ToList();
        }

        public List<Product> GetProductsByWire(int id)
        {
            return _db.Products.Where(item => item.TypeWireID == id).ToList();
        }

        public Product GetProductDetail(int id)
        {
            return _db.Products
                .Where(item => item.ID == id)
                .Include(p => p.ProductDetail)
                .FirstOrDefault();
        }

        public Product FindProductByID(int id)
        {
            return _db.Products
                .Where(item => item.ID == id)
                .FirstOrDefault();
        }

        public Object GetAllProductWithCategory()
        {
            DateTime time = DateTime.Now;
            return _db.Promotions
                .Where(item => item.Status == false
                        && item.ToDate >= time && item.FromDate <= time).ToList();
        }

        public List<Promotion> GetProductsPromotion(DateTime time)
        {
            return _db.Promotions
                .Where(item => item.Status == true && item.TypePromotion == false
                        && item.ToDate >= time && item.FromDate <= time)
                .Include(item => item.PromotionDetail)
                .ToList();
        }

        public void DeleteProduct(int id)
        {
            Product p = _db.Products.Find(id);
            if (p != null)
                p.isDel = true;
            _db.SaveChanges();
        }

        public void AddProduct(Product product, ProductDetail detail)
        {
            Product obj = _db.Products.Where(p => p.ID == product.ID).FirstOrDefault();
            if (obj != null) return;
            _db.Products.Add(product);
            _db.SaveChanges();
            detail.ProductID = _db.Products.Select(p => p.ID).ToList().Max();
            _db.ProductDetails.Add(detail);
            _db.SaveChanges();
        }

        public void UpdateProduct(Product product, ProductDetail detail)
        {
            var obj = _db.Products.Where(p => p.ID == product.ID).FirstOrDefault();
            if (obj == null) return;
            ChangeProductData(obj, product);
            ProductDetail productDetail = _db.ProductDetails.Where(p => p.ProductID == obj.ID).FirstOrDefault();
            ChangeDetailData(productDetail, detail);
            _db.SaveChanges();
        }

        public void UpdateStatusProduct(int id, bool isShow)
        {
            Product p = _db.Products.Find(id);
            if (p != null)
                p.isShow = isShow;
            _db.SaveChanges();
        }

        public void ChangeProductData(Product A, Product B)
        {
            A.Name = B.Name;
            A.isShow = B.isShow;
            A.Price = B.Price;
            A.Image = B.Image;
            A.CategoryID = B.CategoryID;
            A.TypeWireID = B.TypeWireID;
        }

        public void ChangeDetailData(ProductDetail A, ProductDetail B)
        {
            A.Images = B.Images;

            A.TypeGlass = B.TypeGlass;

            A.TypeBorder = B.TypeBorder;

            A.TypeMachine = B.TypeMachine;

            A.Parameter = B.Parameter;

            A.ResistWater = B.ResistWater;

            A.Warranty = B.Warranty;

            A.Brand = B.Brand;

            A.Origin = B.Origin;

            A.Color = B.Color;

            A.Func = B.Func;

            A.DescriptionProduct = B.DescriptionProduct;
        }
    }
}
