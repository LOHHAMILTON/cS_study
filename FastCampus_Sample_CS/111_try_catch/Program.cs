using System;

//try_catch 기초
namespace _111_try_catch
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int inputNum = 0;
            bool isCorrect = false;
            while (!isCorrect)
            {
                Console.WriteLine("입력문자: ");
                string readStr = Console.ReadLine();
                try
                {
                    inputNum = int.Parse(readStr);
                    isCorrect = true;
                }
                catch (FormatException e)
                {
                    Console.WriteLine(e.Message);
                    Console.WriteLine("입력문자: " + readStr + "  정수 입력 하세요");
                }
                Console.WriteLine("inputNum:  " + inputNum);
            }
        }

    }
}
