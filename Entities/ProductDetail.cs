﻿using System.ComponentModel.DataAnnotations;

namespace aspCore.WatchShop.Entities
{
    public class ProductDetail
    {
        public int ID { get; set; }
        [MaxLength(30)]
        public string TypeGlass { get; set; }
        [MaxLength(30)]
        public string TypeBorder { get; set; }
        [MaxLength(30)]
        public string TypeMachine { get; set; }
        [MaxLength(30)]
        public string Parameter { get; set; }
        [MaxLength(30)]
        public string ResistWater { get; set; }
        [MaxLength(30)]
        public string Warranty { get; set; }
        [MaxLength(30)]
        public string Brand { get; set; }
        [MaxLength(30)]
        public string Origin { get; set; }
        [MaxLength(30)]
        public string Color { get; set; }
        [MaxLength(30)]
        public string Func { get; set; }
        [MaxLength(1500)]
        public string Description { get; set; }
        //Nav property
        public Product Product { get; set; }
    }
}