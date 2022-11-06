using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Linq.Expressions;
using System.CodeDom;
using System.Xml.Schema;

namespace _064_Check
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            string[] run = { "1", "2", "3", "4" };
            int room;
            while (true)
            {
                Thread.Sleep(100); // 딜레이
                Console.Clear(); // 화면지우기


                int rndNum = rnd.Next(1, 5);//
                room = rndNum - 1;
                run[room] = run[rndNum - 1].Replace((char)(rndNum + 48), ' ');
                run[room] += "  ";
                run[room] += rndNum.ToString();


                const string Line = "-------------------------------------------------";
                int End_Line = Line.Length;

                string str = Line + "\n" + run[0] + "\n" + run[1] + "\n" + run[2] + "\n" + run[3] + "\n" + Line;
                Console.WriteLine(str);



                if (run[0].Length >= End_Line || run[1].Length >= End_Line || run[2].Length >= End_Line || run[3].Length >= End_Line)
                {
                    int runNUM = 0;
                    string strResult = "결과:   {0}번 선수 우승 !! ";

                    if (run[0].Length >= End_Line)
                        runNUM = 1;

                    else if (run[1].Length >= End_Line)
                        runNUM = 2;

                    else if (run[2].Length >= End_Line)
                        runNUM = 3;

                    else
                        runNUM = 4;

                    Console.WriteLine(strResult, runNUM);
                    Console.Write("다시 하시려면 0번 입력 ");
                    if ("0" == Console.ReadLine())
                    {
                        run[0] = "1";
                        run[1] = "2";
                        run[2] = "3";
                        run[3] = "4";

                    }
                    else
                    {
                        break;
                    }
                }

            }

        }

    }
}
