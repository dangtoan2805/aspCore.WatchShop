﻿using Microsoft.EntityFrameworkCore;
using aspCore.WatchShop.Entities;
using aspCore.WatchShop.Enums;

namespace aspCore.WatchShop.EF
{
    public class watchContext :DbContext
    {
        public watchContext(DbContextOptions<watchContext> options): base(options) {}
        //DbSets    
        public DbSet<Category> Categories { get; set; }
        public DbSet<Config> Configs { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Customer> Customers {get;set;}
        public DbSet<Fee> Fees { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Policy> Policies { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductDetail> ProductDetails { get; set; }
        public DbSet<Promotion> Promotions { get; set; }
        public DbSet<PromotionDetail> PromotionDetails {get;set;}
        public DbSet<TypeWire> TypeWires { get; set; }
        public DbSet<User> Users { get; set; }

        //Configure Property
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Config OrderDetail
            modelBuilder.Entity<OrderDetail>().HasKey(od => new { od.OrderID, od.ProductID });
            //Config User
            modelBuilder.Entity<User>().Property(u => u.Username).HasColumnType("nchar(25)");
            //Config Order
            modelBuilder.Entity<Order>().Property(o => o.BillPromotion).HasColumnType("decimal(2,2)");
            modelBuilder.Entity<Order>().Property(o => o.Tax).HasColumnType("decimal(2,2)");
            modelBuilder.Entity<Order>().Property(o => o.Status).HasDefaultValue(OrderStatus.NotConfirm);
            //Config Promotion
            modelBuilder.Entity<Promotion>().Property(p => p.Discount).HasColumnType("decimal(2,2)");
            modelBuilder.Entity<Promotion>().Property(p => p.isAlways).HasDefaultValue(false);
            modelBuilder.Entity<Promotion>().Property(p => p.Status).HasDefaultValue(true);
            //Config Promotion Detail
            modelBuilder.Entity<PromotionDetail>().HasKey(pd=> new {pd.ProductID,pd.PromotionID});
            //Config Fee
            modelBuilder.Entity<Fee>().Property(f => f.Tax).HasColumnType("decimal(2,2)");
            //Config Product
            modelBuilder.Entity<Product>().Property(p => p.isShow).HasDefaultValue(true);
            modelBuilder.Entity<Product>().Property(p=>p.isDel).HasDefaultValue(false);
            modelBuilder.Entity<Product>().Property(p => p.SaleCount).HasDefaultValue(0);

        }

    }
}