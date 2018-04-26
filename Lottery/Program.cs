using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lottery
{
    class Program
    {
        static void Main(string[] args)
        {
            // 建立亂數物件
            Random rand = new Random();

            // 紀錄產生次數
            int count = 1;

            // 重複10次
            while (count <= 11) {
                // 用亂數物件產生亂數
                int r1 = rand.Next(1, 43);
                int r2 = rand.Next(1, 43);
                int r3 = rand.Next(1, 43);
                int r4 = rand.Next(1, 43);
                int r5 = rand.Next(1, 43);
                int r6 = rand.Next(1, 43);

                // 顯示
                Console.WriteLine("[{0:00}] 號碼 : {1:00} {2:00} {3:00} {4:00} {5:00}", count, r1, r2, r3, r4, r5, r6);

                // 累加產生次數
                count++;

                     }

            // 防止視窗自動關閉
            Console.ReadLine();
        }
    }
}
