using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace aspCore.WatchShop.Entities
{
    public class Config
    {
        public int ID { get; set; }
        [MaxLength(30)]
        public string Logo { get; set; }
        [MaxLength(100)]
        public string TitleWeb { get; set; }
        [MaxLength(100)]
        public string NameShop { get; set; }
        [MaxLength(500)]
        public string Desription { get; set; } 
    }
}
