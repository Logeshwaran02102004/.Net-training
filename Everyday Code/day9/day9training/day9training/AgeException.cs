using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day9training
{
    internal class AgeException:ApplicationException
    {
         string message;
        public AgeException(int msg)
        {
            message = msg + "is Invalid age .Age should me 21 to 80";
        }

        public override string ToString()
        {
            return message;
        }
    }
}
