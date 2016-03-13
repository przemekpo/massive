using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GraphAssesment.Domain;

namespace GraphAssesment.Application.WebService
{
    public class VmFactory : IVmFactory
    {
        public GraphVm Create(Graph graph)
        {


            return new GraphVm()
            {
                Id = graph.Id,
                Vertexes = graph.Vertexes.Select(Create).ToList()
            };
        }

        public GraphVertexVm Create(GraphVertex vertex)
        {
            return new GraphVertexVm()
            {
                Id = vertex.Id,
                Label = vertex.Label,
                AdjacentIds = vertex.AdjacentIds
            };
        }
    }
}
