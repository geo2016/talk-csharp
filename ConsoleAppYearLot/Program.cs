using System;
using System.Collections.Generic;

namespace ConsoleAppYearLot
{
    class Program
    {
        static void Main(string[] args)
        {
            Lot lotObj = new Lot();

            lotObj.GiftForLot = new List<string>()
                                    {
                                        "笔记本电脑",
                                        "IPad平板",
                                        "奔驰轿车",
                                        "别墅",
                                        "10万现金",
                                        "Iphone手机",
                                    };


            while (true)
            {
                Console.WriteLine("请输入抽奖次数：（输入X退出）");

                string line1 = Console.ReadLine();

                if (line1.ToUpper() == "X")
                {
                    break;
                }

                if (int.TryParse(line1, out int timesLot))
                {
                    if (timesLot < 1)
                    {
                        Console.WriteLine("抽奖次数不能小于1。");
                        Console.WriteLine("\r\n");
                        continue;
                    }


                    List<string> result = lotObj.LotIt(timesLot);
                    foreach (string item in result)
                    {
                        Console.WriteLine(item);
                    }

                    Console.WriteLine("\r\n"); 
                }
                else
                {
                    Console.WriteLine("抽奖次数输入无效！");
                }
            }
            

        }
    }
}
