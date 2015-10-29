using System.ServiceModel;

// Контракт.

namespace HelloWCF
{    
    [ServiceContract]
    interface ISubject
    {
        [OperationContract]
        void Say(string input);
    }
}


