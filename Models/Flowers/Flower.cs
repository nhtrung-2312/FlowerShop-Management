namespace FlowerShop_Management.Models.Flowers
{
    public class Flower
    {
        public Guid ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public string Image_url { get; set; }
        public string Status { get; set; }
    }
}
