using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GraphAssesment.Domain;
using GraphAssesment.Infrastructure.File;

namespace GraphAssesment.Application.DataLoader
{
    public class DataLoader
    {
        private readonly IFileDataService _fileDataService;
        private readonly IGraphFactory _factory;
        private readonly IGraphSyncService _graphSyncService;

        public DataLoader(IFileDataService fileDataService, IGraphFactory factory, IGraphSyncService graphSyncService)
        {
            _fileDataService = fileDataService;
            _factory = factory;
            _graphSyncService = graphSyncService;
        }


        public void Load()
        {
            //not using wcf because of lack of time
            //gets verexes from file
            var fileGraphVertices = _fileDataService.GetGraphVertexes();

            SyncGraph(fileGraphVertices);

        }
        //method to sync  data from files to mongodb
        public void SyncGraph(IList<FileGraphVertex> graphsToSync)
        {
            var vertexes = new List<GraphVertex>();

            foreach (var fileGraph in graphsToSync)
            {
                //using factory to create vertexes
                vertexes.Add(_factory.Create(fileGraph));
            }

            var graph = Graph.Create(vertexes);

            _graphSyncService.SyncGraph(graph);
        }
    }
}
