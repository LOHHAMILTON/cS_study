using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _055_check
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int num = 0;

            for (int i =0; i<5; i++)
            {
                Console.WriteLine("다음 두 수의 합은 몇?(총5문제)");
                int a = rnd.Next(0, 100);
                int b = rnd.Next(0, 100);
                Console.WriteLine("{0} + {1} = ??", a, b);
                int sum = a + b; 
                int ans = int.Parse(Console.ReadLine());
                if(ans == sum)
                {
                    Console.WriteLine("== 정답 ==");
                    Console.WriteLine();

                    num++;
                }
                else
                {
                    Console.WriteLine("== 오답(정답은 {0})", sum);
                }
                Console.WriteLine("총 정답은 {0}개 수고하셨습니다.", num);
            }
        }
    }
}
