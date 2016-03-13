using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using Autofac.Core;

namespace GraphAssesment.DataLoader
{
    public static class IoC
    {
        private static IContainer _container;

        public static T Resolve<T>()
        {

            AssertContainerIsNotNull();
            return _container.Resolve<T>();
        }

        public static object Resolve(Type t)
        {
            return _container.Resolve(t);
        }



        public static object Init(IModule[] modules)
        {
            var builder = new ContainerBuilder();

            foreach (var module in modules)
            {
                builder.RegisterModule(module);
            }

            _container = builder.Build();

            return _container;
        }

        public static void Init(IContainer container)
        {
            _container = container;
        }
        private static void AssertContainerIsNotNull()
        {
            if (_container == null)
            {
                throw new InvalidOperationException("Cannot resolve type before resolver has been initialised.");
            }
        }
    }
}
