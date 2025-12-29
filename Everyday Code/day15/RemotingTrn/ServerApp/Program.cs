using System;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using RemotingTrn;   // for interface
using RemotingLib;   // server only


namespace ServerApp
{
    public class ServerClass
    {
        public static void Main()
        {
            // Create TCP channel on port 8085
            TcpChannel channel = new TcpChannel(8085);
            ChannelServices.RegisterChannel(channel, false);

            // Register the service type for remote access
            RemotingConfiguration.RegisterWellKnownServiceType(
                typeof(ServiceClass), // class to expose
                "Hi",                  // object URI
                WellKnownObjectMode.Singleton // or SingleCall
            );

            Console.WriteLine("Server started... Listening on port 8085");
            Console.WriteLine("Press ENTER to stop the server.");
            Console.ReadLine();
        }
    }
}
