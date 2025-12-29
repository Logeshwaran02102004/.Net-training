using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemotingTrn
{
    // This interface declares methods that can be called remotely
    public interface IMyinter
    {
        string Show(string name);
    }
}
