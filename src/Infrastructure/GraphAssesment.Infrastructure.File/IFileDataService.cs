using System.Collections.Generic;

namespace GraphAssesment.Infrastructure.File
{
    public interface IFileDataService
    {
        IList<FileGraphVertex> GetGraphVertexes();
    }
}