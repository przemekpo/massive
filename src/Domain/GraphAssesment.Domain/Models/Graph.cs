using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GraphAssesment.Domain.Strategies;

namespace GraphAssesment.Domain
{
    public class Graph
    {
        public string Id { get; set; }
        public GraphType Type { get; set; }
        public List<GraphVertex> Vertexes { get; private set; }

        
        public void SetVertexes(List<GraphVertex> vertexes)
        {
            Vertexes = vertexes;
        }

        public GraphVertex GetVertex(string id)
        {
            return Vertexes?.FirstOrDefault(p => p.Id == id);
        }

        public void UpdateFromExternal(List<GraphVertex> vertexes)
        {
            SetVertexes(vertexes);
        }

        //aggregate creation method
        //simplified, normally it also should be reposinble for creation of graphVertices
        public static Graph Create(List<GraphVertex> graphVertices)
        {
            var graph = new Graph();
            graph.SetVertexes(graphVertices);

            return graph;
        }
    }
}
