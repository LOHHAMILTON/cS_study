using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _101_1_Check
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


        static void Main(string[] args)
        {
            Hashtable hashtable_id = new Hashtable();
            Hashtable hashtable_kor = new Hashtable();
            Hashtable hashtable_math= new Hashtable();
            Hashtable hashtable_eng = new Hashtable();
            int count = 0;
            int inputsel = 0;
            int selnum = -1;

            while (true)
            {
                Console.Write("==성적입력중== 나가기(0)");
                int start = int.Parse(Console.ReadLine());
                if(start == 0)
                {
                    break;
                }
                Student student = new Student();
                student.input();
                Console.WriteLine();
                hashtable_id.Add(count, student.ID);
                hashtable_kor.Add(student.ID, student.KOR);
                hashtable_math.Add(student.ID, student.MATH);
                hashtable_eng.Add(student.ID, student.ENG);
                count++;
                Console.WriteLine(' ');


            }
            Console.Clear();
            while (true)
            {
                for (int i = 0; i < hashtable_id.Count; i++)
                {
                    Console.WriteLine("학생 ID : {0}", hashtable_id[i]);
                }

                Console.WriteLine("학생아이디를 입력하세요.  나가기(0)");
                inputsel = int.Parse(Console.ReadLine());

                if (inputsel == 0)
                {
                    break;
                }
                selnum = CheckID(inputsel, hashtable_kor);
                if (selnum >= 0)
                {
                    Console.WriteLine("국어 점수:   {0}", hashtable_kor[selnum]);
                    Console.WriteLine("수학 점수:   {0}", hashtable_math[selnum]);
                    Console.WriteLine("영어 점수:   {0}", hashtable_eng[selnum]);

                    int total = (int)hashtable_kor[selnum] + (int)hashtable_math[selnum] + (int)hashtable_eng[selnum];

                    Console.WriteLine("총점:  {0}", total);
                    Console.WriteLine("평균:  {0}", total / (float)3);

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
