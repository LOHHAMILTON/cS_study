using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//DESK : CLASS의 기본

namespace _077_class
{
    class AA
    {
        //멤버 변수..
        int num1; // 기본적으로 private 속성
        public int num2, num3; //클래스 상에서 public선언이 그렇게 좋은 구조는 아니다.

        //멤버 함수
        public void print()
        {
            Console.WriteLine("aa: {0}, bb: {1}, cc: {2}", num1, num2, num3);
        }

        private void printprivate() // private 접근 한정자: 외부 접근 불가..
        {
            Console.WriteLine("aa: {0}, bb: {1}, cc: {2}", num1, num2, num3);

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            AA aa = new AA();
            //aa.num1 = 10;//오류
            aa.num2 = 100;
            aa.num3 = 1000;
            aa.print();
            //aa.printprivate()는 오류


        }
    }
}
