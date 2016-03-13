using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphAssesment.Domain.Strategies
{
    public abstract class FindStrategy
    {
         public abstract List<string> FindShortestPath(List<GraphVertex> vertexes, string idStart, string idEnd);
    }
}
