using System;

namespace Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] goods = { "apple", "banana", "orange"};
            String[] prices = { "100", "200", "300"};
            
            while(true)
            {
                Console.WriteLine("欢迎来到水果店！");
                int i = 0;
                for (i = 0; i < goods.Length; i++)
                {
                    Console.WriteLine("{0}:{1}的价格是{2}元", i+1, goods[i], prices[i]);
                }
                Console.WriteLine("请输入宁要购买的商品的编号：");
                String chooseStr;
                int chooseNum;
                //类型转换
                chooseStr = Console.ReadLine();
                chooseNum = Convert.ToInt32(chooseStr);

                if(chooseNum == 0)
                {
                    Console.Clear();
                    Console.WriteLine("你没钱啦，爪巴！");
                    Console.ReadKey();
                }
                else if(chooseNum < 0 || chooseNum > 3)
                {
                    Console.WriteLine("输入编号有误，请瞪大眼睛重新输入！(按任意键继续购买)");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("你购买的商品是：{0} , 价格为：{1} (按任意键继续购买)", goods[chooseNum-1], prices[chooseNum-1]);
                    Console.ReadKey();
                }
                
                Console.Clear();

            }
        }
    }
}
