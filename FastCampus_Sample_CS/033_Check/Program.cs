using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _033_Check
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("국어 점수 입력하세요?");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("영어 점수 입력하세요?");
            string str2 = Console.ReadLine();

            int b = int.Parse(str2);

            int sum = a + b;
            float average = sum / 2f;
            Console.WriteLine("합 :{0}, 평균 : {1}", sum, average);


        }
    }
}
