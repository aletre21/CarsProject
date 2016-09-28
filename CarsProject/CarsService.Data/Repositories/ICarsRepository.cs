using CarsService.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsService.Data.Repositories
{
    public interface ICarsRepository
    {
        IEnumerable<Car> GetAllCars();

        IEnumerable<Owner> GetAllOwners();

        bool AddNewCarToOwner(Car car, int ownerId);

        bool AddNewOwner(Owner owner);

        bool DeleTheCar(int carId);

        bool DeleTheOwner(int ownerId);

        bool EditTheCar(int carId, Car car, int ownerId);

        bool EditTheOwner(int ownerId, Owner owner);
    }
}
