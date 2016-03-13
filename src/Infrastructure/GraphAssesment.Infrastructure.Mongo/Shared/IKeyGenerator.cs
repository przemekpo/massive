using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphAssesment.Infrastructure.Mongo.Shared
{
    public interface IKeyGenerator
    {
        string GenerateKey<T>();
    }
}
