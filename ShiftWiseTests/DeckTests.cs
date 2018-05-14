using NUnit.Framework;
namespace ShiftWise.Tests
{
    [TestFixture]
    public class DeckTests
    {
        [Test]
        public void DeckHas52Cards()
        {
            Deck d = new Deck();
            Assert.That(d.Cards.Count == 52);
        }
        [Test]
        public void DeckIsSorted()
        {
            Deck d = new Deck();
            Assert.That(d.IsSorted());
        }
        [Test]
        public void DeckIsNotSorted()
        {
            Deck d = new Deck();
            d.Shuffle();
            Assert.IsFalse(d.IsSorted());
        }
        [Test]
        public void DeckIsReSorted() {
            Deck d = new Deck();
            d.Shuffle();
            d.Sort();
            Assert.That(d.IsSorted());
        }
    }
}