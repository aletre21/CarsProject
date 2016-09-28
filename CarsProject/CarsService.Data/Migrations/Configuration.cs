namespace CarsService.Data.Migrations
{
    using Entities;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<CarsService.Data.ApplicationContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(CarsService.Data.ApplicationContext context)
        {
            context.Owners.AddOrUpdate(new Entities.Owner()
            {
                FirstName = "Stanis³aw",
                LastName = "Kowalski",
                Age = 45,
                Cars = new List<Car>() {
                    new Car() {Brand = "Fiat", Model = "Stilo", KM = 120 },
                    new Car() { Brand = "Suzuki", Model = "Swift", KM = 134 },
                    new Car() {Brand = "Opel", Model = "Astra", KM = 90 }},
            });

            context.Owners.AddOrUpdate(new Entities.Owner()
            {
                FirstName = "Mietek",
                LastName = "Boberek",
                Age = 45,
                Cars = new List<Car>() {
                    new Car() {Brand = "Renault", Model = "Megane", KM = 150 },
                    new Car() { Brand = "Skoda", Model = "Octavia", KM = 182 }
            }});

        }
    }
}
