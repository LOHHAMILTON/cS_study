using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _056_Check
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int a = rnd.Next(0, 100);
            int Try = 0;

            while (true)
            {
                Try++;
                Console.WriteLine("1~99 사이 어떤 숫자 일까요(단, 0은 나가기)");
                int input = int.Parse(Console.ReadLine());
                if (input == 0)
                {
                    break;
                }
                if (input == a)
                {
                    Console.WriteLine("정답입니다.");
                    break;
                }
                else if(input > a)
                {
                    Console.WriteLine("입력한 수는 커요");
                }
                else
                {
                    Console.WriteLine("입력한 수는 작아요");
                }
            } Console.WriteLine("총 {0}번 시도",Try);
        }
    }
}
