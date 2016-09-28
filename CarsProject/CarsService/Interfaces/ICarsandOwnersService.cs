using CarsService.Contracts;
using System.Collections.Generic;
using System.ServiceModel;

namespace CarsService.Interfaces
{
    [ServiceContract]
    public interface ICarsandOwnersService
    {
        [OperationContract]
        IEnumerable<OwnerDTO> GetAllOwners();

        [OperationContract]
        IEnumerable<CarDTO> GetAllCars();

        [OperationContract]
        bool AddCarToOwner(CarDTO car,int ownerId);

        [OperationContract]
        bool AddNewOwner(OwnerDTO owner);

        [OperationContract]
        bool DeleteTheCar(int carId);

        [OperationContract]
        bool DeleteTheOwner(int ownerId);

        [OperationContract]
        bool EditTheCar(int carId, CarDTO car, int ownerId);

        [OperationContract]
        bool EditTheOwner(int ownerId, OwnerDTO owner);
    }
}
