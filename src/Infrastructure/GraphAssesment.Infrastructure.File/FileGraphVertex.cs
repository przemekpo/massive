using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace GraphAssesment.Infrastructure.File
{
    [XmlRoot("node")]
    public class FileGraphVertex
    {
        [XmlElement("id")]
        public string Id { get; set; }
        [XmlElement("label")]
        public string Label { get; set; }
        [XmlArray("adjacentNodes")]
        [XmlArrayItem("id")]
        public string[] AdjacentVertexesIds { get; set; }
    }

}
