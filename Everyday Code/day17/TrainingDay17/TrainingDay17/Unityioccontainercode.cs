using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingDay17
{
    public interface Iservice
    {
        void DoSomething();
    }


    public class service : Iservice
    {
        public void DoSomething()
        {
            Console.WriteLine("Service working...");
        }
    }


    public class Mathcls
    {
        private readonly Iservice _service;

        public Mathcls(Iservice service)
        {
            _service = service;
        }

        public void show()
        {
            _service.DoSomething();
        }
    }

}
