using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mirza09112017.DesignPatterns.Builder
{
    // Reuse Orchestration for Builder A and Builder B
    public interface IBuilderOrchestration 
    {
        IComponent ReturnComponent();
        IComponent Build();
    }
}
