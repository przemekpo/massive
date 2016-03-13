using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using GraphAssesment.Application.WebService;

namespace GraphAssesment.WebService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IGraphService
    {      

        [OperationContract]
        GraphVm GetGraph();

        [OperationContract]
        GraphVertexVm GetGraphVertex(string id);

        [OperationContract]
        List<string> GetGraphShoretsRout(string startVertexId, string endVertexId);

    }


   
}
