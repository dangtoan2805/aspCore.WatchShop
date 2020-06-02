using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace aspCore.WatchShop.Entities
{
    public class Product
    {
        [Key]
        public int ID { get; set; }
        [MaxLength(50)]
        public string Name { get; set; }
        public bool? isShow { get; set; }
        public bool? isDel { get; set; }
        public int Price { get; set; }
        public int SaleCount { get; set; }
        public int CategoryID { get; set; }
        public int TypeWireID { get; set; }
        public int ProductDetailID { get; set; }
        //Nav property
        public Category Category { get; set; }
        public TypeWire TypeWire { get; set; }
        public PromotionDetail PromotionDetail { get; set; }
        public ProductDetail ProductDetail { get; set; }
        public List<Image> Images { get; set; }
        public OrderDetail OrderDetail { get; set; }

    }
}
