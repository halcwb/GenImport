using System;
using System.ServiceModel;

namespace Informedica.GenImport.Wcf
{
    public class MyServiceHost : ServiceHost
    {
        public MyServiceHost() { }
        public MyServiceHost(Type serviceType, params Uri[] baseAddresses) : base(serviceType, baseAddresses) { }

        protected override void OnOpening()
        {
            Description.Behaviors.Add(new DependencyInjectionServiceBehavior());
            base.OnOpening();
        }
    }
}
