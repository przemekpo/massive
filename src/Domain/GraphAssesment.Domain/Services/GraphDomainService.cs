using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GraphAssesment.Domain.Strategies;

namespace GraphAssesment.Domain
{
    public interface IGraphDomainService
    {
        
        List<string> GetShortestPath(string idStart, string idEnd);
    }

    public class GraphDomainService : IGraphDomainService
    {
        private readonly IGraphRepository _graphRepository;

        public GraphDomainService(IGraphRepository graphRepository)
        {
            _graphRepository = graphRepository;
        }

        public List<string> GetShortestPath(string idStart, string idEnd)
        {
            var graph = _graphRepository.Get();
            var findingStrategy = GetFindingStrategy(graph.Type);
            return findingStrategy.FindShortestPath(graph.Vertexes, idStart, idEnd);
        }

        private FindStrategy GetFindingStrategy(GraphType type)
        {
            //base on type different finding algoryth should be used
            return new BfsStrategy();
        }
    }
}
