using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingDay17
{
    internal class Class1
    {
        public int p1 { get; set; }
        public int p2 { get; set; }

        public object Clone()
        {
            return this.MemberwiseClone(); // shallow copy
        }
    }


}
