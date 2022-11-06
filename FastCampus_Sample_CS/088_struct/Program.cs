﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Desc : 구조체 기본

namespace _088_struct
{
    struct AA
    {
        public int x;
        public int y;

        //public AA() {  } //오류: 파라미터 없음
        public AA(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public void Print()
        {
            Console.WriteLine("x:  {0}, y:  {1}", x, y);
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            AA aa = new AA(10, 20);
            aa.x = 100;
            aa.Print();

            AA aaa;
            aaa.x = 100;
            aaa.y = 200;
            aaa.Print();

            AA copyAA = aa; //VALUE Type;
            copyAA.x = 1000;
            copyAA.y = 2000;
            copyAA.Print();
            aa.Print();
        }
    }
}
