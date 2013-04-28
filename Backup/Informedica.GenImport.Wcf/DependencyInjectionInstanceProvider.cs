using System;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.ServiceModel.Dispatcher;
using StructureMap;

namespace Informedica.GenImport.Wcf
{
    // Source: http://orand.blogspot.nl/2006/10/wcf-service-dependency-injection.html
    public class DependencyInjectionInstanceProvider : IInstanceProvider
    {
        private readonly Type _serviceType;

        public DependencyInjectionInstanceProvider(Type serviceType)
        {
            _serviceType = serviceType;
        }

        #region Implementation of IInstanceProvider

        public object GetInstance(InstanceContext instanceContext)
        {
            return GetInstance(instanceContext, null);
        }

        public object GetInstance(InstanceContext instanceContext, Message message)
        {
            var service = ObjectFactory.GetInstance(_serviceType);
            if (service == null)
            {
                throw new InvalidOperationException("Requested service not found in the StructureMap configuration.");
            }
            return service;
        }

        public void ReleaseInstance(InstanceContext instanceContext, object instance)
        {
        }

        #endregion
    }
}
