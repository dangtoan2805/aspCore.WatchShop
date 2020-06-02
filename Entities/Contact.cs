using System.ComponentModel.DataAnnotations;

namespace aspCore.WatchShop.Entities
{
    public class Contact
    {
        public int ID { get; set; }
        public int Phone { get; set; }
        [MaxLength(150)]
        public string Address { get; set; }
        [MaxLength(50)]
        public string Email { get; set; }
        [MaxLength(50)]
        public string LinkFB { get; set; }
    }
}
