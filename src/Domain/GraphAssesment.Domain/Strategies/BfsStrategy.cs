using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphAssesment.Domain.Strategies
{
    public class BfsStrategy : FindStrategy
    {
        public override List<string> FindShortestPath(List<GraphVertex> vertexes, string idEnd, string s)
        {
            return new List<string>() {"1","2"};
        }
    }
}
