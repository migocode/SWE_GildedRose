using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp
{
    public class AgedBrie : BaseGildedRoseItem
    {
        public AgedBrie(Item item) : base(item)
        { }

        public override void Age()
        {
            ChangeQualityBy(2);
            ChangeSellInBy(-1);
        }
    }
}
