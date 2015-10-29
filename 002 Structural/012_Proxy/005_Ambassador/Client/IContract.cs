using System.ServiceModel;

// Контракт.

namespace Client
{    
    [ServiceContract]
    interface ISubject
    {
        [OperationContract]
        void Say(string input);
    }
}
