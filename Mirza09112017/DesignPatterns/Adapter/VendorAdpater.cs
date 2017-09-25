using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mirza09112017.DesignPatterns.Adapter
{
    public class VendorAdpater : IClient
    {
        private IVendor _vendor;

        public VendorAdpater(IVendor vender)
        {
            this._vendor = vender;
        }

        public string ConnectToFileSystem(string customerId)
        {
            // connect to an xml file and get the sybase connection string.
            string connectionString = "Sybase XML";
            string result = this._vendor.ConnectToDb(connectionString, customerId);
            return result;
        }

        public void PrintAge(string customerId)
        {
            string result = ConnectToFileSystem(customerId);
            Console.WriteLine("Adapter : get age using connection : " + result);
        }


    }
}
