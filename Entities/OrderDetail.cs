namespace aspCore.WatchShop.Entities
{
    public class OrderDetail
    {
        public int OrderID { get; set; }
        public int ProductID { get; set; }
        public byte Quantity { get; set; }
        public int Price { get; set; }
        public int PricePromotion { get; set; }
        //Nav property
        public Order Order { get; set; }
        public Product Product { get; set; }
    }
}
