    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace Mirza09112017.com.week10._10exDynamic
{
        public class ConsoleInterface : IConsoleInterface
        {

            public string ReadLine()
            {
                return Console.ReadLine();
            }

            public void Write(string message)
            {
                Console.Write(message);
            }

            public void WriteLine(string message)
            {
                Console.WriteLine(message);
            }
        }
    }


