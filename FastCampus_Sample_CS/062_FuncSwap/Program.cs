using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Call by Value
 * 값에 의한 호출
 * 함수에서 값에 영향을 주지 않는다.
 * 일반 함수
 * void swap(int a, int b);
 */

/* Call by reference
 * 주소에 의한 호출
 * 함수에서 값에 영향을 준다.
 * ref 키워드를 가지는 함수
 * void swap(ref int a, ref int b)
 */

// Name : 062_FuncSwap
// Desc : 함수 기초:리턴형 x, 파라미터 0(2개 이상의 파라미터)

namespace _062_FuncSwap
{
    internal class Program
    {
        static public void ValueSWap(int a, int b)
        {
            int temp = a;
            a = b;
            b = temp;

            Console.WriteLine("ValueSwap");
            Console.WriteLine("a :{0}  b : {1}", a, b);
        }
        static public void RefSWap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;

            Console.WriteLine("ValueSwap");
            Console.WriteLine("a :{0} b : {1}", a, b);
        }
        static void Main(string[] args)
        {
            int num1 = 100;
            int num2 = -100;

            ValueSWap(num1, num2);
            Console.WriteLine("a: {0} b : {1}", num1, num2);

            RefSWap(ref num1, ref num2);
            Console.WriteLine("a: {0} b : {1}", num1, num2);

        }
    }
}
