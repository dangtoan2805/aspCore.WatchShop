using System.Net.Mime;
using System;
using System.Collections.Generic;
using aspCore.WatchShop.EF;
using aspCore.WatchShop.Entities;
using aspCore.WatchShop.Models;
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
            // Get List Order Include Customer
            List<Order> data = _db.Orders
                .Include(o => o.Customer)
                .ToList();
            return data;
        }

        public List<OrderDetail> GetOrderDetails(int orderID)
        {
            // Get OrderDetail
            return null;
        }

        public List<OrderDetail> GetOrderDetailsWithProduct(int orderID)
        {
            // Get OrderDetail Inluce ID,Name, Img of Product
            return null;
        }


        public void UpdateOrderStatus(int orderID, int index)
        {
            // Update order satatus in DB
        }


        public Order GetOrderByID(int id)
        {

            return null;
        }

        public List<Order> FindOrders(string key)
        {
            // Find List orders with key (ID, Name Customer)
            return null;
        }
    }
}