using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GraphAssesment.Domain;

namespace GraphAssesment.Application.WebService
{
    public class GraphApplicationService : IGraphApplicationService
    {
        private readonly IGraphRepository _graphRepository;
        private readonly IVmFactory _vmFactory;
        private readonly IGraphDomainService _graphDomainService;


        public GraphApplicationService(IGraphRepository graphRepository, IVmFactory vmFactory, IGraphDomainService graphDomainService)
        {
            _graphRepository = graphRepository;
            _vmFactory = vmFactory;
            _graphDomainService = graphDomainService;
        }

        public GraphVertexVm GetVertex (string vertexId)
        {
            var graph = _graphRepository.Get();

            if(graph == null)
                throw new Exception("Not found");
            var vertex = graph.GetVertex(vertexId);

            return _vmFactory.Create(vertex);

        }

        public GraphVm GetGraph()
        {
            var graph = _graphRepository.Get();

            if (graph == null)
                throw new Exception("Not found");

            return _vmFactory.Create(graph);
        }

        public List<string> GetShorestPath(string startVertexId, string endVertextId)
        {
            var graph = _graphRepository.Get();

            if (graph == null)
                throw new Exception("Not found");

            return _graphDomainService.GetShortestPath(startVertexId, endVertextId);
        }

    }
}
