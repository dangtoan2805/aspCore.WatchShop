using System.ComponentModel.DataAnnotations;

namespace aspCore.WatchShop.Entities
{
    public class Info
    {
        [Key]
        public int ID { get; set; }
        [MaxLength(30)]
        public string Logo { get; set; }
        [MaxLength(100)]
        public string TitleWeb { get; set; }
        [MaxLength(100)]
        public string NameShop { get; set; }
        [MaxLength(500)]
        public string Desription { get; set; }
        public int Phone { get; set; }
        [MaxLength(150)]
        public string Address { get; set; }
        [MaxLength(50)]
        public string Email { get; set; }
        [MaxLength(50)]
        public string LinkFB { get; set; }
    }
}