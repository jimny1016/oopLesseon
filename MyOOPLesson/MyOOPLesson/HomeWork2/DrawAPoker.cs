using System;

namespace MyOOPLesson
{
    public class DrawAPoker
    {
        Random Rnd = new Random();
        public void Start()
        {
            Suit suit = RandomSuit();
            if (suit == Suit.Joker)
            {
                Console.WriteLine("You got a Joker!");
                return;
            }
            Rank rank = RandomRank();
            Console.WriteLine($"You got {rank.ToString()} of {suit.ToString()}!");
            Console.ReadLine();
        }
        public void TestAllCombo()
        {
            foreach (Suit suit in (Suit[])Enum.GetValues(typeof(Suit)))
            {
                foreach (Rank rank in (Rank[])Enum.GetValues(typeof(Rank)))
                {
                    if (suit == Suit.Joker)
                    {
                        Console.WriteLine("You got a Joker!");
                        continue;
                    }
                    Console.WriteLine($"You got {rank.ToString()} of {suit.ToString()}!");
                }
            }
            Console.ReadLine();
        }
        private Suit RandomSuit()
        {
            return (Suit)Rnd.Next(0, 4);
        }
        private Rank RandomRank()
        {
            return (Rank)Rnd.Next(0, 12);
        }
        private enum Suit
        {
            Hearts,
            Diamonds,
            Spades,
            Clubs,
            Joker
        }
        private enum Rank
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
    }
}
