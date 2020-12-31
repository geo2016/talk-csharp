using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppYearLot
{
    class Lot
    {
        private List<string> giftForLot;
        public List<string> GiftForLot { 
            get {
                return giftForLot;
            }
            set {
                giftForLot = value;
            }
        }

        

        /// <summary>
        /// 执行抽奖过程
        /// </summary>
        /// <param name="lotTimes">抽取多少次</param>
        /// <returns>抽奖结果</returns>
        public List<string> LotIt(int lotTimes)
        {
            List<string> result = new List<string>();

            // 用来抽取的奖项
            List<string> lotGifts = new List<string>(giftForLot);

            // 确认抽奖次数不大于奖品数量
            if (lotTimes > lotGifts.Count)
            {
                Console.WriteLine("抽奖次数不能大于奖品数量。");
                return result;
            }

            Random rnd1 = new Random();

            int loop = 0;
            while (loop<lotTimes)
            {
                int giftUserLotIndex = rnd1.Next(lotGifts.Count);

                result.Add($"第{loop+1}次抽中 {lotGifts[giftUserLotIndex]}");

                lotGifts.RemoveAt(giftUserLotIndex);

                loop++;
            }


            return result;
        }
    }
}
