using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _086_interface
{
    interface IAA
    {
        //public int a; //에러;;
        //public void IPrint(){ } //에러;;
        //public void IPrint(); //에러;;
        void IAAPrint();
    }

    interface IBB
    {
        void IBBPrint();
    }

    class Super
    {
        protected int num;

        public virtual void Print()
        {
            Console.WriteLine("===============================");
        }
    }

    class AA : IAA //AA는 IAA를 상속받았음 무조건 IAAPRINT를 재정의해줘야함
    {
        public void IAAPrint()
        {

                Console.WriteLine("class AA interface IAA에 IAAPrint() 재정의");
         }
    }
    class BB : IBB //BB는 IBB를 상속받았음 무조건 IAAPRINT를 재정의해줘야함
    {
        public void IAAPrint()
        {
            Console.WriteLine("class BB interface IAA에 IAAPrint() 재정의");
        }
        public void IBBPrint()
        {

            Console.WriteLine("class BB interface IBB에 IBBPrint() 재정의");
        }
    }

    class CC : Super, IAA, IBB {
        public override void Print() //선언을 해도 되고 안해도 됨
        {
            base.Print();
            Console.WriteLine("class Super => Print() 재정의");
        }

        public void IAAPrint()
        {
            Console.WriteLine("class CC => interface IAA에 IAAPrint() 재정의");
        }

        public void IBBPrint()
        {
            Console.WriteLine("class CC interface IBB에 IBBPrint() 재정의");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            AA aa = new AA();
            aa.IAAPrint();

            BB bb = new BB();
            bb.IAAPrint();
            bb.IBBPrint();

            //IAA Iaaa = new IAA();
            IAA Iaa = new AA(); //참조는 가능
            Iaa.IAAPrint();

            IBB Ibb = bb as IBB;
            Ibb.IBBPrint();

            CC cc = new CC();
            cc.Print();
            cc.IAAPrint();
            cc.IBBPrint();

            Super sCC = cc as Super;
            sCC.Print();

            IAA IAAcc = cc as IAA;
            IAAcc.IAAPrint();

            IBB IBBcc = cc as IBB;
            IBBcc.IBBPrint();
        }
    }
}
