using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _085_class_has_a
{
    class AA
    {
        private int num;
        public void SecNum(int num)
        {
            this.num = num;
        }
        public void Print()
        {
            Console.WriteLine("num: " + num);
        }
    }

    class BB
    {
        AA[] aa;
       
        public BB() //생성자함수에선 무조건 초기화해야 되는 거 여기서 선언
        {
            aa = new AA[5];
        }
        public void SecNum(int index, int num)
        {
            if (index<aa.Length)
            {
                aa[index] = new AA();
                aa[index].SecNum(num);
            }
        }

        public void Print()
        {
            for(int i =0; i < aa.Length; i++)
                {
                if(aa[i] != null)
                {
                    aa[i].Print();
                }
            }
        }
    }//결국 AA에 있는 거 모드 콜하는것
    internal class Program
    {
        static void Main(string[] args)
        {
            BB bb = new BB();
            bb.SecNum(0,0);
            bb.SecNum(1, 100);
            bb.SecNum(2, 200);
            bb.SecNum(3, 300);
            bb.SecNum(4, 400);

            bb.Print();

        }
    }
}
