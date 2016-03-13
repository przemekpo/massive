using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphAssesment.Domain
{
    public class GraphVertex
    {
        //as id I will use Id from file since its uniq but normally 
        //i would set id from file as ExternalId and use generated uniq id 
        //this approuch would need processing of seting adjacent nodes
        public string Id { get; set; }
        public string Label { get; set; }
        public List<string> AdjacentIds { get; set; }

        public void UpdateFromExternal(string label, List<string> adjacentNodesIds)
        {
            Label = label;
            AdjacentIds = adjacentNodesIds;
        }
    }
}
