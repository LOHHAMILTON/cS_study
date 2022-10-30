using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _040_Operator_Bit
//1Byte -> 8bit
//255 = 00000000;00000000;00000000;11111111
//256 = 00000000;00000000;00000001;00000000
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 15;
            int b = 22;
            int c = a & b;
            Console.WriteLine("a&b: " + c);

            int d = a | b;
            Console.WriteLine("a&b: " + d);

            string s = Convert.ToString(a, 2).PadLeft(32,'0');



        }
    }
}
