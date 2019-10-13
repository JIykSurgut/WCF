using System.ServiceModel;

namespace Server
{    
    [ServiceContract]
    public interface IServer
    {
        [OperationContract]
        string GetData(int value);
    } 
}
