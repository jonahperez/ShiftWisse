using System;
using System.Collections.Generic;

namespace ShiftWise
{
    public class Deck
    {
        List<Card> m_cards = new List<Card>();
        public Deck()
        {
            FillDeck();
        }
        private void FillDeck()
        {
            foreach (Card.Suits suit in Enum.GetValues(typeof(Card.Suits)))
            {
                for (int rank = 1; rank <= 13; rank++)
                {
                    Card c = new Card(rank, suit);
                    m_cards.Add(c);  
                }
            }
        }
        public List<Card> Cards {
            get {
                return m_cards;
            }
        }
        public Boolean IsSorted()
        {
            int cardNumber = 0;
            foreach(Card.Suits suit in Enum.GetValues(typeof(Card.Suits)))
            {
                for (int rank = 1; rank <= 13; rank++)
                {
                    Card c = m_cards[cardNumber] ;
                    Card newC = new Card(rank, suit);
                    if (c.CompareTo(newC) != 0)
                        return false;
                    cardNumber++;
                }
            }
            return true;
        }
        public void Shuffle()
        {
            Random rnd = new Random();
            for (var i = 0; i < m_cards.Count; i++)
                Swap(m_cards, i, rnd.Next(i, m_cards.Count));
        }
        public void Sort()
        {
            m_cards.Sort();
        }
        private void Swap(List<Card> list, int i, int j)
        {
            Card temp = list[i];
            list[i] = list[j];
            list[j] = temp;
        }
    }
}
