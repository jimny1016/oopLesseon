using System;

namespace MyOOPLesson
{
    public class GetVIPInfo
    {
        public void test() 
        {
            for (int i = -1; i < 12; i++)
            {
                Console.WriteLine("目前VIPLV=" + i.ToString());
                string vipInfo = "";
                Start(i, ref vipInfo);
                Console.WriteLine("VIPInfo=" + vipInfo);
            }
            Console.ReadLine();
        }

        public void Start(int vipLv,ref string info) 
        {
            //改造後
            if (vipLv <= 0 || vipLv >= 10)
            {
                return;
            }

            if (vipLv <= 3)
            {
                info = "初階會員";
                return;
            }

            if (vipLv <= 7)
            {
                info = "中階會員";
                return;
            }

            info = "高階會員";
            return;
        }
    }
}
