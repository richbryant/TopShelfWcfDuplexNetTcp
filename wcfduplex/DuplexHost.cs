using System;
using System.ServiceModel;

namespace wcfduplex
{
    internal class DuplexHost
    {
        private readonly ServiceHost _service;

        internal DuplexHost()
        {
            Console.WriteLine("Setting up services");
            _service = new ServiceHost(typeof(DuplexService));
        }

        public void Start()
        {
            Console.WriteLine("Setting up services");
            _service.Open();
            Console.WriteLine("Started!");

        }

        public void Stop()
        {
            Console.WriteLine("Stopping services");
            try
            {
                if (_service != null)
                {
                    if (_service.State == CommunicationState.Opened)
                    {
                        _service.Close();
                    }
                }

                Console.WriteLine("Stopped!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Could not stop: " + ex.Message);
            }
        }
    }
}