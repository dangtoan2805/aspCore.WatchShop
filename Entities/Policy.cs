using System.ComponentModel.DataAnnotations;

namespace aspCore.WatchShop.Entities
{
    public class Policy
    {
        [Key]
        public int ID { get; set; }
        [MaxLength(50)]
        public string Name { get; set; }
        [MaxLength(30)]
        public string Icon { get; set; }
    }
}
