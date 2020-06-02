using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace aspCore.WatchShop.Entities
{
    public class User
    {
        [Key]
        public int ID { get; set; }
        [MaxLength(25)]
        public string Username { get; set; }
        [MaxLength(25)]
        public string Password { get; set; }
        [MaxLength(100)]
        public string Email { get; set; }
        // Nav property
        public List<Order> Orders{get;set;}
    }
}
