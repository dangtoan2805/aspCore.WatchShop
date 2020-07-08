using System;
using System.Collections.Generic;
using aspCore.WatchShop.EF;
using aspCore.WatchShop.Entities;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace aspCore.WatchShop.DAOs
{
    public class OrderDao
    {
        private watchContext _db = null;

        public OrderDao(watchContext context)
        {
            _db = context;
        }

        public List<Order> GetOrders(DateTime start, DateTime end)
        {
            var data = _db.Orders
                .Where(o => o.DateCreated >= start && o.DateCreated <= end)
                .Include(o => o.Customer)
                .Include(o => o.OrderDetails)
                .ToList();
            return data.Count <= 0 ? null : data;
        }

        public List<Order> GetAllOrders()
        {
            return _db.Orders
                .Include(p => p.OrderDetails)
                .ToList();
        }


        public List<OrderDetail> GetOrderDetailsWithProduct(int orderID)
        {
            // Get OrderDetail Inluce ID,Name, Img of Product
            return (List<OrderDetail>)_db.OrderDetails
                .Where(od => od.OrderID == orderID)
                .Include(od => od.Product)
                .ToList();
        }

        public void UpdateOrderStatus(int orderID, int index)
        {
            Order order = _db.Orders.Where(o => o.ID == orderID).FirstOrDefault();
            if (order == null) return;
            order.Status = index;
            _db.SaveChanges();
        }

        public Order GetOrderByID(int id)
        {
            // Get List Order Include Customer, OD
            return _db.Orders
                .Where(o => o.ID == id)
                .Include(o => o.Customer)
                .Include(o => o.OrderDetails)
                .FirstOrDefault();
        }

        public List<Order> FindByCustomer(string name)
        {
            return _db.Orders
                .Where(o => o.Customer.Name.Contains(name))
                .Include(o => o.Customer)
                .Include(o => o.OrderDetails)
                .ToList();
        }
    }
}