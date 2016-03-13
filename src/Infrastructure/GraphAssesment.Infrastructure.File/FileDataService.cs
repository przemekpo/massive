using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace GraphAssesment.Infrastructure.File
{
   public class FileDataService : IFileDataService
   {
       public IList<FileGraphVertex> GetGraphVertexes()
       {
            var vertexes = new List<FileGraphVertex>();
            foreach (string file in Directory.EnumerateFiles(@"C:\Users\Przemek Pc\Downloads\Input data", "*.xml"))
            {
                //refactor move xml serialziation to helper
                var contents = System.IO.File.ReadAllText(file);
                var x = new XmlSerializer(typeof(FileGraphVertex));
                vertexes.Add((FileGraphVertex)x.Deserialize(new StringReader(contents)));

             }
            return vertexes;
        }
    }
}
