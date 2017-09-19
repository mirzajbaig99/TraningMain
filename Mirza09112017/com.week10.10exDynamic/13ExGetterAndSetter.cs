using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mirza09112017.com.week10._10exDynamic
{
    class ExGetterAndSetter
    {
        public static void Main(string[] arg)
        {
            Employee alex = new Employee();
            alex.Grade = 55;

            // Throws an Argument Out of Range Exception
            alex.Grade = 99;
        }
    }

    class Employee
    {
        private int salary;
        public int bonus { private get; set; } // private is default

        public int Grade
        {
            get
            {
                return Grade;
            }
            set
            {
                if (value > 50 && value < 72)
                { salary = value; }
                else
                { throw new ArgumentOutOfRangeException(); }

            }
        }

    }

}
