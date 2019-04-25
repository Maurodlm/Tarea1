using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCTAREA1.Models
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