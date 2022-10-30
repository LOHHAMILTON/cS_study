using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*----------------------------------------------------------
 * name : _013_Data6
 * DESC : 소수점 데이터형의 기초, 리터럴 접미사(f(F), m(M))
 -----------------------------------------------------------*/


namespace _013_Data6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float a = 3.14897978978789789787978798789f;
            Console.WriteLine("a: {0}", a);

            double b = 3.14897978978789789787978798789;
            Console.WriteLine("b: {0}", b);

            decimal c = 3.14897978978789789787978798789m;
            Console.WriteLine("c: {0}", c);



        }
    }
}
