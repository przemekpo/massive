using GraphAssesment.Domain;

namespace GraphAssesment.Application.WebService
{
    public interface IVmFactory
    {
        GraphVm Create(Graph graph);
        GraphVertexVm Create(GraphVertex graphVertex);
    }
}