using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mirza09112017.DesignPatterns.Builder
{
    class Component : IComponent
    {
        private string _componentA;
        private string _componentB;
        private string _componentC;
        private string _componentD;

        public void SetComponentA(string A)
        {
            this._componentA = A;
        }

        public void SetComponentB(string B)
        {
            this._componentB = B;
        }

        public void SetComponentC(string C)
        {
            this._componentC = C;
        }

        public void SetComponentD(string D)
        {
            this._componentD = D;
        }

        public Component GetBuilderA()
        {
            return this;
        }
    }
}
