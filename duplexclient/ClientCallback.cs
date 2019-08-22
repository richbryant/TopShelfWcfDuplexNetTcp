using System;
using duplexclient.DuplexService;

namespace duplexclient
{
    public class ClientCallback : IDuplexServiceCallback
    {
        public void Tick(DateTime dateTime)
        {
            Console.WriteLine(dateTime);
        }
    }
}