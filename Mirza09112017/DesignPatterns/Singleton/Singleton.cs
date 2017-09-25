using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mirza09112017.DesignPatterns.Singleton
{
    public class Singleton
    {
        public static void Main(string[] arg)
        {
            // Always returns the static singleton instance for the app 
            var obj1 = Logger.Instance;
            var obj2 = Logger.Instance;

            Console.WriteLine((obj1 == obj2).ToString());
            Console.WriteLine(System.Object.ReferenceEquals(obj1, obj2).ToString());
            Console.ReadKey();
        }
    }
}
