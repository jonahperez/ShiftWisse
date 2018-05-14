using NUnit.Framework;
using ShiftWise;
using System;

namespace NUnit.Tests1
{
    [TestFixture]
    public class CardTests
    {
        Card card = new Card();
        [Test]
        public void TestRankMinMax()
        {
            // check for exception if rank is too low
            try
            {
                card.Rank = 0;
                Assert.Fail("Value is out of bounds and no exception was thrown");
            }
            catch (Exception){ }
            // check for exception if rank is too high
            try
            {
                card.Rank = 14;
                Assert.Fail("Value is out of bounds and no exception was thrown");
            }
            catch (Exception) {}
        }
        [Test]
        public void TestRankInRange()
        {
            card.Rank = 10;
            Assert.Pass();
        }
        [Test]
        public void TestToString()
        {
            card.Rank = 5;
            card.Suit = Card.Suits.Diamond;
            String val = card.ToString() ;
            if (!card.ToString().Equals("5D")) Assert.Fail("Unexpected ToString return for Diamonds");

            card.Rank = 1;
            card.Suit = Card.Suits.Spade;
            if (!card.ToString().Equals("AS")) Assert.Fail("Unexpected ToString return Spades");

            card.Rank = 11;
            card.Suit = Card.Suits.Club;
            if (!card.ToString().Equals("JC")) Assert.Fail("Unexpected ToString return Clubs");

            card.Rank = 12;
            card.Suit = Card.Suits.Heart;
            if (!card.ToString().Equals("QH")) Assert.Fail("Unexpected ToString return Hears");

            card.Rank = 13;
            if (!card.ToString().Equals("KH")) Assert.Fail("Unexpected ToString return");
        }

        [Test]
        public void TestCompareCardsOfSameRank()
        {
            Card high = new Card();
            Card low = new Card();

            high.Rank = 10;
            low.Rank = 10;

            high.Suit = Card.Suits.Spade;
            low.Suit = Card.Suits.Heart;
            if (low.CompareTo(high) >= 0) Assert.Fail("Spade should sort after Heart");

            if (high.CompareTo(low) <= 0) Assert.Fail("Heart should be before Spade");

            low.Suit = Card.Suits.Spade;
            if (high.CompareTo(low) != 0) Assert.Fail("Let's call a spade a spade");
        }
        [Test]
        public void TestConstructor()
        {
            Card c = new Card(4, Card.Suits.Heart);
            Assert.That(c.ToString().Equals("4H"));
        }
    }
}
