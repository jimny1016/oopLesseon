using System;
using System.Collections.Generic;

namespace MyOOPLesson.HomeWork4
{
    public class Pokers
    {
        public enum Suit
        {
            Clubs,
            Diamonds,
            Hearts,
            Spades
        }
        public enum Rank
        {
            Ace,
            Tow,
            Three,
            Four,
            Five,
            Six,
            Seven,
            Eight,
            Nine,
            Ten,
            Jack,
            Queen,
            King
        }

        public struct PokerCard
        {
            public Suit Suit { get; set; }
            public Rank Rank { get; set; }
        }

        private List<PokerCard> PokerCards { get; set; }

        public void IniPokerCards()
        {
            List<PokerCard> pokerCards = new List<PokerCard>();
            foreach (Suit suit in (Suit[])Enum.GetValues(typeof(Suit)))
            {
                foreach (Rank rank in (Rank[])Enum.GetValues(typeof(Rank)))
                {
                    PokerCard pokerCard = new PokerCard();
                    pokerCard.Suit = suit;
                    pokerCard.Rank = rank;
                    pokerCards.Add(pokerCard);
                }
            }
            PokerCards = pokerCards;
        }

        Random Rnd = new Random();

        public PokerCard DrawACard()
        {
            int number = Rnd.Next(0, PokerCards.Count - 1);
            PokerCard pokerCard = PokerCards[number];
            PokerCards.RemoveAt(number);
            return pokerCard;
        }
    }
}
