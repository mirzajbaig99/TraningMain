using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mirza09112017.com.week10._10exDynamic
{
    public static class _23ExInterfaceExtMethod
    {
        public static string Prompt(this IConsoleInterface con, string message)
        {
            con.WriteLine(message);
            return con.ReadLine();
            
        }
        public static void Main(string[] arg)
        {
            IConsoleInterface con = new ConsoleInterface();
            var input = con.Prompt("Input Number");
            Console.WriteLine(input);
        }
    }
}
