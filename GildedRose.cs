using System.Collections.Generic;

namespace csharp
{
    public class GildedRose
    {
        private readonly IList<IAgeable> items;

        public GildedRose(IList<IAgeable> items)
        {
            this.items = items;
        }

        public void UpdateQuality()
        {        
            foreach(IAgeable item in items)
            {
                item.Age();
            }
        }
    }
}
