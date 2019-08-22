using System;
using Topshelf;

namespace wcfduplex
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var host = HostFactory.New(config =>
                {
                    config.Service<DuplexHost>(callback =>
                    {
                        callback.ConstructUsing(s => new DuplexHost());
                        callback.WhenStarted(s => s.Start());
                        callback.WhenStopped(s => s.Stop());
                    });
                    config.SetDisplayName("DuplexService");
                    config.SetServiceName("DuplexService");
                    config.SetDescription("Simply ticks over net:tcp");
                });
                host.Run();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"DuplexService Fatal Exception : {ex.Message}");
            }
        }
    }
}
