using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp
{
    public static class Stock
    {
        public static IList<IAgeable> Items { get; }

        static Stock()
        {
            Items = new List<IAgeable>{
                new BaseGildedRoseItem(new Item {Name = "+5 Dexterity Vest", SellIn = 10, Quality = 20}),
                new AgedBrie(new Item {Name = "Aged Brie", SellIn = 2, Quality = 0}),
                new BaseGildedRoseItem(new Item {Name = "Elixir of the Mongoose", SellIn = 5, Quality = 7}),
                new Sulfaras(new Item {Name = "Sulfuras, Hand of Ragnaros", SellIn = 0, Quality = 80}),
                new Sulfaras(new Item {Name = "Sulfuras, Hand of Ragnaros", SellIn = -1, Quality = 80}),
                new BackstagePass(new Item
                {
                    Name = "Backstage passes to a TAFKAL80ETC concert",
                    SellIn = 15,
                    Quality = 20
                }),
                new BackstagePass(new Item
                {
                    Name = "Backstage passes to a TAFKAL80ETC concert",
                    SellIn = 10,
                    Quality = 49
                }),
                new BackstagePass(new Item
                {
                    Name = "Backstage passes to a TAFKAL80ETC concert",
                    SellIn = 5,
                    Quality = 49
                }),
				// this conjured item does not work properly yet
				new BaseGildedRoseItem(new Item {Name = "Conjured Mana Cake", SellIn = 3, Quality = 6})
            };
        }
    }
}
