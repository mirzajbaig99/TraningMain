using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mirza09112017.DesignPatterns.Adapter
{
    public interface IVendor
    {
        string ConnectToDb(string connectionString, string customerId);
        void PrintAge(string connectionString, string customerId);
    }

    public class VendorSystem : IVendor
    {

        public string ConnectToDb(string connectionString, string customerId)
        {
            Console.WriteLine("Vendor : Select from Db " + connectionString
                + " where " + customerId);
            return "Vendor : age is 37 from Db " + connectionString;
        }

        public void PrintAge(string connectionString, string customerId)
        {
            string result = ConnectToDb(connectionString, customerId);
            Console.WriteLine("Vendor : get age using connection : " + result);
        }
    }

}
