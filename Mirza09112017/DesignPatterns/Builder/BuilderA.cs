using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mirza09112017.DesignPatterns.Builder
{
    class BuilderA : IBuilder
    {
            private IComponent _component;
            
            public IBuilder BuildComponentA(string A)
            {
                this._component.SetComponentA(A);
                return this;
            }

            public IBuilder BuildComponentB(string B)
            {
                this._component.SetComponentA(B);
                return this;
            }

            public IBuilder BuildComponentC(string C)
            {
                this._component.SetComponentC(C);
                return this;
            }

            public IBuilder BuildComponentD(string D)
            {
                this._component.SetComponentC(D);
                return this;
            }

            public IComponent GetComponent()
            {
                return this._component;
            }
        }
}
