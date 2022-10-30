using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Check_point002
{
    internal class Program
    {
        static void Start()
        {
            Console.WriteLine("성적 프로그램 - Method");
        }

        static void Input(ref int kor, ref int mat, ref int eng)
        {
            Console.WriteLine("국어 성적 입력(쩡수)? ");
            kor = int.Parse(Console.ReadLine());
            Console.WriteLine("수학 성적 입력(쩡수)? ");
            mat = int.Parse(Console.ReadLine());
            Console.WriteLine("영어 성적 입력(쩡수)? ");
            eng = int.Parse(Console.ReadLine());
        }

        static int Totalsum(int kor, int mat, int eng)
        {
            Console.WriteLine("kor : {0}, mat: {1}, eng{2} ", kor, mat, eng);
            return kor + mat + eng;
        }

        static void Average(int total, out float average)
        {
            average = total / 3f;
        }

        static void Main(string[] args)
        {
            int kor = 0;
            int eng = 0;
            int mat = 0;
            int total;
            float average;

            Start();
            Input(ref kor, ref mat, ref eng);
            total = Totalsum(kor, mat, eng);
            Average(total, out average);

            Console.WriteLine("Total : {0}   Average : {1}", total, average);
        }
    }
}
