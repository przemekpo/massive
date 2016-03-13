using GraphAssesment.Domain;
using GraphAssesment.Infrastructure.File;

namespace GraphAssesment.Application.DataLoader
{
    public interface IGraphFactory
    {
        GraphVertex Create(FileGraphVertex fileGraphVertex);
    }
}