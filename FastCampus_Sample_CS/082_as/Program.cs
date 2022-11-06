using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//DESK : as, is키워드
namespace _082_as
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

        public AA()
        {
            a = 100;
        }
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
        static void Main(string[] args)
        {
            Base _base = new Base();
            _base.Print();

            Base aa = new AA(); //부모 클래스의 이름으로 선언하고 자식클래스로 객체를 만들수 잇다.
            aa.Print();

            if(aa is BB)
            {
                Console.WriteLine("aa는 BB의 객체 입니다.");
            }
            else if (aa is AA)
            {
                Console.WriteLine("aa는 AA의 객체 입니다.");
            }

            Base bb = new BB();//bb는 BASE

            BB copyBB = bb as BB;// 강제 형 변환
            // (bb)aa로 선언하면 안되나, 되긴 되는데 위험함
            if(null != copyBB)
            {
                Console.WriteLine("--------------------------");
                Console.WriteLine("copyBB는 BB객체를 형식 변환!!");
                copyBB.PrintB();
            }
            //AA copyAA = (AA)bb; //예외상황 발생
            AA copyAA = bb as AA;
            if(null == copyAA)
            {
                Console.WriteLine("--------------------------");
                Console.WriteLine("copyAA는 AA객체가 아니므로 null!!");

                copyAA = new AA();
                copyAA.Print();
                copyAA.PrintA();

                AA asAA = copyAA as AA; //강제 형변환
                asAA.PrintA();
            }
        }
    }
}
