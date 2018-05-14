using System;

namespace ShiftWise
{
    public class Card : IComparable
    {
        public Card() { }
        public Card(int rank, Suits suit)
        {
            Rank = rank;
            Suit = suit;
        }
        public enum Suits { Club, Diamond, Heart, Spade}
        private int m_rank;
        public int Rank
        {
            get
            {
                return m_rank;
            }
            set
            {
                if (value > 13 || value < 1) throw new Exception("Rank must be between 1 and 13");
                m_rank = value;
            }
        }
      
        public Suits Suit { get; set; }

        public override String ToString()
        {
            String rank = m_rank.ToString();
            switch (m_rank)
            {
                case 1:
                    rank = "A";
                    break;
                case 11:
                    rank = "J";
                    break;
                case 12:
                    rank = "Q";
                    break;
                case 13:
                    rank = "K";
                    break;                   
            }
            switch (Suit)
            {
                case Suits.Club:
                    return rank + "C";
                case Suits.Diamond:
                    return rank + "D";
                case Suits.Heart:
                    return rank + "H";
                default:
                    return rank + "S";
            }
        }
        public int CompareTo(object obj)
        {
            if (obj == null) return 1;
     
            Card otherCard = obj as Card;
            
            //for cards of the same suit, sort by rank.
            if (this.Suit == otherCard.Suit)
                return this.Rank.CompareTo(otherCard.Rank);
            return this.Suit.CompareTo(otherCard.Suit);
        }
    }
}
