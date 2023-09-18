using System.ComponentModel.DataAnnotations;

namespace MojahCo.Models
{
    public class Shop
    {
        public int ShopId { get; set; }

        [Required]
        [StringLength(100)]
        public string ShopName { get; set; }
        public  string? ShopCode{ get; set; }

        //relation with Shop Images
        public List<ShopImage> ShopImages { get; set; }

    }
}
