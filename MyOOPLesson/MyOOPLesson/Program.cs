using MyOOPLesson.HomeWork4;
using System;
using System.Threading;

namespace MyOOPLesson
{
    class Program
    {
        static void Main(string[] args)
        {
            //Mora mora = new Mora();
            //mora.Start();
            //DrawAPoker drawAPoker = new DrawAPoker();
            //drawAPoker.Start();
            //GetVIPInfo getVIPInfo = new GetVIPInfo();
            //getVIPInfo.test();

            Game game = new Game();
            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(1500);
                game.GameStart();
            }

            Console.Read();
        }
    }
}
