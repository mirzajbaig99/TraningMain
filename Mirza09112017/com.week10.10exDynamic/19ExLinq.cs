using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mirza09112017.com.week10._10exDynamic
{
    public class ExLinq
    {
        public static void Main(string[] arg)
        {
            int[] numbers = { 1, 2, 4, 5, 644, 4, 342, };

            IEnumerable<int> numQuery1 = from n in numbers
                                         where n > 0
                                         orderby n
                                         select n;

            numQuery1.ForEach(x => Console.WriteLine(x));
            Console.ReadKey();
        }
        
    }

    public static class Ext
    {
        public static IEnumerable<T> ForEach<T>(this IEnumerable<T> list, Action<T> action) 
        {
            // foreach (T item in list)
            // {
            //    action(item);
            // }

            IEnumerator<T> enumerator = list.GetEnumerator();
            while(enumerator.MoveNext())
            {
                action(enumerator.Current);
            }
            return list;
        }
    }
}
