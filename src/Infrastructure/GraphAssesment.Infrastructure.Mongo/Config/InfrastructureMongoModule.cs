using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using GraphAssesment.Domain;
using GraphAssesment.Infrastructure.Mongo.Repositories;
using GraphAssesment.Infrastructure.Mongo.Shared;
using MongoDB.Driver;

namespace GraphAssesment.Infrastructure.Mongo.Config
{
    public class InfrastructureMongoModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.Register(f => MongoDbProvider.GetDatabase()).As<IMongoDatabase>();
            builder.RegisterType<MongoKeyGenerator>().As<IKeyGenerator>();

            builder.RegisterType<GraphRepository>().As<IGraphRepository>();
        }

    }
}
