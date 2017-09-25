using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mirza09112017.DesignPatterns.Adapter
{
    public interface IClient
    {
        string ConnectToFileSystem(string customerId);
        void PrintAge(string customerId);
    }
    public class ClientSystem : IClient
    {
        public string ConnectToFileSystem(string customerId)
        {
            Console.WriteLine("Client : select from local .txt file where " + customerId);
            return "Client : age is 50 from File";
        }

        public void PrintAge(string customerId)
        {
            string result = ConnectToFileSystem(customerId);
            Console.WriteLine("Client : get age using connection " + result);
        }
    }

}
