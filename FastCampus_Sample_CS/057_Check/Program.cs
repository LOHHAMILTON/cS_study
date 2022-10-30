using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _057_Check
{
    internal class Program
    {
        int input;
        static void Main(string[] args)
        {
            int maxNum = int.MinValue;
            int minNum = int.MaxValue;

            for (int i = 0; i < 5; i++)
            {
                Console.Write("학생의 성적을 입력하세요 :");
                int input = int.Parse(Console.ReadLine());
                if (maxNum < input)
                    maxNum = input;
                if (minNum > input)
                    minNum = input;
            }
            Console.WriteLine("최대값 : {0}, 최소값 : {1}", maxNum, minNum);
        }

    }
}
