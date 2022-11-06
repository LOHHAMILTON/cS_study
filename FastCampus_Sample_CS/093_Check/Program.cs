using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
//성적프로그램을 3명까지만 저장하고 정보검색이 가능한 프로그램
//배열을 사용하여 데이터 저장
//저장했던 자료에서 참고하고 싶은 학생번호로 정보 보여주기
namespace _093_Check
{
    class Student
    {
        public int id;
        public int kor;
        public int math;
        public int eng;

        public void input()
        {
            Console.WriteLine("학생 ID를 입력하세요?");
            id = int.Parse(Console.ReadLine());
            Console.WriteLine("국어점수를 입력하세요?");
            kor = int.Parse(Console.ReadLine());
            Console.WriteLine("수학점수를 입력하세요?");
            math = int.Parse(Console.ReadLine());
            Console.WriteLine("영어점수를 입력하세요?");
            eng = int.Parse(Console.ReadLine());
        }
        public void PrintID()
        {   
            Console.WriteLine("학생 ID:   {0}", id);
        }
    }


    class Program
    {
        static void PrintID(Student[] students)
        {
            foreach (Student data in students)
            {
                data.PrintID();
            }
        }

        static int CheckID(int id, Student[]students)
        {
            for (int i = 0; i < students.Length; i++)
            {
                if (students[i].id == id)
                {
                    return i;
                }
            }
            return -1;
        }

        static void Main(string[] args)
        {
            int max = 3;
            int inputSel = 0;
            int selID = -1;

            Student[] students = new Student[max];

            for (int i = 0; i < max; i++)
            {
                students[i] = new Student();
                students[i].input();
                Console.WriteLine("");
            }
            Console.Clear();

            while (true)
            {
                PrintID(students);
                Console.WriteLine("학생 ID를 입력하세요? (0)나가기");
                inputSel = int.Parse(Console.ReadLine());

                if (inputSel == 0)
                    break;

                selID = CheckID(inputSel, students);

                if (selID >= 0)
                {
                    Console.WriteLine("국어 점수:  {0}", students[selID].kor);
                    Console.WriteLine("수학 점수:  {0}", students[selID].math);
                    Console.WriteLine("영어 점수:  {0}", students[selID].eng);

                    int total = students[selID].kor + students[selID].math + students[selID].eng;

                    Console.WriteLine("총점:  {0}", total);
                    Console.WriteLine("평균:  {0}", total / (float)max);

                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("학생 아이디가 없어요. 다시 입력하세요");
                }
            }
        }
    }
}


