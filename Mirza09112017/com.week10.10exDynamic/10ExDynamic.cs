using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mirza09112017.com.week10._10exDynamic
{
    public class ExDynamic
    {
        public bool IsPositiveNum(dynamic x)
        {
            return x >= 0;
        }
        
    }

    class TestDynamic
    {
        static void Main()
        {
            ExDynamic obj = new ExDynamic();
            Console.WriteLine(obj.IsPositiveNum("10.5"));
            Console.ReadLine();
        }
    }
}
