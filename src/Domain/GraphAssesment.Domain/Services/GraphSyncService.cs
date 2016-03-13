using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphAssesment.Domain
{
    public class GraphSyncService : IGraphSyncService
    {
        private readonly IGraphRepository _graphRepository;
        public GraphSyncService(IGraphRepository graphRepository)
        {
            _graphRepository = graphRepository;
        }


        public void SyncGraph(Graph graph)
        {
            if (!ValidateGraphForSync(graph))
                throw new Exception("Cannot sync graph");
            //for app purposes we are storing only one graph
            var existingGraph = _graphRepository.Get();

            if (existingGraph == null)
            {
                _graphRepository.Add(graph);
            }
            else
            {

                existingGraph.UpdateFromExternal(graph.Vertexes);
                _graphRepository.Update(existingGraph);
            }

        }

        public bool ValidateGraphForSync(Graph graphVertex)
        {
            return true;
        }
    }
}
