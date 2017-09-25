using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mirza09112017.DesignPatterns.Builder
{

    // This would be the application code calling the builder , in this example its a dedicated class
    public class BuilderOrchestration : IBuilderOrchestration
    {
        readonly private IBuilder _builder;

        public BuilderOrchestration(IBuilder builder)
        {
            this._builder = builder;
        }

        public IComponent Build()
        {
            // Decides the flow
            return this._builder.BuildComponentA("A")
                .BuildComponentB("B")
                .BuildComponentC("C")
                .BuildComponentD("D")
                .GetComponent();
        }

        public IComponent ReturnComponent()
        {
            // Decides the flow
            return this._builder.BuildComponentA("A")
                .BuildComponentB("B")
                .BuildComponentC("C")
                .BuildComponentD("D")
                .GetComponent();
        }

    }
}
