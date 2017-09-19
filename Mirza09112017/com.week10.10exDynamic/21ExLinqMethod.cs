using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mirza09112017.com.week10._10exDynamic
{
    public class ExLinqMethod
    {
            static void Main()
            {


                List<int> nums = new List<int>();
                nums.Add(1); nums.Add(-2); nums.Add(3); nums.Add(0); nums.Add(-4); nums.Add(5); nums.Add(11); nums.Add(6); nums.Add(10);

                // Create a query that obtains only positive numbers.

                var posNums = nums.Where(n => n > 0);

                Console.Write("The positive values in nums: ");

                // Execute the query and display the results.
                foreach (int i in posNums) Console.Write(i + " ");

                Console.WriteLine("\n-----------------");

                var mul10 = nums.Where(n => n > 0).Select(r => r * 10);

                foreach (int i in mul10) Console.Write(i + " ");

                Console.WriteLine("\n-----------------");

                IEnumerable<int> numQuery2 = nums.Where(n => n % 2 == 0).OrderBy(n => n);

                foreach (int i in numQuery2) Console.Write(i + " ");

                Console.WriteLine("\n-----------------");

                var posNumRange = nums.Where(n => n > 0 && n < 10);

                foreach (int i in posNumRange) Console.Write(i + " ");

                Console.WriteLine("\n-----------------");

                var posNumsOrder = nums.OrderBy(n => n);

                foreach (int i in posNumsOrder) Console.Write(i + " ");

                Console.WriteLine("\n-----------------");


                var sqrRoots = nums.Where(n => n > 0).Select(r => Math.Sqrt(r));

                foreach (double r in sqrRoots) Console.Write("{0:#.##}  ", r);

                Console.WriteLine("\n-----------------");
                // immediate execution 
                int len = nums.Count(n => n > 0);

                Console.WriteLine("The number of positive values in nums: " + len);

                Console.WriteLine("\n-----------------");


                Console.WriteLine("Count " + nums.Count()); // query executes here
                Console.WriteLine("Max " + nums.Max());
                Console.WriteLine("Min " + nums.Min());
                Console.WriteLine("Average " + nums.Average());
                Console.WriteLine("Sum " + nums.Sum());


                Console.WriteLine("\n-----------------");
            }
        }

}

