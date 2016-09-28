using Autofac;
using Autofac.Integration.Wcf;
using AutoMapper;
using CarsService.Data.Repositories;
using CarsService.Interfaces;
using CarsService.Profiles;
using CarsService.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Text;
using System.Threading.Tasks;

namespace CarsService.Host
{
    class Program
    {

        static void Main(string[] args)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<MainProfile>();
            });

            IMapper mapper = config.CreateMapper();

            ContainerBuilder builder = new ContainerBuilder();
            builder.RegisterType<CarsAndOwnersService>().As<ICarsandOwnersService>();
            builder.RegisterInstance<IMapper>(mapper);
            builder.RegisterType<CarsRepository>().As<ICarsRepository>();

            using (var container = builder.Build())
            {
                Uri address = new Uri("http://localhost:8080/CarsAndOwnersService");
                ServiceHost host = new ServiceHost(typeof(CarsAndOwnersService), address);
                host.AddServiceEndpoint(typeof(ICarsandOwnersService), new BasicHttpBinding(), string.Empty);


                ServiceMetadataBehavior serviceBehavior = new ServiceMetadataBehavior();
                serviceBehavior.HttpGetEnabled = true;
                host.Description.Behaviors.Add(serviceBehavior);

                host.Description.Behaviors.Remove(typeof(ServiceDebugBehavior));
                ServiceDebugBehavior debugBehaviou = new ServiceDebugBehavior();
                debugBehaviou.IncludeExceptionDetailInFaults = true;
                host.Description.Behaviors.Add(debugBehaviou);

                host.AddDependencyInjectionBehavior<ICarsandOwnersService>(container);


                host.Open();

                Console.WriteLine("The host has been opened.");
                Console.ReadLine();

                host.Close();
                Environment.Exit(0);
            }

        }
    }
}
