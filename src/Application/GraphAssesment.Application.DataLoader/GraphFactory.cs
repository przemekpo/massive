using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GraphAssesment.Domain;
using GraphAssesment.Infrastructure.File;

namespace GraphAssesment.Application.DataLoader
{
    public class GraphFactory : IGraphFactory
    {
        public GraphVertex Create(FileGraphVertex fileGraphVertex)
        {
            return new GraphVertex()
            {
                Id = fileGraphVertex.Id,
                Label = fileGraphVertex.Label,
                AdjacentIds = fileGraphVertex.AdjacentVertexesIds.ToList(),
            };
        }
        
    }
}
