using _075_Check;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _075_Check
{
    class Student
    {
        public int id;
        public int kor;
        public int math;
        public int eng;

        public Student()
        {
        }
    }

    class ID:Student
    {
        public ID()
        {
            Console.WriteLine("학생 ID를 입력하세요?");
            id = int.Parse(Console.ReadLine());
        }
    }

    class KOR : Student
    {
        public  KOR()
        {
            Console.WriteLine("학생 ID를 입력하세요?");
            kor = int.Parse(Console.ReadLine());
        }
    }

    class MATH : Student
    {
        public MATH()
        {
            Console.WriteLine("학생 ID를 입력하세요?");
            math = int.Parse(Console.ReadLine());
        }
    }

    class ENG : Student
    {
        public ENG()
        {
            Console.WriteLine("학생 ID를 입력하세요?");
            eng = int.Parse(Console.ReadLine());
        }
    }
}

internal class Program
{
    static void Main(string[] args)
    {
        int max = 3;
        int inputSel = 0;
        int selID = -1;


        ID[] Id = new ID[max];
        KOR[] Kor = new KOR[max];
        MATH[] Math = new MATH[max];
        ENG[] Eng = new ENG[max];

        for (int i = 0; i < max; i++)
        {
            Id[i] = new ID();
            Kor[i] = new KOR();
            Math[i] = new MATH();
            Eng[i] = new ENG();
        }

        Console.Clear();

    }
}