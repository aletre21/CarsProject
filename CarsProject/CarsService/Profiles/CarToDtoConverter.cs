using AutoMapper;
using CarsService.Contracts;
using CarsService.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsService.Profiles
{
    public class CarToDtoConverter : ITypeConverter<Car, CarDTO>
    {
        public CarDTO Convert(Car source, CarDTO destination, ResolutionContext context)
        {
            var dest = new CarDTO();
            dest.Brand = source.Brand;
            dest.Model = source.Model;
            dest.Id = source.Id;
            dest.KM = source.KM;
            dest.Owner = new OwnerDTO()
            {
                Age = source.Owner.Age,
                LastName = source.Owner.LastName,
                FirstName = source.Owner.FirstName,
                Id = source.OwnerId
            };

            return dest;
        }
    }
}
