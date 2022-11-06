using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*c#배우기 메인 1강*/

namespace _001_HelloWorld
{
    class Base
    {
        int num;

        public void Print()
        {
            Console.WriteLine("num: {0}", num);
        }
    }

    class AA : Base
    {
        int a;
        public void PrintA()
        {
            Console.WriteLine("a: {0}", a);
        }

    }

    class BB : Base
    {
        int b;
        public void PrintB()
        {
            Console.WriteLine("b: {0}", b);
        }

    }

    internal class Program
    {
        static void Main(string[] args)// 함수의 속성 , 리턴형, 함수의 이름
        {
            Base bb = new BB();
            bb.Print();
            bb.PrintB();

            BB bbb = bb as BB;
            bbb.Print();
            bbb.PrintB();
            Console.WriteLine("HelloWorld");
        }
    }
}
