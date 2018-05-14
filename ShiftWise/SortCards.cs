using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShiftWise
{
    class SortCards
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ShiftWise Code Chalange");
            Deck d = new Deck();
            Console.WriteLine("Press any key to see a new deck of cards.");
            Console.ReadKey();
            ShowDeck(d);
            Console.WriteLine("Press any key to see the shuffled deck.");
            Console.ReadKey();
            d.Shuffle();
            ShowDeck(d);
            Console.WriteLine("Press any key to see the resorted deck.");
            Console.ReadKey();
            d.Sort();
            ShowDeck(d);
            Console.WriteLine("Press any key to end");
            Console.ReadKey();
        }
        private static void ShowDeck(Deck d)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < d.Cards.Count; i++)
            {
                sb.Append(d.Cards[i]);
                if (i<d.Cards.Count -1 ) sb.Append(",");
            }
            Console.WriteLine(sb);

        }
    }
}
