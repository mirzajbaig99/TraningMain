using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mirza09112017.DesignPatterns.Builder
{
    public interface IBuilder
    {
        IBuilder BuildComponentA(string A);
        IBuilder BuildComponentB(string A);
        IBuilder BuildComponentC(string A);
        IBuilder BuildComponentD(string A);

        IComponent GetComponent();
        
    }
}
