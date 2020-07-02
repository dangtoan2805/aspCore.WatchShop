using System.Linq;
using System;
using System.Collections.Generic;
using aspCore.WatchShop.DAOs;
using aspCore.WatchShop.EF;
using aspCore.WatchShop.Entities;

namespace aspCore.WatchShop.Models
{
    public class OrderModel
    {
        private OrderDao _db = null;
        public OrderModel(watchContext context)
        {
            _db = new OrderDao(context);
        }

        private List<OrderVM> MapOrderVM(List<Order> orders)
        {
            if (orders == null) return null;
            List<OrderVM> listViewData = new List<OrderVM>();
            foreach (var item in orders)
            {
                int orderID = item.ID;
                int sum = (int)_db.GetOrderDetails(orderID).Sum(item => item.Quantity * (item.Price - item.Promotion));
                listViewData.Add(new OrderVM()
                {
                    ID = orderID,
                    DateCreated = item.DateCreated,
                    Phone = item.Customer.Phone,
                    Customer = item.Customer.Name,
                    Address = item.Customer.Address,
                    Status = item.Status,
                    Total = (int)(sum * (1 + item.Tax))
                });
            }
            return listViewData;
        }

        public List<OrderVM> FindOrder(string key)
        {
            List<Order> orders = _db.FindOrders(key);
            return MapOrderVM(orders);
        }

        public void UpdateStatus(int orderID, int index)
        {
            _db.UpdateOrderStatus(orderID, index);
        }

        public List<OrderVM> GetListViewData(string start, string end)
        {
            List<Order> orders = _db.GetOrders(DateTime.Now, DateTime.Now);
            return MapOrderVM(orders);
        }

        public OrderDetailVM GetViewDetail(int id)
        {
            Order order = _db.GetOrderByID(id);
            if (order == null) return null;
            OrderDetailVM detail = new OrderDetailVM()
            {
                ID = order.ID,
                DateCreated = order.DateCreated,
                Note = order.Note,
                BillPromotion = (decimal)order.BillPromotion,
                TransportFee = order.TransportFee,
                Tax = order.Tax,
                Phone = order.Customer.Phone,
                Customer = order.Customer.Name,
                Address = order.Customer.Address,
                Status = order.Status
            };

            List<OrderDetail> ls = _db.GetOrderDetailsWithProduct(id);
            if (ls == null) return detail;
            List<ProductOrder> products = new List<ProductOrder>();
            ls.ForEach(item => products.Add(new ProductOrder()
            {
                ProductID = item.ProductID,
                ProductName = item.Product.Name,
                Price = item.Price,
                Promotion = item.Promotion,
                Quantity = item.Quantity
            }));
            detail.AddProductOrder(products);
            return detail;
        }
    }

    public class OrderVM
    {
        public int ID { get; set; }
        public DateTime DateCreated { get; set; }
        public string Phone { get; set; }
        public string Customer { get; set; }
        public string Address { get; set; }
        public int Status { get; set; }
        public int Total { get; set; }
    }

    public class OrderDetailVM
    {
        public int ID { get; set; }
        public DateTime DateCreated { get; set; }
        public string Note { get; set; }
        public decimal BillPromotion { get; set; }
        public int TransportFee { get; set; }
        public decimal Tax { get; set; }
        public string Phone { get; set; }
        public string Customer { get; set; }
        public string Address { get; set; }
        public int Status { get; set; }
        public List<ProductOrder> Products { get; set; }
        public int Total { get; set; }

        public OrderDetailVM() { }

        public void AddProductOrder(List<ProductOrder> orders)
        {
            this.Products = orders;
            int sum = (int)orders.Sum(item => item.Quantity * (item.Price - item.Promotion));
            this.Total = (int)(sum * (1 + this.Tax));
        }
    }

    public class ProductOrder
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public int Price { get; set; }
        public decimal Promotion { get; set; }
    }
}