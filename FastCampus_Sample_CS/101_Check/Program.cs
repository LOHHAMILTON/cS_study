using System;
using System.Collections;

namespace _101_Check
{
    class Student
    {
        private int id;
        private int kor;
        private int math;
        private int eng;

        public int ID { get { return id; } }
        public int KOR { get { return kor; } }
        public int MATH { get { return math; } }
        public int ENG { get { return eng; } }


        public Student()
        {
            this.id = 0;
            this.kor = 0;
            this.math = 0;
            this.eng = 0;
        }

        public void input()
        {
            Console.WriteLine("학생 ID를 입력하세요.");
            this.id = int.Parse(Console.ReadLine());
            Console.WriteLine("학생 KOR를 입력하세요.");
            this.kor = int.Parse(Console.ReadLine());
            Console.WriteLine("학생 MATH를 입력하세요.");
            this.math = int.Parse(Console.ReadLine());
            Console.WriteLine("학생 ENG를 입력하세요.");
            this.eng = int.Parse(Console.ReadLine());
        }

        public void PrintID()
        {
            Console.WriteLine("학생의 아이디 : {0}", this.id);
        }
        public int GetTotal()
        {
            return kor + eng + math;
        }
    }

    internal class Program
    {

        static int CheckID(int id, Hashtable hashtable)
        {
            if (hashtable.ContainsKey(id))
            {
                return id;
            }
            return -1;
        }
        static void PrintstudentsID(Student[] student)
        {
            foreach (Student data in student)
            {
                data.PrintID();
            }
        }

        static int CheckIdD(int idd, Student[] student)
        {
            for (int i = 0; i < student.Length; i++)
            {
                if (idd == student[i].ID)
                    return i;
            }
            return -1;
        }
        static void Main(string[] args)
        {
            Hashtable hashtable = new Hashtable();
            int selnum = 0;
            int inputsel = -1;
            int max = 3;
            Student[] student = new Student[max];

            for (int i = 0; i < max; i++)
            {
                student[i] = new Student();
                student[i].input();
                Console.WriteLine();
            }
            Console.Clear();
            while (true)
            {
                PrintstudentsID(student);
                Console.WriteLine("학생아이디를 입력하세요.  나가기(0)");
                inputsel = int.Parse(Console.ReadLine());

                if (inputsel == 0)
                {
                    break;
                }
                selnum = CheckIdD(inputsel, student);
                if (selnum >= 0)
                {
                    Console.WriteLine("국어 점수:   {0}", student[selnum].KOR);
                    Console.WriteLine("수학 점수:   {0}", student[selnum].MATH);
                    Console.WriteLine("영어 점수:   {0}", student[selnum].ENG);

                    int total = student[selnum].GetTotal();

                    Console.WriteLine("총점:  {0}", total);
                    Console.WriteLine("평균:  {0}", total / (float)max);

                    Console.WriteLine("");

                }
                else
                {
                    Console.WriteLine("학생아이디가 없어요. 다시 입력하세요");
                }


            }
        }
    }

}
