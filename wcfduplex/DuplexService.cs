using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Threading;


namespace wcfduplex
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "DuplexService" in both code and config file together.
    public class DuplexService : IDuplexService
    {
        private readonly Timer timer;
        private readonly List<IDuplexCallback> callbacks = new List<IDuplexCallback>();

        public DuplexService()
        {
            timer = new Timer(TimerCallback);
            timer.Change(TimeSpan.FromSeconds(10), TimeSpan.FromSeconds(10));
        }
 
        private void TimerCallback(object o)
        {
            foreach (var callback in callbacks)
            {
                callback.Tick(DateTime.Now);
            }
        }

        public void Register()
        {
            callbacks.Add(OperationContext.Current.GetCallbackChannel<IDuplexCallback>());
        }
    }
}
