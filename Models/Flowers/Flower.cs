using System.ComponentModel.DataAnnotations;

namespace FlowerShop_Management.Models.Flowers
{
    public class Flower
    {
        [Key]
        public string Flower_ID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public string Image_url { get; set; }
        public string Status { get; set; }
    }
}
