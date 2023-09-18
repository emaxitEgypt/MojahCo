using System.ComponentModel.DataAnnotations;

namespace MojahCo.Models
{
    public class Service
    {
        public int ServiceId { get; set; }

        [Required]
        [StringLength(50)]
        public string ServiceName { get; set; }
        public string? ShortDescription { get; set; }
        public string? LongDescription { get; set; }
        public bool? HasPdf { get; set; }
        public string? PdfPath { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }

        //relation with images
        public List<ServiceImage> Images { get; set; }
    }
}
