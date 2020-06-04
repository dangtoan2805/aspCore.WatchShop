using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using aspCore.WatchShop.Entities;

namespace aspCore.WatchShop.Models
{
    public class ProductVM
    {
        public int ID { get; set; }   
        public string Name { get; set; }
        public string Price { get; set; }
        public string PricePromotion { get; set; }
        public int CategoryID { get; set; }
        public int PromotionID { get; set; }
        public int ProductDetailID { get; set; }
        public int TypeWireID { get; set; }
        public List<string> Images { get; set; }
        public string showSale { get; set; }

        public string ImageDefault { get; set; }
        public ProductVM(Product p)
        {
            // ID = p.ID;
            // Name = ConvertName(p.ProductDetail.Brand, p.Name, p.Category.Name)+ ID;
            // Price = ConvertMoney(p.Price);
            // PricePromotion = ConvertMoney(p.PricePromotion);
            // CategoryID = p.CategoryID;
            // ProductDetailID = p.ProductDetailID;
            // PromotionID = p.PromotionID;
            // TypeWireID = p.TypeWireID;
            //Map imgs
            Images = new List<string>(); 
            if (p.Images.Count == 0) Images.Add("img_null.jpg");
            else
                foreach (Image i in p.Images) Images.Add(i.Src);
            ImageDefault = Images[0];
            //Map promotion
            if (PromotionID == 1)
                showSale = "vt-hidden";
            else
                showSale = "";
        }


        public string ConvertName (string Brand, string ProductName, string CateName)
        {
            string result = "";
            string[] cateName = CateName.Split(" ");
            if (cateName.Length > 2)
                result = Brand + " " + ProductName + " - " + cateName[2];
            else
                result = Brand + " " + ProductName;
            return result;
        }

        public string ConvertMoney(int money)
        {
            return String.Format("{0:0,0}", money) + " đ";
        }

        public string getImg()
        {
            return Images[0];
        }
    }
}
