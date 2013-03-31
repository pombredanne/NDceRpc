﻿using System;
using System.Linq;
using System.ServiceModel;

namespace NDceRpc.ServiceModel
{
    public sealed class ServiceHost :ServiceHostBase
    {

        private bool _expectDuplexInitialization;
        private ServiceBehaviorAttribute _behaviour= new ServiceBehaviorAttribute();
   

        public ServiceHost(Type service, Uri baseAddress)
            : this(Activator.CreateInstance(service), baseAddress.ToString())
        {
            //TODO: make it not singleton
        }

        public ServiceHost(object service, Uri baseAddress)
            : this(service, baseAddress.ToString())
        {
        }

        public ServiceHost(object service, string baseAddress)
        {
            _baseAddress = new Uri(baseAddress,UriKind.Absolute);
            var serviceBehaviour = service.GetType().GetCustomAttributes(typeof(ServiceBehaviorAttribute), false).SingleOrDefault() as ServiceBehaviorAttribute;
            if (serviceBehaviour != null) _behaviour = serviceBehaviour;
            if (service == null) throw new ArgumentNullException("service");
            _service = service;
            _concurrency = _behaviour.ConcurrencyMode;
        }
   
        public ServiceEndpoint AddServiceEndpoint(Type contractType, Binding binding, string address)
        {
            var uri = new Uri(address, UriKind.RelativeOrAbsolute);
            if (!uri.IsAbsoluteUri)
            {
                address = _baseAddress + address;
            }
            var uuid = EndpointMapper.CreateUuid(address, contractType);
            var service = contractType.GetCustomAttributes(typeof(ServiceContractAttribute), false).SingleOrDefault() as ServiceContractAttribute;
            if (service.CallbackContract != null)
            {
                _expectDuplexInitialization = true;
            }
            _serverStub = new RpcServerStub(_service,EndpointMapper.WcfToRpc(address), binding, _expectDuplexInitialization);
            return AddEndpoint(contractType, binding, address, uuid);
        }
    }
}