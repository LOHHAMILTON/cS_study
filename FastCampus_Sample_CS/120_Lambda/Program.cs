using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _120_Lambda
{
    delegate void dPrint(string str);
    delegate int dAdd(int a);

    internal class Program
    {
        static public void CallPrint(string str)
        {
            Console.WriteLine(str);
        }

        static public int CallAdd(int a)
        {
            return a + a;
        }

{        static void Main(string[] args)
        {
            dPrint dp = CallPrint;
            dp("CallPrint");
            dp = (Str) => { Console.WriteLine(Str); };
            dp("Lambda");

            dAdd da = CallAdd;
            Console.WriteLine("CallAdd " + da(10));
            da = (a) => { return a + a; };
            Console.WriteLine("Lambda: "+ da(10));

        }
    }
}
