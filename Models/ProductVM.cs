using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using aspCore.WatchShop.Entities;

namespace aspCore.WatchShop.Models
{

    public class ProductVM
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public int CategoryID { get; set; }
        public int TypeWireID { get; set; }
        public List<string> Images { get; set; }
        public string ImageDefault { get; set; }
        public bool isShow { get; set; }
        public string DescriptionProduct { get; set; }
        public int SaleCount { get; set; }
        //        
        public string TypeGlass { get; set; }
        public string TypeBorder { get; set; }
        public string TypeMachine { get; set; }
        public string Parameter { get; set; }
        public string ResistWater { get; set; }
        public string Warranty { get; set; }
        public string Brand { get; set; }
        public string Origin { get; set; }
        public string Color { get; set; }
        public string Func { get; set; }

        public ProductVM(Product product)
        {
            this.ID = product.ID;
            this.Name = product.Name;
            this.isShow = (bool)product.isShow;
            this.Price = product.Price;
            this.SaleCount = product.SaleCount;
            this.CategoryID = product.CategoryID;
            this.TypeWireID = product.TypeWireID;
            this.Images = product.Images.Split(',').ToList();
            this.Images = new List<string>();
            Images.Add("img_watch_1.jpg");
            Images.Add("img_watch_2.jpg");
            Images.Add("img_watch_3.jpg");
            Images.Add("img_watch_4.jpg");
            this.ImageDefault = Images[product.ImageDefault];
        }

        public void SetDetail(ProductDetail detail)
        {
            this.TypeGlass = detail.TypeGlass;
            this.TypeBorder = detail.TypeBorder;
            this.TypeMachine = detail.TypeMachine;
            this.Parameter = detail.Parameter;
            this.ResistWater = detail.ResistWater;
            this.Warranty = detail.Warranty;
            this.Brand = detail.Brand;
            this.Origin = detail.Origin;
            this.Color = detail.Color;
            this.Func = detail.Func;
            this.DescriptionProduct = detail.DescriptionProduct;
        }

        public ProductVM()
        {
            this.Name = "P093";
            this.isShow = true;
            this.Price = 1999;
            this.SaleCount = 0;
            this.CategoryID = 1;
            this.TypeWireID = 1;
            this.TypeGlass = "Demo data 01";
            this.TypeBorder = "Demo data 01";
            this.TypeMachine = "Demo data 01";
            this.Parameter = "Demo data 01";
            this.ResistWater = "Demo data 01";
            this.Warranty = "Demo data 01";
            this.Brand = "Demo data 01";
            this.Origin = "Demo data 01";
            this.Color = "Demo data 01";
            this.Func = "Demo data 01";
            this.DescriptionProduct = "Demo data 01";
            this.Images = new List<string>();
            Images.Add("img_watch_1.jpg");
            Images.Add("img_watch_2.jpg");
            Images.Add("img_watch_3.jpg");
            Images.Add("img_watch_4.jpg");
            this.ImageDefault = Images[0];
        }

        public List<string> GetImages() { return this.Images; }

        public void AddImage(string imgName) { Images.Add(imgName); }
    }
    // public class ProductVM
    // {
    //     public int ID { get; set; }   
    //     public string Name { get; set; }
    //     public string Price { get; set; }
    //     public string PricePromotion { get; set; }
    //     public int CategoryID { get; set; }
    //     public int PromotionID { get; set; }
    //     public int ProductDetailID { get; set; }
    //     public int TypeWireID { get; set; }
    //     public List<string> Images { get; set; }
    //     public string showSale { get; set; }

    //     public string ImageDefault { get; set; }
    //     public ProductVM(Product p)
    //     {
    //         // ID = p.ID;
    //         // Name = ConvertName(p.ProductDetail.Brand, p.Name, p.Category.Name)+ ID;
    //         // Price = ConvertMoney(p.Price);
    //         // PricePromotion = ConvertMoney(p.PricePromotion);
    //         // CategoryID = p.CategoryID;
    //         // ProductDetailID = p.ProductDetailID;
    //         // PromotionID = p.PromotionID;
    //         // TypeWireID = p.TypeWireID;
    //         //Map imgs
    //         Images = new List<string>(); 
    //         if (p.Images.Count == 0) Images.Add("img_null.jpg");
    //         else
    //             foreach (Image i in p.Images) Images.Add(i.Src);
    //         ImageDefault = Images[0];
    //         //Map promotion
    //         if (PromotionID == 1)
    //             showSale = "vt-hidden";
    //         else
    //             showSale = "";
    //     }


    //     public string ConvertName (string Brand, string ProductName, string CateName)
    //     {
    //         string result = "";
    //         string[] cateName = CateName.Split(" ");
    //         if (cateName.Length > 2)
    //             result = Brand + " " + ProductName + " - " + cateName[2];
    //         else
    //             result = Brand + " " + ProductName;
    //         return result;
    //     }

    //     public string ConvertMoney(int money)
    //     {
    //         return String.Format("{0:0,0}", money) + " đ";
    //     }

    //     public string getImg()
    //     {
    //         return Images[0];
    //     }
    // }
}
