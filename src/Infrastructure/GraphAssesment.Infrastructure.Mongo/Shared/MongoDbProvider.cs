using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;

namespace GraphAssesment.Infrastructure.Mongo.Shared
{
    public class MongoDbProvider
    {
        private static readonly string DatabaseName = "graph";
        private static readonly string ConnectionString = "mongodb://localhost";

        private static volatile MongoClient _mongoClient;
        private static readonly object Lock = new Object();

        public static IMongoDatabase GetDatabase()
        {
            return Client.GetDatabase(DatabaseName);
        }
        private static MongoClient Client
        {
            get
            {
                if (_mongoClient == null)
                {
                    lock (Lock)
                    {
                        if (_mongoClient == null)
                            _mongoClient = new MongoClient(ConnectionString);

                    }
                }

                return _mongoClient;
            }
        }

    }
}
