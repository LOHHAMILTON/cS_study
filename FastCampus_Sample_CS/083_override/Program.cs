using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//DESK: 오버라이딩(다형성);
//같은 기능을 하는 함수를 오바라이딩(재정의)해서 새로운, 다른 기능을 추가적으로 할 수 있도록..

namespace _083_override
{
    class Super
    {
        protected int num;

        public virtual void Print() //반드시 virtual라는 키워드가 있어야함. 
        //virtual라는 키워드를 통해서 상속받은 애가 method를 override로 재정의 
        {
            Console.WriteLine("num: {0}", num);
        }
    }

    class AA : Super
    {
        public int a;

        public override void Print()
        {
            base.Print(); // override에선 기본적으로 base클래스의 method함수를 불러야함, 없애도 되긴함

            Console.WriteLine("AA a : {0}", a);
        }
    }
    class BB : Super
    {
        public int b;
        
        public override void Print()
        {
            base.Print();

            Console.WriteLine("BB b : {0}", b);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Super Super = new Super();
            Super.Print();

            Super aa = new AA();
            aa.Print();//만들어진 개체 속성의 print로 간다.!!
            //virture에서 override로

            Super bb = new BB();
            bb.Print();
            //Super라는 이름으로 여러개를 만들었는데, new로 서로 다른 자식의 개체로 생성
        }
    }
}
