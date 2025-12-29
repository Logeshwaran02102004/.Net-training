using System;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using RemotingTrn;   // for interface
  


namespace ClientApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Register TCP channel
            TcpChannel channel = new TcpChannel();
            ChannelServices.RegisterChannel(channel, false);

            // Connect to the remote object
            IMyinter ob = (IMyinter)Activator.GetObject(
                typeof(IMyinter),
                "tcp://localhost:8085/Hi"
            );

            Console.WriteLine("Connected to remote object...");
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            string result = ob.Show(name); // Call remote method
            Console.WriteLine(result);

            Console.ReadLine();
        }
    }
}
