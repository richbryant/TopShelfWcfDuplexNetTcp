using System;
using System.ServiceModel;

namespace wcfduplex
{
    public interface IDuplexCallback
    {
        [OperationContract(IsOneWay = true)]
        void Tick(DateTime dateTime);
    }
}