using System;
using System.Collections.Generic;

namespace MyOOPLesson.HomeWork4
{
    public class Game
    {
        const int PlayerNumber = 2;
        const int PokerCards = 52;

        public void GameStart()
        {
            Pokers pokers = new Pokers();
            pokers.IniPokerCards();

            Player player1 = new Player()
            {
                name = "Player1",
                pokerCard = pokers.DrawACard()
            };
            Console.WriteLine($"玩家:{player1.name}，抽到的牌是:{player1.pokerCard.Rank.ToString()} of {player1.pokerCard.Suit.ToString()}");

            Player player2 = new Player()
            {
                name = "Player2",
                pokerCard = pokers.DrawACard()
            };
            Console.WriteLine($"玩家:{player2.name}，抽到的牌是:{player2.pokerCard.Rank.ToString()} of {player2.pokerCard.Suit.ToString()}");
            var gameResult = WhoIsHigher(player1, player2);
            Console.WriteLine($"比大小結果為:{gameResult.ToString()}");
        }
        private GameResult WhoIsHigher(Player player1, Player player2)
        {
            if (player1.pokerCard.Rank > player2.pokerCard.Rank)
            {
                return GameResult.Player1Win;
            }

            if (player1.pokerCard.Rank == player2.pokerCard.Rank && player1.pokerCard.Suit > player2.pokerCard.Suit)
            {
                return GameResult.Player1Win;
            }

            return GameResult.Player2Win;
        }
        private enum GameResult
        {
            Player1Win,
            Player2Win
        }
    }
}
