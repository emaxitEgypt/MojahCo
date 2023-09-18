namespace MojahCo.Models
{
    public class Menu
    {
        public int MenuId { get; set; }
        public string MenuName { get; set; }
        public int ParentId { get; set; }
        public bool? HasSub { get; set; }
        public string? ServiceLink { get; set; }

    }
}
