using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using GraphAssesment.Application.DataLoader;


namespace GraphAssesment.DataLoader
{
    public static class ContainerConfig
    {
        public static Autofac.IContainer Configure()
        {
            var builder = new ContainerBuilder();

            builder.RegisterModule(new DataLoaderModule());

            return builder.Build();
        }
    }
}
