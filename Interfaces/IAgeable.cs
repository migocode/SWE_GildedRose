using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp
{
    public interface IAgeable
    {
        string Name { get; }
        int Quality { get; }
        int SellIn { get; }
        void Age();
        string ToString();
    }
}
