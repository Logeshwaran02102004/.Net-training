using System;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using RemoteLib;


namespace ServerApp
{
    class Program
    {
        static void Main()
        {
            // Create TCP channel on port 8085
            TcpChannel channel = new TcpChannel(8085);
            ChannelServices.RegisterChannel(channel, false);

            // Register remote service
            RemotingConfiguration.RegisterWellKnownServiceType(
                typeof(StudentService),
                "StudentService",
                WellKnownObjectMode.Singleton
            );

            Console.WriteLine("Server started... Listening on port 8085");
            Console.WriteLine("Press ENTER to stop the server.");
            Console.ReadLine();
        }
    }
}
