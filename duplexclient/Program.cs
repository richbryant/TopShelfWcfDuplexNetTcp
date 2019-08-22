using System;
using System.ServiceModel;
using duplexclient.DuplexService;

namespace duplexclient
{
    class Program
    {
        static void Main(string[] args)
        {
            var callback = new InstanceContext(new ClientCallback());
            var client = new DuplexServiceClient(callback);
            client.Open();
            client.Register();
            Console.WriteLine("Press a key to exit");
            Console.ReadKey();
            client.Close();
        }
    }
}
