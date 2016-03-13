using System.Collections.Generic;

namespace GraphAssesment.Application.WebService
{
    public interface IGraphApplicationService
    {
        GraphVertexVm GetVertex (string vertexId);
        GraphVm GetGraph();
        List<string> GetShorestPath(string startVertexId, string endVertextId);
    }
}