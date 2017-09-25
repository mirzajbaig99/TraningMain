using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mirza09112017.DesignPatterns.Builder
{
    public class BuilderTest
    {
        public static void Main(string[] args)
        {
            IBuilderOrchestration orch = new BuilderOrchestration(new BuilderA());
            IComponent compA = orch.Build();
        }
    }
}
