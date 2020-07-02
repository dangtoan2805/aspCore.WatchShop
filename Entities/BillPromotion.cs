using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace aspCore.WatchShop.Entities
{
    public class BillPromotion
    {
        [Key]
        [ForeignKey("Promotion")]
        public int PromotionID { get; set; }
        public int? MinTotal { get; set; }
        public int? NumberProduct { get; set; }
        // Nav
        public Promotion Promotion { get; set; }

    }
}