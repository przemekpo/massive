using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphAssesment.Domain
{
    public interface IGraphRepository
    {
        Graph Get();
        string Add(Graph graph);
        void Update(Graph graph);
    }
}
