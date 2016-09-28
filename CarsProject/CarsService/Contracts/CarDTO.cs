using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CarsService.Contracts
{
    [DataContract]
    public class CarDTO
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string Brand { get; set; }

        [DataMember]
        public string Model { get; set; }

        [DataMember]
        public int KM { get; set; }

        [DataMember]
        public OwnerDTO Owner { get; set; }
    }
}
