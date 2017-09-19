using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mirza09112017.com.week20
{
    public class ExMockClasses
    {
        public static void Main(string[] arg)
        {
            Employee emp = new Employee(new OutlookEmail());
            emp.NotifyEmployee();
        }
    }
}
