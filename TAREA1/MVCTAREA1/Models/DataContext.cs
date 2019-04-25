using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVCTAREA1.Models
{
    public class DataContext:DbContext
    {
        public DataContext():base("DefaultConnection")
        {

        }

        public System.Data.Entity.DbSet<MVCTAREA1.Models.Product> Products { get; set; }

        public System.Data.Entity.DbSet<MVCTAREA1.Models.Sale> Sales { get; set; }

        public System.Data.Entity.DbSet<MVCTAREA1.Models.Client> Clients { get; set; }
    }
}