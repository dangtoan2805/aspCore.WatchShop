using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using aspCore.WatchShop.EF;
using aspCore.WatchShop.Entities;
using aspCore.WatchShop.Enums;
using aspCore.WatchShop.Models;

namespace aspCore.WatchShop.DAOs
{
    public class ProductDao
    {
        private int _itemPage = 16;
        private static int _pageCount = 0;
        private static int _itemCount = 0;
        private watchContext _db = null;

        public ProductDao(watchContext context)
        {
            _db = context;
        }

        // public async Task CountItemsOf(int instan, int key, int wireID)
        // {
        //     _itemCount = 0;
        //     if (wireID == 0)
        //         switch (instan)
        //         {
        //             case Instances.CATEGORY:
        //                 _itemCount = await _db.Products.Where(p => p.CategoryID == key).CountAsync();
        //                 break;
        //             case Instances.PROMOTION:
        //                 _itemCount = await _db.Products.Where(p => p.PromotionID == key).CountAsync();
        //                 break;
        //             case Instances.PROMOTIONALL:
        //                 _itemCount = await _db.Products.Where(p => p.PromotionID != 1).CountAsync();
        //                 break;
        //         }
        //     else
        //         switch (instan)
        //         {
        //             case Instances.CATEGORY:
        //                 _itemCount = await _db.Products.Where(p => p.CategoryID == key && p.isShow == true && p.TypeWireID == wireID).CountAsync();
        //                 break;
        //             case Instances.PROMOTION:
        //                 _itemCount = await _db.Products.Where(p => p.PromotionID == key && p.isShow == true && p.TypeWireID == wireID).CountAsync();
        //                 break;
        //             case Instances.PROMOTIONALL:
        //                 _itemCount = await _db.Products.Where(p => p.PromotionID != 1 && p.isShow == true && p.TypeWireID == wireID).CountAsync();
        //                 break;
        //         }
        // }

        // public async Task<(int, int)> GetPagesOf(int e, int key, int wireID)
        // {
        //     await CountItemsOf(e, key, wireID);
        //     _pageCount = 0;
        //     if (_itemCount > 0)
        //     {
        //         _pageCount = _itemCount / _itemPage;
        //         _pageCount--;
        //         if (_pageCount % _itemPage != 0)
        //             _pageCount++;
        //         return (_pageCount, _itemCount);
        //     }
        //     else
        //         return (-1, _itemCount);
        // }

        // public async Task<List<ProductVM>> GetProductsBy(int instan, int key, int wireID, int sort, int size, int skip = 0)
        // {           
        //     //Filter Data
        //     IQueryable<Product> data;
        //     switch (instan)
        //     {
        //         case Instances.CATEGORY:
        //             if (wireID == 0)
        //                 data = _db.Products.Where(p => p.CategoryID == key && p.isShow == true);
        //             else
        //                 data = _db.Products.Where(p => p.CategoryID == key && p.isShow == true && p.TypeWireID == wireID);
        //             break;
        //         case Instances.PROMOTION:
        //             if (wireID == 0)
        //                 data = _db.Products.Where(p => p.PromotionID == key && p.isShow == true);
        //             else
        //                 data = _db.Products.Where(p => p.PromotionID == key && p.isShow == true && p.TypeWireID == wireID);
        //             break;
        //         case Instances.PROMOTIONALL:
        //             if (wireID == 0)
        //                 data = _db.Products.Where(p => p.PromotionID != 1 && p.isShow == true);
        //             else
        //                 data = _db.Products.Where(p => p.PromotionID != 1 && p.isShow == true && p.TypeWireID == wireID); 
        //             break;
        //         default:
        //             data = null;
        //             break;                        
        //     }
        //     //Get Amount Item
        //     if (_itemCount == 0)
        //         _itemCount = data.Count();
        //     //PrePaging
        //     List<ProductVM> lsVM = new List<ProductVM>();
        //     if (size <= 0)
        //         return lsVM;
        //     int takeItems = size;
        //     int skipItems = skip * _itemPage;
        //     int restItems = _itemCount - skipItems;
        //     if (restItems < 16 && restItems > 0)
        //         takeItems = restItems;

        //         //Orther Data
        //         if (sort != 0)
        //     {
        //         switch (sort)
        //         {
        //             case Sorts.PRICEUP:
        //                 data.OrderBy(p => p.Price);
        //                 break;
        //             case Sorts.PRICEDOWN:
        //                 data.OrderByDescending(p => p.Price);
        //                 break;
        //             case Sorts.DISCOUNT:
        //                 data.OrderBy(p => p.PricePromotion);
        //                 break;
        //             case Sorts.SALECOUNT:
        //                 data.OrderBy(p => p.SaleCount);
        //                 break;
        //         }
        //     }
        //     // Paging and Mapping data
        //     await data.Skip(skipItems)
        //             .Take(takeItems)
        //             .Include(p => p.Category)
        //             .Include(p => p.ProductDetail)
        //             .Include(p => p.Images)
        //             .AsNoTracking()
        //             .ForEachAsync(p =>
        //             {
        //                 lsVM.Add(new ProductVM(p));
        //             });   
        //     return lsVM;
        // }

        // public async Task<List<ProductVM>> FindProductWithKey(string key,int mumberResultReturn)
        // {
        //     List<ProductVM> lsVM = new List<ProductVM>();
        //     await _db.Products.Include(p => p.Category)
        //                     .Include(p => p.ProductDetail)
        //                     .Include(p => p.Images)
        //                     .AsNoTracking()
        //                     .Where(p => p.Name.Contains(key) || p.ProductDetail.Brand.Contains(key))
        //                     .ForEachAsync(p => {
        //                         lsVM.Add(new ProductVM(p));
        //                     });
        //     if (mumberResultReturn == 0)
        //         return lsVM;
        //     else
        //         return lsVM.Take(mumberResultReturn).ToList();
        // }

        // public async Task<ProductVM> GetProductById(int id)
        // {
        //     var p = await _db.Products.Where(p => p.ID == id)
        //                     .Include(p => p.Category)
        //                     .Include(p => p.ProductDetail)
        //                     .Include(p => p.Images)
        //                     .AsNoTracking()
        //                     .FirstAsync();      
        //     return new ProductVM(p);
                                                     
        // }

        // public async Task<List<ProductVM>> GetProductRange(int instan, int key,int wireID, int sort,int pageNumber)
        // {
        //     if (_pageCount < 0)
        //         return null;
        //     if (pageNumber < 0 || pageNumber > _pageCount)
        //         return null;
        //     return await GetProductsBy(instan, key, wireID, sort, _itemPage, pageNumber);
        // }



    }
}
