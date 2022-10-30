using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//DESC : 함수 기초 : 리턴형 0, 파라미터 0(2개 이상의 파라미터)

namespace _063_Funout
{
    internal class Program
    {
        static void InitNum(out int addNum)
        {
            addNum = 100;
        }

        static void initRefNum(ref int refNum)
        {
            refNum = 100;
        }

        static void Main(string[] args)
        {
            int a;
            int b = 0;

            InitNum(out a);
            Console.WriteLine("a: " + a);

            initRefNum(ref b);
            Console.WriteLine("b: " + b);

        }
    }
}
