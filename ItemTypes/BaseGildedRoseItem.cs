using System;

namespace csharp
{
    public class BaseGildedRoseItem : IAgeable
    {
        protected readonly Item item;

        public string Name
        {
            get
            {
                return item.Name;
            }
            set
            {
                item.Name = value;
            }
        }

        public int SellIn
        {
            get
            {
                return item.SellIn;
            }
            protected set
            {
                item.SellIn = value;
            }
        }

        public int Quality
        {
            get
            {
                return item.Quality;
            }
            protected set
            {
                item.Quality = value;
            }
        }

        public virtual int QualityUpperLimit
        {
            get
            {
                return 50;
            }
        }

        public BaseGildedRoseItem(Item item)
        {
            this.item = item;
        }

        public override string ToString()
        {
            return string.Format("{0, -50}{1, 8}{2, 8}", Name, SellIn, Quality);
        }

        public virtual void Age()
        {
            int reduceQualityBy = -1;
            if(SellIn <= 0)
            {
                reduceQualityBy = -2;
            }

            ChangeQualityBy(reduceQualityBy);
            ChangeSellInBy(-1);
        }

        protected void ChangeQualityBy(int changeBy)
        {
            if(Quality + changeBy > QualityUpperLimit)
            {
                Quality = QualityUpperLimit;
                return;
            }

            if(Quality + changeBy < 0)
            {
                Quality = 0;
                return;
            }

            Quality += changeBy;
        }

        protected void ChangeSellInBy(int changeBy)
        {
            SellIn += changeBy;
        }

        static public implicit operator BaseGildedRoseItem(Item item)
        {
            return new BaseGildedRoseItem(item);
        }
    }
}
