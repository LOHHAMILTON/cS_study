﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// DESK : 디폴트 매개 변수(default parameter)
// 초기화 파라미터
// 반드시 파라미터 뒤에서 부터 순차적 초기화


namespace _046_Func_default
{
    internal class Program
    {
        static void PrintValue(int a, int b, int c = 100, int d = 0) // int a= 100, int b, int c, int d =0 불가
        {
            Console.WriteLine("PrintValue : {0}, {1}, {2}, {3}", a, b, c, d);
        }


        static void Main(string[] args)
        {
            PrintValue(0, 0, 0, 0);
            PrintValue(100, 2, 1);
            PrintValue(300, 300);
        }
    }
}
