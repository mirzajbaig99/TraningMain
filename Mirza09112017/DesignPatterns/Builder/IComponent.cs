using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mirza09112017.DesignPatterns.Builder
{
    public interface IComponent
    {
        void SetComponentA(string A);
        void SetComponentB(string B);
        void SetComponentC(string C);
        void SetComponentD(string D);
    }
}
