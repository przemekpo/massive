using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using GraphAssesment.Domain;
using GraphAssesment.Infrastructure.File;
using GraphAssesment.Infrastructure.Mongo.Config;

namespace GraphAssesment.Application.DataLoader
{
    public class DataLoaderModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            
            builder.RegisterModule(new InfrastructureMongoModule());
            builder.RegisterModule(new InfrastructureFileModule());
            builder.RegisterModule(new DomainModule());

            builder.RegisterType<GraphFactory>().As<IGraphFactory>();
            builder.RegisterType<DataLoader>().AsSelf();
        }
    }
}
