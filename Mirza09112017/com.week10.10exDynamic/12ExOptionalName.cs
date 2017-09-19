using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mirza09112017.com.week10._10exDynamic
{
    class ExOptionalName
    {
        public static void SomeMethod(int a = 10,int b = 20, int c = 30)
        {
            Console.WriteLine($"a = {a} b = {b} c = {c}");
        }

        static void Main(string[] args)
        {
            SomeMethod(10, 20, 30);
            SomeMethod();
            SomeMethod(11);
            SomeMethod(a: 11, c: 33);
        }
    }
}
