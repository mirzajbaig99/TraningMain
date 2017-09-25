using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mirza09112017.DesignPatterns.Adapter
{
    public class AdapterTest
    {
        public static void Main(string[] args)
        {
            IVendor vendor = new VendorSystem();
            vendor.PrintAge("Sybase", "GE101");

            IClient client = new ClientSystem();
            client.PrintAge("GE101");

            IClient adapter = new VendorAdpater(vendor);
            adapter.PrintAge("GE101");

        }
    }
}
