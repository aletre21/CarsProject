using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsService.Data.Entities
{
    public class Car : BaseEntity
    {
        public string Brand { get; set; }

        public string Model { get; set; }

        public int KM { get; set; }

        public int OwnerId { get; set; }

        public virtual Owner Owner { get; set; }
    }

    internal class CarConfiguration : EntityTypeConfiguration<Car>
    {
        internal CarConfiguration()
        {
            this.HasKey(z => z.Id);
        }
    }
}
