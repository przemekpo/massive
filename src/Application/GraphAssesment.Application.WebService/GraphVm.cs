using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphAssesment.Application.WebService
{
    public class GraphVm
    {
        public string Id { get; set; }
        public List<GraphVertexVm> Vertexes { get; set; }
    }
}
