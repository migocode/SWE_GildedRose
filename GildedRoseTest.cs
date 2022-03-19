using NUnit.Framework;
using System;

namespace csharp
{
    [TestFixture]
    public class GildedRoseTest
    {
        [Test]
        public void DexterityVest()
        {
            IAgeable dexterityVest = Stock.Items[0];

            string referenceName = dexterityVest.Name;

            for (int i = 0; i < 31; i++)
            {
                Console.WriteLine("-------- day " + i + " --------");
                dexterityVest.Age();
            }

            Assert.AreEqual(referenceName, dexterityVest.Name);
            Assert.AreEqual(0, dexterityVest.Quality);
            Assert.AreEqual(-21, dexterityVest.SellIn);
        }

        [Test]
        public void AgedBrie()
        {
            IAgeable dexterityVest = Stock.Items[1];

            string referenceName = dexterityVest.Name;
            for (var i = 0; i < 31; i++)
            {
                dexterityVest.Age();
            }

            Assert.AreEqual(dexterityVest.Name, referenceName);
            Assert.AreEqual(50, dexterityVest.Quality);
            Assert.AreEqual(-29, dexterityVest.SellIn);
        }

        [Test]
        public void ElixirOfTheMongoose()
        {
            IAgeable dexterityVest = Stock.Items[2];

            string referenceName = dexterityVest.Name;
            for (var i = 0; i < 31; i++)
            {
                dexterityVest.Age();
            }

            Assert.AreEqual(dexterityVest.Name, referenceName);
            Assert.AreEqual(0, dexterityVest.Quality);
            Assert.AreEqual(-26, dexterityVest.SellIn);
        }

        [Test]
        public void Sulfaras1()
        {
            IAgeable dexterityVest = Stock.Items[3];

            string referenceName = dexterityVest.Name;
            for (var i = 0; i < 31; i++)
            {
                dexterityVest.Age();
            }

            Assert.AreEqual(dexterityVest.Name, referenceName);
            Assert.AreEqual(80, dexterityVest.Quality);
            Assert.AreEqual(0, dexterityVest.SellIn);
        }

        [Test]
        public void Sulfaras2()
        {
            IAgeable dexterityVest = Stock.Items[4];

            string referenceName = dexterityVest.Name;
            for (var i = 0; i < 31; i++)
            {
                dexterityVest.Age();
            }

            Assert.AreEqual(dexterityVest.Name, referenceName);
            Assert.AreEqual(80, dexterityVest.Quality);
            Assert.AreEqual(-1, dexterityVest.SellIn);
        }

        [Test]
        public void BackstagePass1()
        {
            IAgeable dexterityVest = Stock.Items[5];

            string referenceName = dexterityVest.Name;
            for (var i = 0; i < 31; i++)
            {
                dexterityVest.Age();
            }

            Assert.AreEqual(dexterityVest.Name, referenceName);
            Assert.AreEqual(0, dexterityVest.Quality);
            Assert.AreEqual(-16, dexterityVest.SellIn);
        }

        [Test]
        public void BackstagePass2()
        {
            IAgeable dexterityVest = Stock.Items[6];

            string referenceName = dexterityVest.Name;
            for (var i = 0; i < 31; i++)
            {
                dexterityVest.Age();
            }

            Assert.AreEqual(dexterityVest.Name, referenceName);
            Assert.AreEqual(0, dexterityVest.Quality);
            Assert.AreEqual(-21, dexterityVest.SellIn);
        }

        [Test]
        public void BackstagePass3()
        {
            IAgeable dexterityVest = Stock.Items[7];

            string referenceName = dexterityVest.Name;
            for (var i = 0; i < 31; i++)
            {
                dexterityVest.Age();
            }

            Assert.AreEqual(dexterityVest.Name, referenceName);
            Assert.AreEqual(0, dexterityVest.Quality);
            Assert.AreEqual(-26, dexterityVest.SellIn);
        }

        [Test]
        public void ManaCake()
        {
            IAgeable dexterityVest = Stock.Items[8];

            string referenceName = dexterityVest.Name;
            for (var i = 0; i < 31; i++)
            {
                dexterityVest.Age();
            }

            Assert.AreEqual(dexterityVest.Name, referenceName);
            Assert.AreEqual(0, dexterityVest.Quality);
            Assert.AreEqual(-28, dexterityVest.SellIn);
        }
    }
}
