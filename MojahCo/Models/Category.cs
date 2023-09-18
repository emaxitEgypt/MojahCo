using System.ComponentModel.DataAnnotations;

namespace MojahCo.Models
{
    public class Category
    {
        public int CategoryId { get; set; }

        [Required]
        [StringLength(50)]
        public string CategoryName { get; set; }
        public string? Image { get; set; }

    }
}
