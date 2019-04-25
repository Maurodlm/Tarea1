using System.ComponentModel.DataAnnotations;

namespace APITAREA1.Models
{
    public class Sale
    {
        [Key]
        public int SaleId { get; set; }
        public int ProductId { get; set; }
        public int ClientId { get; set; }
        public int Date { get; set; }
    }
}