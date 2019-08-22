using System.ServiceModel;

namespace wcfduplex
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IDuplexService" in both code and config file together.
    [ServiceContract(CallbackContract = typeof(IDuplexCallback))]
    public interface IDuplexService
    {
        [OperationContract]
        void Register();
    }
}
