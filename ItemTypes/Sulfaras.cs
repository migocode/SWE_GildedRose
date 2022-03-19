using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp
{
    public class Sulfaras : BaseGildedRoseItem
    {
        public Sulfaras(Item item) : base(item)
        { }

        public override int QualityUpperLimit
        {
            get
            {
                return 80;
            }
        }

        public override void Age()
        {
            ChangeQualityBy(0);
            ChangeSellInBy(0);
        }
    }
}
