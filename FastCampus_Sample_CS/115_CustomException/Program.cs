using _115_CustomException;
using System;
//DESC : CustomException 기초, when 키워드, StackTrace 키워드

namespace _115_CustomException
{

    class MyException : ApplicationException
    {
        public int Num { get; set; }

        public MyException() : base() { }
        public MyException(int a)
        {
            Num = a;
        }
        public override string ToString()
        {
            return "Num: " + Num;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            string readStr = Console.ReadLine();
            try
            {
                int num = int.Parse(readStr);

                if (num == 0 || num == 10)
                {
                    throw new MyException(num);
                }
            }
            catch (MyException e) when (e.Num == 0)
            {
                Console.WriteLine("when(e.Num == 0)");
                Console.WriteLine("MyException: " + e.Num);
                Console.WriteLine("MyException: " + e.StackTrace);
            }
            catch (MyException e) when (e.Num == 10)
            {
                Console.WriteLine("when(e.Num == 10)");
                Console.WriteLine("MyException: " + e.Num);
                Console.WriteLine("MyException: " + e.ToString());
                Console.WriteLine("MyException: " + e.StackTrace);

            }
        }
    }
}