using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp
{
    class BackstagePass : BaseGildedRoseItem
    {
        public BackstagePass(Item item) : base(item)
        { }

        public override void Age()
        {
            // Qualitiy usually increases by 1
            ChangeQualityBy(1);

            // 10 days before the concert, quality increases by 2
            if(SellIn <= 10)
            {
                ChangeQualityBy(1);
            }

            // 5 days before the concert, quality increases by 3
            if(SellIn <= 5)
            {
                ChangeQualityBy(1);
            }

            // After the concert, backstagepasses are worthless
            if(SellIn < 0)
            {
                ChangeQualityBy(-Quality);
            }

            ChangeSellInBy(-1);
        }
    }
}
