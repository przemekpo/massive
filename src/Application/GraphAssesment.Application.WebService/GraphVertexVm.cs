using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphAssesment.Application.WebService
{
    public class GraphVertexVm
    {
        public string Id { get; set; }
        public string Label { get; set; }
        public List<string> AdjacentIds { get; set; }

    }
}
