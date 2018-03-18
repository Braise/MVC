using SportStoreDomain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportStoreDomain.Concrete
{
    // Associate the model with the database
    public class EFDbContext : DbContext
    {
        // Define a property for each table in the database that we want to work with
        // The name of the property specify the name name of the table
        public DbSet<Product> Products { get; set; }
    }
}
