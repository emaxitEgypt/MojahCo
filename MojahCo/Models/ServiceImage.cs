namespace MojahCo.Models
{
    public class ServiceImage
    {
        public int ServiceImageId { get; set; }
        public string? ImagePath { get; set; }
        public bool? IsSlider { get; set; }
        public int ServiceId { get; set; }
        public Service Service { get; set; }

    }
}
