using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*-----------------------------------------------------------------------------
 * Name: _090_abstract
 * DESC: abstract기본
-----------------------------------------------------------------------------*/
namespace _090_abstract
{
    abstract class abstractAA
    {
        protected int num;

        /*public abstractAA()
        {
            this.num = 0;
        }생성자 함수가 없어서 public AA(Int num) : base(num)필요
        */
        public abstractAA(int num)
        {
            this.num = num;
        }

        public abstract void abstractPrint(); //강제적으로 상속받은 클래스에서 구현부를 정의..

        public virtual void virtualPrint() //꼭 override할 필요는 없다.
        {
            Console.WriteLine("abstractAA virtual void virtualPrint");
        }

        public void Print()
        {
            Console.WriteLine("abstratAA print()");
        }
    }

    class AA : abstractAA
    {
        public AA(int num) : base(num)
        {
            Console.WriteLine("num: {0}", num);
        }
        public override void abstractPrint()
        {
            Console.WriteLine("abstractPrint");
        }

        public override void virtualPrint()
        {
            base.virtualPrint();

            Console.WriteLine("override void virtualPrint()");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            AA aa = new AA(100);

    
            aa.abstractPrint();
            aa.virtualPrint();
            aa.Print();
            //abstractAA aa = new AA(); //오류..
        }
    }
}