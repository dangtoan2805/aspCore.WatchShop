﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using aspCore.WatchShop.Enums;

namespace aspCore.WatchShop.Entities
{
    public class Order
    {
        public int ID { get; set; }
        public DateTime DateCreated { get; set; }
        [MaxLength(150)]
        public string Note { get; set; }
        public decimal BillPromotion { get; set; }
        public int TransportFee { get; set; }
        public decimal Tax { get; set; }
        public int CustomerID{ get;set;}
        public OrderStatus Status { get; set; }
        //Nav property
        public Customer Customer {get;set;}
        public List<OrderDetail> OrderDetails { get; set; }
    }
}