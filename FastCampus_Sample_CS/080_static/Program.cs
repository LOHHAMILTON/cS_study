using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

//DESK : static 키워드, 정적 변수, 정적 함수

namespace _080_static
{
    internal class Program
    {
        class AA
        {
            public static int a;
            public static int b;
            public static readonly int c = 200; //상수화된다.

            public static void print()
            {
                Console.WriteLine("a: {0}", a);
                Console.WriteLine("b: {0}", b);
            }

        }
        
        class BB
        {
            public int a;
            public int b;
            
            public void Print()
            {
                Console.WriteLine("a: {0}", a);
                Console.WriteLine("b: {0}", b);
            }
        }

        static void Main(string[] args)
        {
            AA.a = 10; //객체 생성없이 바로 접근
            AA.b = 100; //객체 생성없이 바로 접근
            //AA.c = 200; //오류 readonly이므로 변경 불가

            AA.print();

            //BB.a //오류
            //BB.b //오류

            BB bb = new BB();
            bb.a = 10;
            bb.b = 100;

            bb.Print();


        }
    }
}
