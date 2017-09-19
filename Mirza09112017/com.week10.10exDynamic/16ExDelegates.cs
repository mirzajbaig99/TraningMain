using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mirza09112017.com.week10._10exDynamic
{
    public delegate int Calculate(int x, int y);

    class DelegateClass
    {
        public static int Add(int x, int y)
        {
            Console.WriteLine("Inside Add ");
            return x + y;
        }

        public static int Subtract(int x, int y)
        {
            Console.WriteLine("Inside Subtract ");
            return x - y;
        }

        public int Divide(int x, int y)
        {
            Console.WriteLine("Inside Divide ");
            return x / y;
        }
        public void MethodA(int x, int y, Calculate z)
        {
            Console.WriteLine(z(x, y));
        }

    }

    public class ExDelegates
    {
        public static void Main(string[] arg)
        {
            Calculate calc = DelegateClass.Add;
            Console.WriteLine(calc(6, 2));

            calc = DelegateClass.Subtract;
            Console.WriteLine(calc(6, 2));

            DelegateClass obj = new DelegateClass();
            calc = obj.Divide;
            Console.WriteLine(calc(6, 2));
            Console.WriteLine("-----------------------------");

            obj.MethodA(40, 20, calc);
            Console.WriteLine("-----------------------------");

            // multicasting : a chain of methods that will be automatically called when a delegate is invoked.
            calc = DelegateClass.Add;
            calc += DelegateClass.Subtract;
            calc += obj.Divide;

            //value returned by the last method in the list becomes the return value of the entire delegate invocation.
            Console.WriteLine(calc(6, 2));
            Console.WriteLine("-----------------------------");
            calc = DelegateClass.Subtract;

            obj.MethodA(40, 20, calc);

            Console.ReadKey();
        }
    }
}
