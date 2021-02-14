using System;

namespace MyOOPLesson
{

    public class Mora
    {
        Random Rnd = new Random();
        public void Start()
        {
            MoraItem a = RandomMoraItem();
            Console.WriteLine("選手 a 出的拳是:" + a.ToString());
            MoraItem b = RandomMoraItem();
            Console.WriteLine("選手 b 出的拳是:" + b.ToString());
            MoraResult result = Fight(a, b);
            Console.WriteLine("猜拳結果為:" + result.ToString());
            Console.ReadLine();
        }
        public void TestFight()
        {
            foreach (MoraItem a in (MoraItem[])Enum.GetValues(typeof(MoraItem)))
            {
                foreach (MoraItem b in (MoraItem[])Enum.GetValues(typeof(MoraItem)))
                {
                    Console.WriteLine("選手 a 出的拳是:" + a.ToString());
                    Console.WriteLine("選手 b 出的拳是:" + b.ToString());
                    Console.WriteLine("猜拳結果為:" + Fight(a, b).ToString());
                }
            }
            Console.ReadLine();
        }
        private MoraItem RandomMoraItem()
        {
            return (MoraItem)Rnd.Next(0, 2);
        }
        private MoraResult Fight(MoraItem a, MoraItem b)
        {
            if (a == b)
            {
                return MoraResult.Tie;
            }
            if (a == MoraItem.Cloth && b == MoraItem.Scissors)
            {
                return MoraResult.BWin;
            }
            if (a == MoraItem.Scissors && b == MoraItem.Cloth)
            {
                return MoraResult.AWin;
            }
            if (a > b)
            {
                return MoraResult.AWin;
            }
            return MoraResult.BWin;
        }
        private enum MoraItem
        {
            Scissors,
            Stone,
            Cloth
        }
        private enum MoraResult
        {
            AWin,
            BWin,
            Tie
        }
    }
}
