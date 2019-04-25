using System.ComponentModel.DataAnnotations;

namespace APITAREA1.Models
{
    public class Product
    {

        [Key]
        public int ProductId { get; set; }
        public decimal Price { get; set; }
        public string Name { get; set; }
    }
}