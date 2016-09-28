using CarsService.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsService.Data.Repositories
{
    public class CarsRepository : ICarsRepository
    {
        public IEnumerable<Car> GetAllCars()
        {
            using (var Context = new ApplicationContext())
            {
                var query = Context.Cars.Include("Owner");

                var cars = query.ToList();

                return cars;
            }
        }

        public IEnumerable<Owner> GetAllOwners()
        {
            using (var Context = new ApplicationContext())
            {
                var query = from owner in Context.Owners.Include("Cars")
                            select owner;

                return query.ToList();
            }
        }

        public bool AddNewCarToOwner(Car car, int ownerId)
        {
            using (var Context = new ApplicationContext())
            {
                var query = from owner in Context.Owners
                            where owner.Id == ownerId
                            select owner;

                var own = query.SingleOrDefault();
                if (own == null)
                    throw new KeyNotFoundException("Not found owner with Id:" + ownerId);

                var c = Context.Cars.Create();
                c.Brand = car.Brand;
                c.Model = car.Model;
                c.KM = car.KM;
                c.Owner = own;
                Context.Cars.Add(c);

                Context.SaveChanges();
                return true;
            }
        }

        public bool AddNewOwner(Owner owner)
        {
            using (var Context = new ApplicationContext())
            {
                var o = Context.Owners.Create();
                o.Age = owner.Age;
                o.FirstName = owner.FirstName;
                o.LastName = owner.LastName;
                Context.Owners.Add(o);
                Context.SaveChanges();
                return true;

            }
        }



        public bool DeleTheCar(int carId)
        {
            using (var Context = new ApplicationContext())
            {
                var c = from x in Context.Cars
                        where x.Id == carId
                        select x;

                var carToDelete = c.SingleOrDefault();
                Context.Cars.Remove(carToDelete);
                Context.SaveChanges();
                return true;
            }
        }

        public bool DeleTheOwner(int ownerId)
        {
            using (var Context = new ApplicationContext())
            {
                var person = from x in Context.Owners
                             where x.Id == ownerId
                             select x;

                var personToDelete = person.SingleOrDefault();
                Context.Owners.Remove(personToDelete);
                Context.SaveChanges();
                return true;
            }
        }

        public bool EditTheCar(int carId, Car car, int ownerId)
        {
            using (var Context = new ApplicationContext())
            {
                var cr = from c in Context.Cars
                         where c.Id == carId
                         select c;

                var carToEdit = cr.SingleOrDefault();
                carToEdit.Brand = car.Brand;
                carToEdit.Model = car.Model;
                carToEdit.KM = car.KM;
                carToEdit.OwnerId = ownerId;
                Context.SaveChanges();
                return true;
            }
        }

        public bool EditTheOwner(int ownerId, Owner owner)
        {
            using (var Context = new ApplicationContext())
            {
                var per = from c in Context.Owners
                         where c.Id == ownerId
                         select c;

                var ownerToEdit = per.SingleOrDefault();
                ownerToEdit.Age = owner.Age;
                ownerToEdit.FirstName = owner.FirstName;
                ownerToEdit.LastName = owner.LastName;
                Context.SaveChanges();
                return true;
            }
        }
    }
}
