using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsService.Data.Entities
{
    public class Owner : BaseEntity
    {
        public Owner()
        {
            this.Cars = new List<Car>();
        }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }

        public virtual ICollection<Car> Cars { get; set; }
    }


    internal class OwnerEntityConfiguration : EntityTypeConfiguration<Owner>
    {
        internal OwnerEntityConfiguration()
        {
            this.HasKey(z => z.Id);
            this.HasMany(z => z.Cars).WithRequired(z => z.Owner).HasForeignKey(z => z.OwnerId);
        }
    }
}
