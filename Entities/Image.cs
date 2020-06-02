using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace aspCore.WatchShop.Entities
{
    public class Image
    {
        public int ID { get; set; }
        [MaxLength(30)]
        public string Src { get; set; }
        public int ProductID { get; set; }
        //Nav property
        public Product Product { get; set; }
    }
}
