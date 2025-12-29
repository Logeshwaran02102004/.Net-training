using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentDay17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("NOTIFICATION FACTORY");

            Console.Write("Enter notification type email or sms or push: ");
            string type = Console.ReadLine();

            try
            {
                INotification notification = NotificationFactory.GetNotification(type);
                notification.Send("This is notificaton to test");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }




            Console.WriteLine("\n LOGGER");
            Logger log = Logger.GetInstance;
            log.WriteLog("Application has started");
            Logger log2 = Logger.GetInstance;
            log2.WriteLog("This is another log message");
            Console.WriteLine("Logs have been completed ");

            


            Console.WriteLine("\n GAME CHARACTER");
            Game_Character character = new Game_Character()
            {
                Health = 100,
                Attack = 20,
                Defense = 5,
                Skills = new List<string> { "Run", "Swim", "Dance" }
            };
            character.ShowData("RANDOM");
            Console.WriteLine("\n CLONE");
            Game_Character character1 = (Game_Character)character.Clone();
            character1.Health = 50;
            character1.Skills.Add("Walk");
            character1.ShowData("prototype");


            Console.WriteLine("\n DATA EXPORT TEMPLETE");
            Console.WriteLine("\nCSV");
            DataExporter exporter;
            exporter = new CsvExporter();
            exporter.Export();
            Console.WriteLine("\nSON");
            exporter = new JsonExporter();
            exporter.Export();
            Console.WriteLine("\nXML");
            exporter = new XmlExporter();
            exporter.Export();

            Console.ReadLine();
        }
    }
}
