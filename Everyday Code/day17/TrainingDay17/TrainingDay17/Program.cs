using System;
using TrainingDay17;
using Unity;

namespace YourProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== UNITY IoC ===");
            IUnityContainer u = new UnityContainer();
            u.RegisterType<Iservice, service>();
            var obj = u.Resolve<Mathcls>();
            obj.show();

            Console.WriteLine("\n=== SINGLETON ===");
            var s = Singleton.GetInstance;
            s.Method();

            Console.WriteLine("\n=== FACTORY ===");
            var db = factory.GetInstance(3);
            foreach (var item in db.ShowData())
                Console.WriteLine(item);

            Console.WriteLine("\n=== PROTOTYPE ===");
            Class1 ob = new Class1() { p1 = 100, p2 = 200 };
            Class1 ob2 = (Class1)ob.Clone();
            ob2.p2 = 500;

            Console.WriteLine("User1:");
            Console.WriteLine(ob.p1);
            Console.WriteLine(ob.p2);

            Console.WriteLine("User2:");
            Console.WriteLine(ob2.p1);
            Console.WriteLine(ob2.p2);

            Console.WriteLine("\n=== ADAPTER ===");
            IPrinter p1 = new ModernPrinter();
            p1.Print("hello world");

            LegacyPrinter oldPrinter = new LegacyPrinter();
            IPrinter p2 = new LegacyPrinterAdapter(oldPrinter);
            p2.Print("good afternoon");

            Console.ReadLine();
        }
    }
}
