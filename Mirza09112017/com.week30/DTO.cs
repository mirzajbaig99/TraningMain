using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mirza09112017.com.week30
{
    public class Employee
    {
        public string FName;
        public string LName;
        public double Salary;
    }


    public class Person
    {
        public string FirstName;
        public string LastName;
    }

    public class Customer
    {
        public string FirstName;
        public string LastName;
        public double Salary;
    }

    public class Account
    {
        public int AccountId;
        public DateTime Year;
        public Customer Customer;

    }

    public class AccountDto
    {
        public int AccountId;
        public DateTime Year;
        public string FirstName;
        public string LastName;
        public double Salary;

    }


}
