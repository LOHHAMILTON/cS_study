using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _031_ReadLine2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("첫 정수를 입력하세요?");
            string str1 = Console.ReadLine();
            Console.Write("두 정수를 입력하세요?");
            string str2 = Console.ReadLine();

            int num1 = int.Parse(str1);//입력값은 문자 -> 변환 필요
            int num2 = Convert.ToInt32(str2);//입력값은 문자 -> 정수로 변환

            int sum = num1 + num2; // "+" 두수의 합..연산자
            Console.WriteLine("{0} + {1} = {2}", num1, num2, sum);
            }
    }
}
