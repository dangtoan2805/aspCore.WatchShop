
using System.ComponentModel.DataAnnotations;

namespace aspCore.WatchShop.Entities
{
    public class Customer
    {
        public int ID {get;set;}
        [MaxLength(50)]
        public string Name { get; set; }
        [MaxLength(150)]
        public string Address { get; set; }
        public int Phone { get; set; }
        
    }
}