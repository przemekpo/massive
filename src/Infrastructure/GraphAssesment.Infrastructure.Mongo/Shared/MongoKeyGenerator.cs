using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphAssesment.Infrastructure.Mongo.Shared
{
    public class MongoKeyGenerator : IKeyGenerator
    {
       
        public MongoKeyGenerator()
        {
           
        }

        public string GenerateKey<T>()
        {
            return Guid.NewGuid().ToString();
        }
        
    }
}
