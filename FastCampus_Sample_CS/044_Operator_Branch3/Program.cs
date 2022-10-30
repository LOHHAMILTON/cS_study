using System;

//Name : _044_Operator_Branch3
//DESC : 조건문에 &&, || 연산자 이용하기 기초

namespace _044_Operator_Branch3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isA = false;
            bool isB = true;
            bool isC = true;
            bool isD = false;

            if (isA && isB)
            {
                Console.WriteLine("false && true => false");
            }

            if (isB && isC)
            {
                Console.WriteLine("true && true -=> true");

            }
            if (isC || isD)
            {
                Console.WriteLine("true || false => true");
            }
            if ( 2 > 1 && 3 < 4 || 1 > 2)
            {
                Console.WriteLine("true && false || false => true");
            }

        }
    }
}
