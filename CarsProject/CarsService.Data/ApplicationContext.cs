using CarsService.Data.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsService.Data
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext() : base("name = CarsContext")
        {
             
        }

        public DbSet<Owner> Owners { get; set; }

        public DbSet<Car> Cars { get; set; }
    }
}
