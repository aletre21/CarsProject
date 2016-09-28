using System;
using System.Collections.Generic;
using CarsService.Data.Repositories;
using CarsService.Interfaces;
using CarsService.Contracts;
using AutoMapper;
using CarsService.Data.Entities;

namespace CarsService.Services
{
    public class CarsAndOwnersService : ICarsandOwnersService
    {
        ICarsRepository repository;
        IMapper mapper;

        public CarsAndOwnersService(ICarsRepository repo, IMapper mapper)
        {
            this.repository = repo;
            this.mapper = mapper;
        }

        public bool AddCarToOwner(CarDTO car,int ownerId)
        {
            try
            {
                var cr = mapper.Map<Car>(car);
                repository.AddNewCarToOwner(cr, ownerId);
                return true;
            }
            catch(Exception ex)
            {
                // log errors.
                throw;
            }
        }

        public IEnumerable<CarDTO> GetAllCars()
        {
            try
            {
                var data = repository.GetAllCars();
                var result = mapper.Map<IEnumerable<CarDTO>>(data);
                return result;
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public IEnumerable<OwnerDTO> GetAllOwners()
        {
            try
            {
                var data = repository.GetAllOwners();
                var result = mapper.Map<IEnumerable<OwnerDTO>>(data);
                return result;
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public bool AddNewOwner(OwnerDTO owner)
        {
            try
            {
                var ow = mapper.Map<Owner>(owner);
                repository.AddNewOwner(ow);
                return true;
            }
            catch (Exception ex)
            {
                // log errors.
                throw;
            }
        }

        public bool DeleteTheCar(int carId)
        {
            try
            {
                repository.DeleTheCar(carId);
                return true;
            }
            catch (Exception ex)
            {
                // log errors.
                throw;
            }
        }

        public bool DeleteTheOwner(int ownerId)
        {
            try
            {
                repository.DeleTheOwner(ownerId);
                return true;
            }
            catch (Exception ex)
            {
                // log errors.
                throw;
            }
        }

        public bool EditTheCar(int carId, CarDTO car,int ownerId)
        {
            try
            {
                var c = mapper.Map<Car>(car);
                repository.EditTheCar(carId,c,ownerId);
                return true;
            }
            catch (Exception ex)
            {
                // log errors.
                throw;
            }
        }

        public bool EditTheOwner(int ownerId, OwnerDTO owner)
        {
            try
            {
                var p = mapper.Map<Owner>(owner);
                repository.EditTheOwner(ownerId,p);
                return true;
            }
            catch (Exception ex)
            {
                // log errors.
                throw;
            }
        }
    }
}
