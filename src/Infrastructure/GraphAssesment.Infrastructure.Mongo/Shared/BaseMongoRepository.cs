using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GraphAssesment.Domain;
using MongoDB.Driver;

namespace GraphAssesment.Infrastructure.Mongo.Shared
{
    public class BaseMongoRepository<T> where T : GraphVertex//this should be done by aggregate interface
    {
       
        private readonly IKeyGenerator _keyGenerator;
        private readonly IMongoDatabase _database;
        private readonly string _documentType;

        protected IMongoCollection<T> Collection
        {
            get { return _database.GetCollection<T>(_documentType); }
        }


        public BaseMongoRepository(IMongoDatabase database, IKeyGenerator keyGenerator, string documentType)
        {
            _documentType = documentType;
            _database = database;
            _keyGenerator = keyGenerator;
        }

      

    }
}
