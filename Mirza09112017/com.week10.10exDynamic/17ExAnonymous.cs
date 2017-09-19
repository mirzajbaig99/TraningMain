using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mirza09112017.com.week10._10exDynamic
{
    public delegate int Calculate(int x, int y);

    public class ExAnonymous
    {
        static void Main(string[] arg)
        {
            //Calculate calc = delegate (int x, int y) {
            //    Console.WriteLine("Add ");
            //    return x + y;
            //};

            Calculate calc = (x, y) =>
            {
                Console.WriteLine("Add ");
                return x + y;
            };

            //calc += delegate (int x, int y)
            //{
            //    Console.WriteLine("Subtract ");
            //    return x - y;
            //};

            calc = (x, y) =>
            {
                Console.WriteLine("Subtract ");
                return x - y;
            };


            Console.WriteLine(calc(6, 2));

            Func<int, int> fcalc = (x) => x * 2;
            Console.WriteLine(fcalc(4));

            Func<int, int, int> op = (x, y) => x * 2;
            Console.WriteLine(op(2,3));
            Func<int, bool> pos = x => x > 0;

            Predicate<int> predicate = x => x > 0;

            Action<int> act = x => Console.WriteLine("Action");

            Console.WriteLine(pos(-2));
            Console.ReadKey();
        }
    }
}
