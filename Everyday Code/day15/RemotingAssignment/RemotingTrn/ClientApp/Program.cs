using System;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using System.Threading.Tasks;
using RemoteTrn;

namespace ClientApp
{
    class Program
    {
        static async Task Main()
        {
            // Register TCP channel
            TcpChannel channel = new TcpChannel();
            ChannelServices.RegisterChannel(channel, false);

            // Connect to remote StudentService
            IStudentService service = (IStudentService)Activator.GetObject(
                typeof(IStudentService),
                "tcp://localhost:8085/StudentService"
            );

            Console.WriteLine("Connected to remote StudentService...");

            // Show all students
            await service.ShowAllStudents();

            // Fetch a specific student
            Console.Write("\nEnter Student ID to fetch: ");
            int id = int.Parse(Console.ReadLine());

            ClassStudent student = await service.GetStudentAsync(id);
            Console.WriteLine($"\nFetched Student: {student}");
        }
    }
}
