using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mirza09112017.DesignPatterns.Factory
{
    public class CalculateA : ICalculate
    {
        double ICalculate.CalculateAnswer(double num1,double num2)
        {
            return num1;
        }
    }

    public class CalculateB : ICalculate
    {
        double ICalculate.CalculateAnswer(double num1, double num2)
        {
            return num1;
        }
    }

    public class CalculateC : ICalculate
    {
        double ICalculate.CalculateAnswer(double num1, double num2)
        {
            return num1;
        }
    }
}
