using CarsService.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Web;
using CarsService.Contracts;

namespace CarsClient.WindowsService
{
    public class WCFConnector : ClientBase<ICarsandOwnersService>, ICarsandOwnersService
    {



        public bool AddCarToOwner(CarDTO car, int ownerId)
        {
            return base.Channel.AddCarToOwner(car, ownerId);
        }

        public bool AddNewOwner(OwnerDTO owner)
        {
            return base.Channel.AddNewOwner(owner);
        }

        public bool DeleteTheCar(int carId)
        {
            return base.Channel.DeleteTheCar(carId);
        }

        public bool DeleteTheOwner(int ownerId)
        {
            return base.Channel.DeleteTheOwner(ownerId);
        }

        public bool EditTheCar(int carId, CarDTO car, int ownerId)
        {
            return base.Channel.EditTheCar(carId, car, ownerId);
        }

        public bool EditTheOwner(int ownerId, OwnerDTO owner)
        {
            return base.Channel.EditTheOwner(ownerId, owner);
        }

        public IEnumerable<CarDTO> GetAllCars()
        {
            return base.Channel.GetAllCars();
        }

        public IEnumerable<OwnerDTO> GetAllOwners()
        {
            return base.Channel.GetAllOwners();
        }
    }
}