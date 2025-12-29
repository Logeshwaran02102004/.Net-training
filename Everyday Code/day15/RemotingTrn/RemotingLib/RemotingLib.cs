using System;
using System.Runtime.Remoting;
using RemotingTrn;

namespace RemotingLib
{
    // Implements the interface and allows remote calls
    public class ServiceClass : MarshalByRefObject, IMyinter
    {
        public string Show(string name)
        {
            Console.WriteLine($"Message received from the client: {name}");
            return $"Hello {name}, how are you!!";
        }
    }
}
