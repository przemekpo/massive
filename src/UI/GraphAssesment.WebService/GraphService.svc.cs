using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using GraphAssesment.Application.WebService;

namespace GraphAssesment.WebService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "GraphService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select GraphService.svc or GraphApplicationService.svc.cs at the Solution Explorer and start debugging.
    public class GraphService : IGraphService
    {
        private readonly IGraphApplicationService _graphApplicationService;

        public GraphService(IGraphApplicationService graphApplicationService)
        {
            _graphApplicationService = graphApplicationService;
        }

        public GraphVm GetGraph()
        {
            var graphVm = _graphApplicationService.GetGraph();

            return graphVm;
            
        }

        public GraphVertexVm GetGraphVertex(string id)
        {
            var graphVertexVm = _graphApplicationService.GetVertex(id);

            return graphVertexVm;
        }

        public List<string> GetGraphShoretsRout(string startVertexId, string endVertexId)
        {
            var rout = _graphApplicationService.GetShorestPath(startVertexId, endVertexId);

            return rout;
        }
    }
}
