using CarsService.Contracts;
using CarsService.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsService.Profiles
{
    public class MainProfile : AutoMapper.Profile
    {
        public MainProfile()
        {
            CreateMap<Car, CarDTO>().ConvertUsing<CarToDtoConverter>();
            CreateMap<OwnerDTO, Owner>();
            CreateMap<Owner, OwnerDTO>();
            CreateMap<CarDTO, Car>()
                .ForMember(z => z.Owner, opt => opt.Ignore())
                .ForMember(z => z.OwnerId, opt => opt.Ignore());
  

        }
    }
    }

