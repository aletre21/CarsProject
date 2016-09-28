using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace CarsService.Services
{
    public class ServiceWrapper<TService,TContract> : ServiceBase where TService : TContract
    {
        string serviceAddress;
        ServiceHost host;
        
        public ServiceWrapper(string serviceName,string serviceAddress)
        {
            ServiceName = serviceName;
            this.serviceAddress = serviceAddress;
        }

        protected override void OnStart(string[] args)
        {
            Start();
        }

        protected override void OnStop()
        {
            Stop();
        }

        public void Start()
        {
            host = new ServiceHost(typeof(TService));
            //var binding = new BasicHttpBinding()
        }

        public void Stop()
        {

        }


    }
}
