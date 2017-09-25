using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mirza09112017.DesignPatterns.Factory
{
    public class FactoryTest
    {
        public static void Main(string[] args)
        {
            ICalculate obj1 = new CalculateFactory().CreateCalculate(calculateType.CalculateA);
        }
    }
}
