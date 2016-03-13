using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphAssesment.DataLoader
{
    class Program
    {
        static void Main(string[] args)
        {
            IoC.Init(ContainerConfig.Configure());
            var sync = IoC.Resolve<Application.DataLoader.DataLoader>();
            sync.Load();
        }
    }
}
