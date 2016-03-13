using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Autofac;

namespace GraphAssesment.WebService.Di
{
    public class ServiceBootstrapper : IDisposable
    {
        readonly IContainer _container;

        public ServiceBootstrapper()
        {
            var builder = new ContainerBuilder();

            var assemblies = AppDomain.CurrentDomain.GetAssemblies();

            builder.RegisterAssemblyModules(assemblies);

           // builder.RegisterAssemblyTypes(assemblies)
           //.Where(type => type.IsAssignableTo<IServiceHostInitializer>())
           //.As<IServiceHostInitializer>()
           //.SingleInstance();

            _container = builder.Build();
        }

        public void Start()
        {
            //foreach (var serviceHostInitializer in _container.Resolve<IEnumerable<IServiceHostInitializer>>())
            //    serviceHostInitializer.Initialize();
        }

        public void Dispose()
        {
            if (_container != null)
                _container.Dispose();
        }
    }
}