using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _104_GenericClass
{
    class GenericAA<T>
    {
        private T num;
        public T Getnum()
        {
            return num;
        }

        public void SetNum(T data)
        {
            num = data;
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {  
            GenericAA<int> AA = new GenericAA<int>();
            AA.SetNum(100);
            Console.WriteLine("AA " + AA.Getnum());

            GenericAA<float> BB = new GenericAA<float>();
            BB.SetNum(100);
            Console.WriteLine("BB: " + BB.Getnum());
        }
    }
}
